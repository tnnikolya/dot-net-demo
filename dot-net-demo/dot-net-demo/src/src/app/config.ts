import { Injectable } from '@angular/core';

@Injectable()
export class Config {
  data_base_url: string;
  api_base_url: string;
  api_organization_url: string;
  api_license_url: string;
  api_update_url: string;
  constructor() {
    this.data_base_url = 'http://catalog.data.gov/api/3/action/';
    this.api_base_url = 'http://10.211.55.3/dot-net-demo/api';
    this.api_organization_url = `${this.api_base_url}/organization`;
    this.api_license_url = `${this.api_base_url}/license`;
    this.api_update_url = `${this.api_base_url}/update`;
  }
}
