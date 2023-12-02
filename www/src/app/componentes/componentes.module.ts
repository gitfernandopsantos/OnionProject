import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// Module Ngprime
import { MenubarModule } from 'primeng/menubar';

// Componente
import { MenubarComponent } from './menubar/menubar.component';



@NgModule({
  declarations: [
    MenubarComponent,
  ],
  imports: [
    CommonModule,
    MenubarModule
  ],
  exports: [
    MenubarComponent,
  ]
})
export class ComponentesModule { }
