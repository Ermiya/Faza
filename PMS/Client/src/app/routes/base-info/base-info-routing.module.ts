import { DescriptionRulingsComponent } from './description-rulings/description-rulings.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PersonnelContractComponent } from './personnel-contract/personnel-contract.component';
import { PersonnelDetailsComponent } from './personnel-details/personnel-details.component';
import { JobsComponent } from './jobs/jobs.component';
import { PersonnelListComponent } from './personnel-list/personnel-list.component';

const routes: Routes = [
  { path: 'description-rulling', component: DescriptionRulingsComponent },
  { path: 'personnel-contract', component: PersonnelContractComponent },
  { path: 'personnel-details', component: PersonnelDetailsComponent },
  { path: 'personnel-list', component: PersonnelListComponent },
  { path: 'jobs', component: JobsComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class BaseInfoRoutingModule {}
