import { Component } from '@angular/core';
import { Customer } from 'src/models/customer';
import { CustomerService } from 'src/service/customerservice';

@Component({
  selector: 'app-customers',
  templateUrl: '../customers/customers.component.html',
  styleUrls: ['../customers/customers.component.css']
})
export class CustomersComponent {
  customers!: Customer[];
  customer!: Customer;

  constructor(private customerService: CustomerService) {

  }

  ngOnInit() {
    this.customerService.getProducts().then((data) => (this.customers = data.slice(0, 5)));
  }

  getSeverity(customer: Customer) {
    switch (customer.inventoryStatus) {
      case 'INSTOCK':
        return 'success';

      case 'LOWSTOCK':
        return 'warning';

      case 'OUTOFSTOCK':
        return 'danger';

      default:
        return "retorna nada :)";
    }
  };
}
