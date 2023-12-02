import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';


@Component({
  selector: 'app-menubar',
  templateUrl: '../menubar/menubar.component.html',
  styleUrls: ['../menubar/menubar.component.css']
})
export class MenubarComponent {
  items: MenuItem[] | undefined;

  ngOnInit() {
    this.items = [
      {
        label: 'Inicio',
        icon: 'pi pi-fw pi-home',
        routerLink: '/home',
      },
      {
        label: 'Cadastro',
        icon: 'fas fa-clipboard-list',
        items: [
          {
            label: 'Clientes',
            icon: 'fa-solid fa-address-card',
            routerLink: '/cliente',
          },
          {
            label: 'Produtos',
            icon: 'fa-duotone fa-flask',
            routerLink: '/**',
          },
          {
            label: 'Compras',
            icon: 'fas fa-shopping-cart',
            routerLink: '/**',
          },
          {
            label: 'Vendas',
            icon: 'fa-solid fa-sack-dollar',
            routerLink: '/**',
          },
        ]
      },
      {
        label: 'Consultas',
        icon: 'pi pi-fw pi-user',
        items: [
          {
            label: 'Controle de Estoque',
            icon: 'pi pi-fw pi-user-plus',
            routerLink: '/**',
          }
        ]
      },
    ];
  }
}
