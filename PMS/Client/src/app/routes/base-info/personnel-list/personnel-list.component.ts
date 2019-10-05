import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-personnel-list',
  templateUrl: './personnel-list.component.html',
  styleUrls: ['./personnel-list.component.less'],
})
export class PersonnelListComponent implements OnInit {
  editCache: { [key: string]: any } = {};
  listOfData: any[] = [];
  term: string;
  constructor() {}

  ngOnInit(): void {
    for (let i = 0; i < 10; i++) {
      this.listOfData.push({
        id: `${i}`,
        serial: `789${i}`,
        name: `محمد حسین`,
        familyName: 'محمدیان',
        idNumber: `001896523${i}`,
        nationalCode: `001${i}96523${i}`,
        birthDay: '7/11/1375',
        gender: 'پسر',
      });
    }
    this.updateEditCache();
  }

  startEdit(id: string): void {
    this.editCache[id].edit = true;
  }

  cancelEdit(id: string): void {
    const index = this.listOfData.findIndex(item => item.id === id);
    this.editCache[id] = {
      data: { ...this.listOfData[index] },
      edit: false,
    };
  }

  saveEdit(id: string): void {
    const index = this.listOfData.findIndex(item => item.id === id);
    Object.assign(this.listOfData[index], this.editCache[id].data);
    this.editCache[id].edit = false;
  }

  updateEditCache(): void {
    this.listOfData.forEach(item => {
      this.editCache[item.id] = {
        edit: false,
        data: { ...item },
      };
    });
  }
}
