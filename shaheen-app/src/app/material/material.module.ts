import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import * as Material from '@angular/material';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    Material.MatToolbarModule,
    Material.MatGridListModule,
    Material.MatFormFieldModule,
    Material.MatInputModule,
    Material.MatButtonModule,
    Material.MatSidenavModule,
    Material.MatIconModule,
    Material.MatCardModule,
    Material.MatTabsModule,
    Material.MatTableModule,
    Material.MatDialogModule,
    Material.MatSelectModule
  ],
  exports:[
    Material.MatToolbarModule,
    Material.MatGridListModule,
    Material.MatFormFieldModule,
    Material.MatInputModule,
    Material.MatButtonModule,
    Material.MatSidenavModule,
    Material.MatIconModule,
    Material.MatCardModule,
    Material.MatTabsModule,
    Material.MatTableModule,
    Material.MatDialogModule,
    Material.MatSelectModule
  ]
})
export class MaterialModule { }
