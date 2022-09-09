import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SettingsRoutingModule } from './settings-routing.module';
import { SettingsComponent } from './settings.component';
import { ChemicalComponent } from './chemical/chemical.component';
import { SharedModule } from 'src/app/_core/commons/shared.module';
import { Common2Module } from 'src/app/_core/commons/common2.module';
import { FormsModule } from '@angular/forms';
import { CoreDirectivesModule } from 'src/app/_core/_directive/core.directives.module';
import { GlueComponent } from './glue/glue.component';
import { ShoeComponent } from './shoe/shoe.component';
import { GlueChemicalComponent } from './glue-chemical/glue-chemical.component';
import { ShoeGlueComponent } from './shoe-glue/shoe-glue.component';
import { GlueChildComponent } from './glue-chemical/glue-child/glue-child.component';
import { ChemicalChildComponent } from './glue-chemical/chemical-child/chemical-child.component';
import { ShoeChildComponent } from './shoe-glue/shoe-child/shoe-child.component';
import { ShoeGlueChildComponent } from './shoe-glue/shoe-glue-child/shoe-glue-child.component';


@NgModule({
  declarations: [
    SettingsComponent,
    ChemicalComponent,
    GlueComponent,
    ShoeComponent,
    GlueChemicalComponent,
    ShoeGlueComponent,
    GlueChildComponent,
    ChemicalChildComponent,
    ShoeChildComponent,
    ShoeGlueChildComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    CoreDirectivesModule,
    SettingsRoutingModule,
    SharedModule.forRoot(),
    Common2Module.forRoot()
  ]
})
export class SettingsModule { }
