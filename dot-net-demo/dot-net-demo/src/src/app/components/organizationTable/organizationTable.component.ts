import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { OrganizationService } from '../services/organization.service';
import { MatTableDataSource } from '@angular/material/table';
import { Organization } from '../../models/organization';
import { MatPaginator } from '@angular/material/paginator';

@Component({
  selector: 'organization-table',
  templateUrl: './organizationTable.component.html',
  styleUrls: ['./organizationTable.component.scss']
})
export class OrganizationTableComponent implements OnInit {
  constructor(private organizationService: OrganizationService) { }
  dataSource: MatTableDataSource<Organization>;
  displayedColumns: string[] = ['id', 'name'];
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  ngOnInit(): void {
    let organizations = [] as Array<Organization>;
    this.dataSource = new MatTableDataSource<Organization>(organizations);
    this.organizationService.getOrganizations().subscribe(_organizations => {
      this.dataSource = new MatTableDataSource<Organization>(_organizations);
      this.dataSource.paginator = this.paginator;
    });
  }
}
