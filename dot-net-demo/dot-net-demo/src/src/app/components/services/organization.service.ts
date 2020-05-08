import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Config } from '../../config';
import { Response } from '../../models/response';

@Injectable()
export class OrganizationService {
  constructor(private http: HttpClient, private config: Config) { }
  
  getOrganizations() {
    return this.http.get<Response>(this.config.api_organization_url);
  }
}
