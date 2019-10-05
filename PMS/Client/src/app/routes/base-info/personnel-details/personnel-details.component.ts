import { NzMessageService, UploadFile } from 'ng-zorro-antd';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Observable, Observer } from 'rxjs';

@Component({
  selector: 'app-personnel-details',
  templateUrl: './personnel-details.component.html',
  styleUrls: ['./personnel-details.component.less'],
})
export class PersonnelDetailsComponent implements OnInit {
  inputValue: string;
  loading = false;
  avatarUrl: string;
  Martyr = false;
  MartyrFamily = false;
  editCache: { [key: string]: any } = {};
  listOfData: any[] = [];
  panels = [
    {
      active: true,
      disabled: false,
      name: 'مشخصات فردی',
      customStyle: {
        background: '#f7f7f7',
        'border-radius': '4px',
        'margin-bottom': '24px',
        border: '0px',
      },
    },
    {
      active: false,
      disabled: true,
      name: 'وضعیت تحصیلی',
      customStyle: {
        background: '#f7f7f7',
        'border-radius': '4px',
        'margin-bottom': '24px',
        border: '0px',
      },
    },
    {
      active: false,
      disabled: false,
      name: 'سابقه کار',
      customStyle: {
        background: '#f7f7f7',
        'border-radius': '4px',
        'margin-bottom': '24px',
        border: '0px',
      },
    },
    {
      active: false,
      disabled: false,
      name: 'تحت تکفل',
      customStyle: {
        background: '#f7f7f7',
        'border-radius': '4px',
        'margin-bottom': '24px',
        border: '0px',
      },
    },
  ];
  constructor(fb: FormBuilder, private msg: NzMessageService) {
    this.form = fb.group({
      serialVal: [null, [Validators.required, Validators.minLength(4)]],
      nameVal: [null, Validators.required],
      familyNameVal: [null, Validators.required],
      birthDayVal: [null, Validators.required],
      someVal: [null, Validators.required],
      telephoneVal: [null, [Validators.required, Validators.pattern(/^1\d{10}$/)]],
      mobileVal: [null, [Validators.required, Validators.pattern(/^1\d{10}$/)]],
    });
  }
  get serialVal() {
    return this.form.controls.serialVal;
  }
  get nameVal() {
    return this.form.controls.nameVal;
  }
  get birthDayVal() {
    return this.form.controls.birthDayVal;
  }
  get someVal() {
    return this.form.controls.someVal;
  }
  get telephoneVal() {
    return this.form.controls.telephoneVal;
  }
  get mobileVal() {
    return this.form.controls.mobileVal;
  }
  get familyNameVal() {
    return this.form.controls.familyNameVal;
  }
  form: FormGroup;
  error = '';
  type = 0;

  ngOnInit() {
    for (let i = 0; i < 2; i++) {
      this.listOfData.push({
        id: `${i}`,
        fullname: `${i}`,
        type: `${i}`,
        status: `${i}`,
        year: `139${i}`,
        month: `${i}`,
        yearedit: `139${i + 2}`,
        monthedit: `${i}`,
        personnel: 'test',
      });
    }
    this.updateEditCache();
  }

  submit() {
    this.error = '';
    if (this.type === 0) {
      this.serialVal.markAsDirty();
      this.serialVal.updateValueAndValidity();
      this.nameVal.markAsDirty();
      this.nameVal.updateValueAndValidity();
      this.familyNameVal.markAsDirty();
      this.familyNameVal.updateValueAndValidity();
      this.birthDayVal.markAsDirty();
      this.birthDayVal.updateValueAndValidity();
      this.telephoneVal.markAsDirty();
      this.telephoneVal.updateValueAndValidity();
      this.mobileVal.markAsDirty();
      this.mobileVal.updateValueAndValidity();
      this.someVal.markAsDirty();
      this.someVal.updateValueAndValidity();

      if (
        this.serialVal.invalid ||
        this.nameVal.invalid ||
        this.familyNameVal.invalid ||
        this.birthDayVal.invalid ||
        this.mobileVal.invalid ||
        this.someVal.invalid ||
        this.telephoneVal.invalid
      ) {
        return;
      }
    }
  }

  beforeUpload = (file: File) => {
    return new Observable((observer: Observer<boolean>) => {
      const isJPG = file.type === 'image/jpeg';
      if (!isJPG) {
        this.msg.error('You can only upload JPG file!');
        observer.complete();
        return;
      }
      const isLt2M = file.size / 1024 / 1024 < 2;
      if (!isLt2M) {
        this.msg.error('Image must smaller than 2MB!');
        observer.complete();
        return;
      }
      // check height
      this.checkImageDimension(file).then(dimensionRes => {
        if (!dimensionRes) {
          this.msg.error('Image only 300x300 above');
          observer.complete();
          return;
        }

        observer.next(isJPG && isLt2M && dimensionRes);
        observer.complete();
      });
    });
  };

  private getBase64(img: File, callback: (img: string) => void): void {
    const reader = new FileReader();
    reader.addEventListener('load', () => callback(reader.result!.toString()));
    reader.readAsDataURL(img);
  }

  private checkImageDimension(file: File): Promise<boolean> {
    return new Promise(resolve => {
      const img = new Image(); // create image
      img.src = window.URL.createObjectURL(file);
      img.onload = () => {
        const width = img.naturalWidth;
        const height = img.naturalHeight;
        window.URL.revokeObjectURL(img.src!);
        resolve(width === height && width >= 300);
      };
    });
  }

  handleChange(info: { file: UploadFile }): void {
    switch (info.file.status) {
      case 'uploading':
        this.loading = true;
        break;
      case 'done':
        // Get this url from response in real world.
        this.getBase64(info.file!.originFileObj!, (img: string) => {
          this.loading = false;
          this.avatarUrl = img;
        });
        break;
      case 'error':
        this.msg.error('Network error');
        this.loading = false;
        break;
    }
  }
  checkButtonMartyr(): void {
    this.Martyr = !this.Martyr;
  }
  checkButtonMartyrFamily(): void {
    this.MartyrFamily = !this.MartyrFamily;
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
  addRow(): void {
    this.listOfData = [
      {
        id: `1`,
        fullname: `test`,
        type: `test`,
        status: `test`,
        year: `test`,
        month: 'test',
        yearedit: `test`,
        monthedit: 'test',
        personnel: 'test',
      },
      ...this.listOfData,
    ];
  }
}
