import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { License } from '../../models/license';
import { HttpClient } from '@angular/common/http';
import { Config } from '../../config';
import { Response } from '../../models/response';

@Injectable()
export class LicenseService {
  constructor(private http: HttpClient, private config: Config) { }

  getLicenses() {
    return this.http.get<Response>(this.config.api_license_url);
  }
}
