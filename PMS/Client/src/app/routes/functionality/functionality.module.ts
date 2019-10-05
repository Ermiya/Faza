import { CreationAuditModule } from '@shared/comp/creation-audit/creation-audit.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FunctionalityRoutingModule } from './functionality-routing.module';
import { MonthlyComponent } from './monthly/monthly.component';
import { NzTableModule } from 'ng-zorro-antd/table';
import { FormsModule } from '@angular/forms';
import { NzInputModule, NzButtonModule, NzIconModule } from 'ng-zorro-antd';
import { NzModalModule } from 'ng-zorro-antd/modal';
import { NzUploadModule } from 'ng-zorro-antd/upload';

@NgModule({
  declarations: [MonthlyComponent],
  imports: [
    CommonModule,
    FunctionalityRoutingModule,
    FormsModule,
    CreationAuditModule,
    NzTableModule,
    NzInputModule,
    NzModalModule,
    NzButtonModule,
    NzUploadModule,
    NzIconModule,
  ],
})
export class FunctionalityModule {}
