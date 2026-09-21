import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CustomerService } from '../../services/customer.service';

@Component({
  selector: 'app-customer-search',
  imports: [
    FormsModule
  ],
  templateUrl: './customer-search.html',
  styleUrl: './customer-search.css'
})
export class CustomerSearchComponent {

  customerId: string = "";

  customer: any = null;
  accounts: any[] = [];
  transactions: any[] = [];
  ivrCalls: any[] = [];

  loading: boolean = false;
  errorMessage: string = "";

  constructor(
    private customerService: CustomerService
  ) {}

  searchCustomer() {

    if (!this.customerId.trim()) {
      this.errorMessage = "Please enter Customer ID";
      return;
    }

    this.loading = true;
    this.errorMessage = "";

    this.customerService
      .getCustomerProfile(this.customerId)
      .subscribe({

        next: (data) => {

          this.customer = data.customer;
          this.accounts = data.accounts;
          this.transactions = data.recentTransactions;
          this.ivrCalls = data.ivrCalls;

          this.loading = false;

          console.log("Customer Profile:", data);
        },

        error: (error) => {

          console.error(error);

          this.customer = null;
          this.accounts = [];
          this.transactions = [];
          this.ivrCalls = [];

          if (error.status === 404) {
            this.errorMessage = "Customer not found";
          } else {
            this.errorMessage = "Something went wrong";
          }

          this.loading = false;
        }
      });
  }
}