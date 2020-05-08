import { Component } from '@angular/core';
import { UpdateService } from '../services/update.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  templateUrl: './populate.component.html',
  styleUrls: ['./populate.component.scss']
})
export class PopulateComponent {
  selectedValue: string;
  unblock: boolean;
  params: any[] = [
    { value: 'organization_list' },
    { value: 'license_list' }
  ];

  constructor(private updateService: UpdateService, private matShackBar: MatSnackBar) {
    this.unblock = true;
  }

  updateDate() {
    this.unblock = false;
    this.updateService.updateData(this.selectedValue).subscribe(res => {
      if (res.Success) {
        this.matShackBar.open(`${this.selectedValue} have been updated successfully!`, null, { duration: 2000 });
        this.unblock = true;
      }
    })
  }

  changeValue(value) {
    this.selectedValue = value;
  }

}
