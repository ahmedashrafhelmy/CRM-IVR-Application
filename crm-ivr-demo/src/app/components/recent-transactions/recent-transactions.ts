import { Component } from '@angular/core';


@Component({
  selector: 'app-recent-transactions',
  imports: [],
  templateUrl: './recent-transactions.html',
  styleUrl: './recent-transactions.css'
})


export class RecentTransactionsComponent {


transactions = [

{
 transactionId:"TX10001",
 customer:"Ahmed Mohamed",
 status:"Completed",
 date:"17-09-2026"
},

{
 transactionId:"TX10002",
 customer:"Ali Hassan",
 status:"Failed",
 date:"17-09-2026"
},

{
 transactionId:"TX10003",
 customer:"Sara Ali",
 status:"Completed",
 date:"16-09-2026"
}

];


}