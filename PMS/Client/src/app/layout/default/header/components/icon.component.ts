import { Component, ChangeDetectionStrategy, ChangeDetectorRef } from '@angular/core';

@Component({
  selector: 'header-icon',
  template: `
    <div
      class="alain-default__nav-item"
      nz-dropdown
      [nzDropdownMenu]="iconMenu"
      nzTrigger="click"
      nzPlacement="bottomRight"
      (nzVisibleChange)="change()"
    >
      <i nz-icon nzType="appstore"></i>
    </div>
    <nz-dropdown-menu #iconMenu="nzDropdownMenu">
      <div nz-menu class="wd-xl animated jello">
        <nz-spin [nzSpinning]="loading" [nzTip]="'در حال بارگذاری'">
          <div nz-row [nzType]="'flex'" [nzJustify]="'center'" [nzAlign]="'middle'" class="app-icons">
            <div nz-col [nzSpan]="6">
              <img src="assets/3D-icons/cashbox.png" />
              <small>حسابداری</small>
            </div>
            <div nz-col [nzSpan]="6">
              <img src="assets/3D-icons/bank.png" />
              <small>خزانه</small>
            </div>
            <div nz-col [nzSpan]="6">
              <img src="assets/3D-icons/store.png" />
              <small>فروش</small>
            </div>
            <div nz-col [nzSpan]="6">
              <img src="assets/3D-icons/tresury.png" />
              <small>انبار</small>
            </div>
            <div nz-col [nzSpan]="6">
              <img src="assets/3D-icons/person-man.png" />
              <small>پرسنلی</small>
            </div>
            <div nz-col [nzSpan]="6">
              <img src="assets/3D-icons/orgChart.png" />
              <small>چارت سازمانی</small>
            </div>
            <div nz-col [nzSpan]="6">
              <img src="assets/3D-icons/bom.png" />
              <small>BOM</small>
            </div>
            <div nz-col [nzSpan]="6">
              <img src="assets/3D-icons/shopping.png" />
              <small>خرید</small>
            </div>
          </div>
        </nz-spin>
      </div>
    </nz-dropdown-menu>
  `,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class HeaderIconComponent {
  loading = true;

  constructor(private cdr: ChangeDetectorRef) {}

  change() {
    setTimeout(() => {
      this.loading = false;
      this.cdr.detectChanges();
    }, 500);
  }
}
