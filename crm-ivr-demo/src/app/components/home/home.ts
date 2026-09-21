import { Component } from '@angular/core';
import { DashboardCardComponent } from '../dashboard-card/dashboard-card';
import { RecentTransactionsComponent } from '../recent-transactions/recent-transactions';
@Component({
  imports: [ DashboardCardComponent,
 RecentTransactionsComponent],
  selector: 'app-home',
  styleUrl: './home.css',
  templateUrl: './home.html',
})
export class HomeComponent {}
