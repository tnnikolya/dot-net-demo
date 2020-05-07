import { Component } from '@angular/core';

@Component({
  templateUrl: './populate.component.html',
  styleUrls: ['./populate.component.scss']
})
export class PopulateComponent {
  params: any[] = [
    { value: 'organization_list' },
    { value: 'license_list' }
  ];
}
