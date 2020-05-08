import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { License } from '../../models/license';
import { MatPaginator } from '@angular/material/paginator';
import { LicenseService } from '../services/license.service';

@Component({
  selector: 'license-table',
  templateUrl: './licenseTable.component.html',
  styleUrls: ['./licenseTable.component.scss']
})
export class LicenseTableComponent implements OnInit {
  constructor(private licenseService: LicenseService) { }
  dataSource: MatTableDataSource<License>;
  displayedColumns: string[] = ['status', 'title', 'domain_data',
    'is_okd_compliant', 'is_generic', 'is_osi_compliant', 'domain_content', 'domain_software', 'id'];
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  ngOnInit(): void {
    let licenses = [] as Array<License>;
    this.dataSource = new MatTableDataSource<License>(licenses);
    this.licenseService.getLicenses().subscribe(_res => {
      if (_res.Success) {
        this.dataSource = new MatTableDataSource<License>(_res.Result);
        this.dataSource.paginator = this.paginator;
      }
    });
  }
}
