import { NameRecipeWorkerComponent } from './name-recipe-worker/name-recipe-worker.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TransactionComponent } from './transaction.component';
import { AuthGuard } from 'src/app/_core/_guards/auth.guard';

const routes: Routes = [
  { 
    path: '', 
    component: TransactionComponent 
  },
  {
    path: 'Name-Recipe-Worker',
    component: NameRecipeWorkerComponent,
    data: {
      title: 'Name Recipe Worker',
      module: 'transaction',
      breadcrumb: 'Name Recipe Worker',
      functionCode: 'Name-Recipe-Worker'
    },
    canActivate: [AuthGuard]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TransactionRoutingModule { }
