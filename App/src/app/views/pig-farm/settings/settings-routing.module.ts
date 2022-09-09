import { ShoeGlueComponent } from './shoe-glue/shoe-glue.component';
import { GlueChemicalComponent } from './glue-chemical/glue-chemical.component';
import { ShoeComponent } from './shoe/shoe.component';
import { GlueComponent } from './glue/glue.component';
import { ChemicalComponent } from './chemical/chemical.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from 'src/app/_core/_guards/auth.guard';
import { SettingsComponent } from './settings.component';

const routes: Routes = [
  { 
    path: '', 
    children: [
      {
        path: 'Chemicals',
        component: ChemicalComponent,
        data: {
          title: 'Chemicals',
          module: 'setting',
          breadcrumb: 'Chemicals',
          functionCode: 'Chemicals'
        },
        canActivate: [AuthGuard]
      },

      {
        path: 'Glues',
        component: GlueComponent,
        data: {
          title: 'Glues',
          module: 'setting',
          breadcrumb: 'Glues',
          functionCode: 'Glues'
        },
        canActivate: [AuthGuard]
      },

      {
        path: 'Shoe',
        component: ShoeComponent,
        data: {
          title: 'Shoe',
          module: 'setting',
          breadcrumb: 'Shoe',
          functionCode: 'Shoe'
        },
        canActivate: [AuthGuard]
      },
      {
        path: 'Glue-Chemical',
        component: GlueChemicalComponent,
        data: {
          title: 'Glue Chemical',
          module: 'setting',
          breadcrumb: 'Glue Chemical',
          functionCode: 'Glue-Chemical'
        },
        canActivate: [AuthGuard]
      },

      {
        path: 'Shoe-Glue',
        component: ShoeGlueComponent,
        data: {
          title: 'Shoe Glue',
          module: 'setting',
          breadcrumb: 'Shoe Glue',
          functionCode: 'Shoe-Glue'
        },
        canActivate: [AuthGuard]
      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SettingsRoutingModule { }
