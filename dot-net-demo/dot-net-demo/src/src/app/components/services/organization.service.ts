import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Organization } from '../../models/organization';

@Injectable()
export class OrganizationService {
  private organizationSubject: BehaviorSubject<Array<Organization>>;
  constructor() {
    let organizations = [
      { id: 1, name: 'Test1' },
      { id: 2, name: 'Test2' },
      { id: 3, name: 'Test3' },
      { id: 4, name: 'Test4' },
      { id: 5, name: 'Test5' },
      { id: 6, name: 'Test6' },
      { id: 7, name: 'Test7' },
      { id: 8, name: 'Test8' },
      { id: 9, name: 'Test9' },
      { id: 10, name: 'Test10' },
      { id: 11, name: 'Test11' },
      { id: 12, name: 'Test12' },
      { id: 13, name: 'Test13' },
      { id: 14, name: 'Test14' },
      { id: 15, name: 'Test15' },
      { id: 16, name: 'Test16' },
      { id: 17, name: 'Test17' },
      { id: 18, name: 'Test18' },
      { id: 19, name: 'Test19' },
      { id: 20, name: 'Test20' },
      { id: 21, name: 'Test21' }
    ] as Array<Organization>; 
    this.organizationSubject = new BehaviorSubject(organizations);
  }
  
  getOrganizations() {
    return this.organizationSubject.asObservable();
  }
}
