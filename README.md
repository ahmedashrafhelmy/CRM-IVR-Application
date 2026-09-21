# CRM IVR Application

A full-stack CRM IVR demo application built using Angular, ASP.NET Core Web API, C#, and SQL Server.

The application demonstrates a layered architecture where the Angular frontend communicates with an ASP.NET Core backend to retrieve and display customer information, account details, recent transactions, and IVR call records.

---

# 🛠️ Technologies Used

## Frontend
- Angular
- TypeScript
- HTML
- CSS
- Angular Services
- Angular Routing
- HttpClient

## Backend
- ASP.NET Core Web API
- C#
- Controllers
- Services Layer
- Dependency Injection
- Entity Framework Core

## Database
- SQL Server
- AppDbContext
- Entity Framework Core

---

# 🏗️ Application Architecture

The application follows a layered architecture:

User
|
v
Angular Frontend
|
v
Angular Services (HttpClient)
|
v
F5 Load Balancer (Enterprise Layer) (Not implemented in this demo)
|
v
Middleware Layer (Not implemented in this demo)
|
v
ASP.NET Core Web API
|
v
Controllers
|
v
Backend Services
|
v
DTOs / Models
|
v
AppDbContext
|
v
Entity Framework Core
|
v
SQL Server Database (Tables were created manually, not generated using Entity Framework)


---

# 📂 Project Structure
CRM-IVR-Application

│
├── CRM_IVR_API
│
│ ├── Controllers
│ │ ├── CustomersController
│ │ ├── AccountsController
│ │ ├── TransactionsController
│ │ └── IvrCallsController
│ │
│ ├── Services
│ │ ├── CustomerService
│ │ ├── AccountService
│ │ ├── TransactionService
│ │ └── IvrCallService
│ │
│ ├── Models
│ │ ├── Customer
│ │ ├── Account
│ │ ├── Transaction
│ │ └── IvrCall
│ │
│ ├── DTOs
│ │ └── CustomerProfileDto
│ │
│ ├── Data
│ │ └── AppDbContext
│ │
│ └── Program.cs
│
├── crm-ivr-demo
│
│ ├── Components
│ │ ├── HomeComponent
│ │ ├── CustomerSearchComponent
│ │ ├── IvrDashboardComponent
│ │ ├── DashboardCardComponent
│ │ └── RecentTransactionsComponent
│ │
│ ├── Services
│ │ └── CustomerService
│ │
│ └── Routing
│
└── Database


---

# 🎨 Angular Frontend

## Components

### HomeComponent
- Application landing page.
- Displays the initial application view.

### CustomerSearchComponent
- Allows users to search for customer information.
- Sends requests through Angular services.
- Displays returned customer data.

### IvrDashboardComponent
- Displays IVR-related information.
- Shows IVR call details and statistics.

### Reusable Components

- DashboardCardComponent
- RecentTransactionsComponent
- Sidebar Component

These components are reusable UI elements used across the application.

---

# 🔌 Angular Service

## CustomerService

Responsible for communication between Angular components and the backend.

Responsibilities:

- Sending requests using HttpClient.
- Receiving backend responses.
- Providing data to Angular components.

Flow:


Component
|
v
CustomerService
|
v
ASP.NET Core Backend


---

# ⚙️ ASP.NET Core Backend

## Controllers

Controllers receive requests from the frontend and handle application operations.

Implemented Controllers:

- CustomersController
- AccountsController
- TransactionsController
- IvrCallsController

---

## Services Layer

Services contain the application logic and handle communication with the database layer.

Implemented Services:

- CustomerService
- AccountService
- TransactionService
- IvrCallService

---

## Models

Models represent the application's data structure.

Implemented Models:

- Customer
- Account
- Transaction
- IvrCall

---

# 📦 DTO

## CustomerProfileDto

Used to organize the data returned to the frontend.

It combines:

- Customer information
- Accounts
- Recent Transactions
- IVR Calls

Benefits:

- Controls returned data.
- Sends only required information.
- Provides a structured response.

---

# 🗄️ Database Structure

Database:


CRM_IVR_DB


## Tables

### Customers

Stores customer information:

- Id
- CustomerId
- FullName
- PhoneNumber
- Email
- CreatedAt


### Accounts

Stores customer accounts:

- Id
- AccountNumber
- CustomerId
- AccountType
- Balance
- Currency
- Status


### Transactions

Stores account transactions:

- Id
- TransactionId
- AccountId
- TransactionType
- Amount
- TransactionDate
- Status


### IVR_Calls

Stores IVR call records:

- Id
- CustomerId
- PhoneNumber
- CallStart
- CallEnd
- CallStatus
- SelectedOption

---

# 🔗 Database Relationships


Customer
|
+---- Accounts
|
+---- Transactions

Customer
|
+---- IVR_Calls


Relationships:

- One customer can have multiple accounts.
- One account can have multiple transactions.
- One customer can have multiple IVR calls.

---

# 🔄 Application Data Flow

Example: Customer Search


User
|
v
CustomerSearchComponent
|
v
CustomerService
|
v
ASP.NET Core Controller
|
v
Backend Service
|
v
AppDbContext
|
v
SQL Server Database


Response:


Database
|
v
Service
|
v
DTO
|
v
Controller
|
v
Angular Component
|
v
User


---

# 🔐 Dependency Injection

ASP.NET Core Dependency Injection is used to provide required objects between application layers.

Example:


CustomersController

    |
    v

CustomerService

    |
    v

AppDbContext


Benefits:

- Better code organization.
- Easier maintenance.
- Loose dependency between classes.

---

# 🚀 Future Improvements

Possible improvements:

- Add authentication and authorization.
- Connect with real customer systems.
- Add advanced dashboards.
- Deploy the application to cloud environment.

---

# 👨‍💻 Author

Ahmed Ashraf Helmy


Angular | ASP.NET Core | SQL Server

