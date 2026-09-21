import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home';
import { CustomerSearchComponent } from './components/customer-search/customer-search';
import { IvrDashboardComponent } from './components/ivr-dashboard/ivr-dashboard';


export const routes: Routes = [

{
 path:'',
 component:HomeComponent
},

{
 path:'customer-search',
 component:CustomerSearchComponent
},

{
 path:'ivr-dashboard',
 component:IvrDashboardComponent
}

];

