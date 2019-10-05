import { PersonnelListComponent } from './personnel-list/personnel-list.component';
import { HighlightPipe } from './../../shared/pipes/highlight.pipe';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BaseInfoRoutingModule } from './base-info-routing.module';
import { DescriptionRulingsComponent } from './description-rulings/description-rulings.component';
import { PersonnelContractComponent } from './personnel-contract/personnel-contract.component';
import { PersonnelDetailsComponent } from './personnel-details/personnel-details.component';
import { JobsComponent } from './jobs/jobs.component';
import { NzTableModule, NzButtonModule, NzInputModule, NzPopconfirmModule, NzFormModule, NzUploadModule, NzIconModule } from 'ng-zorro-antd';
import { CreationAuditModule } from '@shared/comp/creation-audit/creation-audit.module';
import { NzCheckboxModule } from 'ng-zorro-antd/checkbox';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NzGridModule } from 'ng-zorro-antd/grid';
import { NzCollapseModule } from 'ng-zorro-antd/collapse';

@NgModule({
  declarations: [
    DescriptionRulingsComponent,
    PersonnelContractComponent,
    PersonnelDetailsComponent,
    JobsComponent,
    PersonnelListComponent,
    HighlightPipe,
  ],
  imports: [
    CommonModule,
    BaseInfoRoutingModule,
    FormsModule,
    Ng2SearchPipeModule,
    CreationAuditModule,
    ReactiveFormsModule,
    NzFormModule,
    NzUploadModule,
    NzIconModule,
    NzGridModule,
    NzTableModule,
    NzButtonModule,
    NzCheckboxModule,
    NzInputModule,
    NzPopconfirmModule,
    NzCheckboxModule,
    NzCollapseModule,
  ],
})
export class BaseInfoModule {}
