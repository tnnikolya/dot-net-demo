import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { License } from '../../models/license';

@Injectable()
export class LicenseService {
  private licenseSubject: BehaviorSubject<Array<License>>;
  constructor() {
    let licenses = [
      {
        idLicense: 1, status: 'active', maintainer: '', family: '', title: 'Open Data Commons Attribution License', domain_data: true, is_okd_compliant: true,
        is_generic: true, url: 'http://www.opendefinition.org/licenses/odc-by', is_osi_compliant: true, domain_content: false, domain_software: true, id: 'other-closed'
      },
      {
        idLicense: 2, status: 'active', maintainer: '', family: '', title: 'test2', domain_data: true, is_okd_compliant: true,
        is_generic: true, url: 'test4', is_osi_compliant: true, domain_content: false, domain_software: true, id: '2-2'
      },
      {
        idLicense: 3, status: 'active', maintainer: '', family: '', title: 'test2', domain_data: true, is_okd_compliant: true,
        is_generic: true, url: 'test4', is_osi_compliant: true, domain_content: false, domain_software: true, id: '3-3'
      },
      {
        idLicense: 4, status: 'active', maintainer: '', family: '', title: 'test2', domain_data: true, is_okd_compliant: true,
        is_generic: true, url: 'test4', is_osi_compliant: false, domain_content: true, domain_software: true, id: '4-4'
      }
    ] as Array<License>;
    this.licenseSubject = new BehaviorSubject(licenses);
  }

  getLicenses() {
    return this.licenseSubject.asObservable();
  }
}
