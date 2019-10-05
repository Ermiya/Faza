import { Component, OnInit } from '@angular/core';
import { NzMessageService } from 'ng-zorro-antd/message';

@Component({
  selector: 'app-monthly',
  templateUrl: './monthly.component.html',
  styleUrls: ['./monthly.component.less'],
})
export class MonthlyComponent implements OnInit {
  editCache: { [key: string]: any } = {};
  editCacheDetails: { [key: string]: any } = {};
  listOfData: any[] = [];
  listOfDetails: any[] = [];
  isVisibleTop = false;
  isVisibleMiddle = false;
  isVisible = false;

  constructor(private msg: NzMessageService) {}
  handleChange({ file, fileList }: { [key: string]: any }): void {
    const status = file.status;
    if (status !== 'uploading') {
      console.log(file, fileList);
    }
    if (status === 'done') {
      this.msg.success(`${file.name} file uploaded successfully.`);
    } else if (status === 'error') {
      this.msg.error(`${file.name} file upload failed.`);
    }
  }
  showUploadModal(): void {
    this.isVisible = true;
  }

  handleOk(): void {
    console.log('Button ok clicked!');
    this.isVisible = false;
  }

  handleCancel(): void {
    console.log('Button cancel clicked!');
    this.isVisible = false;
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
  startEditDetails(id: string): void {
    this.editCacheDetails[id].edit = true;
  }

  cancelEditDetails(id: string): void {
    const index = this.listOfDetails.findIndex(item => item.id === id);
    this.editCacheDetails[id] = {
      data: { ...this.listOfDetails[index] },
      edit: false,
    };
  }

  saveEditDetails(id: string): void {
    const index = this.listOfDetails.findIndex(item => item.id === id);
    Object.assign(this.listOfDetails[index], this.editCacheDetails[id].data);
    this.editCacheDetails[id].edit = false;
  }

  updateEditCacheDetails(): void {
    this.listOfDetails.forEach(item => {
      this.editCacheDetails[item.id] = {
        edit: false,
        data: { ...item },
      };
    });
  }

  ngOnInit(): void {
    for (let i = 0; i < 100; i++) {
      this.listOfData.push({
        id: `${i}`,
        fullname: `سید امیر مهدوی`,
        type: `پروژه ای`,
        status: `فعال`,
        year: `139${i}`,
        month: 'بهمن',
        yearedit: `139${i + 2}`,
        monthedit: 'شهریور',
        personnel: '12387-12836',
      });
      this.listOfDetails.push({
        id: `${i}`,
        title: `سید امیر مهدوی`,
        minute: `پروژه ای`,
        hour: `فعال`,
      });
    }
    this.updateEditCache();
    this.updateEditCacheDetails();
  }
  addRow(): void {
    this.listOfData = [
      {
        id: `1`,
        fullname: `test`,
        type: `پروژه ای`,
        status: `فعال`,
        year: `1391`,
        month: 'بهمن',
        yearedit: `1392`,
        monthedit: 'شهریور',
        personnel: '12387-12836',
      },
      ...this.listOfData,
    ];
  }

  showModalTop(): void {
    this.isVisibleTop = true;
  }

  showModalMiddle(): void {
    this.isVisibleMiddle = true;
  }

  handleOkTop(): void {
    this.isVisibleTop = false;
  }

  handleCancelTop(): void {
    this.isVisibleTop = false;
  }

  handleOkMiddle(): void {
    this.isVisibleMiddle = false;
  }

  handleCancelMiddle(): void {
    this.isVisibleMiddle = false;
  }
}
