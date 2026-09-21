import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  private apiUrl = 'https://localhost:7063/api/Customers';

  constructor(private http: HttpClient) {}

  // بيانات العميل فقط
  getCustomer(customerId: string): Observable<any> {
    return this.http.get(`${this.apiUrl}/${customerId}`);
  }

  // بيانات العميل كاملة
  getCustomerProfile(customerId: string): Observable<any> {
    return this.http.get(`${this.apiUrl}/${customerId}/profile`);
  }
}