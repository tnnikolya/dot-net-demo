import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Config } from '../../config';
import { Response } from '../../models/response';

@Injectable()
export class UpdateService {
  constructor(private http: HttpClient, private config: Config) { }

  updateData(action: string) {
    return this.http.put<Response>(this.config.api_update_url, { action: action });
  }
}
