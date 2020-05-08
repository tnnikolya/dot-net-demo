using AutoMapper;
using dot_net_demo.Business.Repositories;
using dot_net_demo.Business.Services;
using dot_net_demo.Models.DTO;
using dot_net_demo.Models.DTO.data;
using dot_net_demo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Business.Managers
{
    public class DataManager : IDataManager
    {
        private IDataService _dataService { get; set; }
        private IRepository _repository { get; set; }
        private Mapper _mapper { get; set; }
        public DataManager(IDataService dataService, IRepository repository)
        {
            _dataService = dataService;
            _repository = repository;
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LicenseData, License>();
                cfg.CreateMap<License, LicenseDto>();
                cfg.CreateMap<Organization, OrganizationDto>();
            });
            _mapper = new Mapper(config);
        }

        public async Task<bool> CreateUpdateOrganizationDataAsync(string action)
        {
            var result = await _dataService.GetDataAsync<List<string>>(action);
            if (result.Success)
            {
                var organizations = result.Result.Select(org => new Organization { name = org }).ToList();
                var res = await _repository.CreateUpdateOrganizationsAsync(organizations);
                return res;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> CreateUpdateLicenseDataAsync(string action)
        {
            var result = await _dataService.GetDataAsync<List<LicenseData>>(action);
            if (result.Success)
            {
                var licenses = result.Result.Select(license => _mapper.Map<License>(license)).ToList();
                var res = await _repository.CreateUpdateLicensesAsync(licenses);
                return res;
            }
            else
            {
                return false;
            }
        }

        public List<OrganizationDto> GetOrganizations()
        {
            var organizations = _repository.GetOrganizations();
            var orgsDto = organizations.Select(org => _mapper.Map<OrganizationDto>(org)).ToList();
            return orgsDto;
        }

        public List<LicenseDto> GetLicense()
        {
            var licenses = _repository.GetLicenses();
            var licsDto = licenses.Select(lic => _mapper.Map<LicenseDto>(lic)).ToList();
            return licsDto;
        }
    }
}
