<p align="center">
  <img src="https://raw.githubusercontent.com/FastEndpoints/FastEndpoints/main/logo.svg" height="150px" alt="FastEndpoints Logo">
</p>

## PoC1_FastEndpoint

## Project Purpose
This is a Proof of Concept (PoC) project demonstrating how to build a REST API using the FastEndpoints library in .NET. The application showcases a simple customer management system with endpoints for retrieving, viewing, and creating customer records.

## Technologies
- **.NET 9.0**: Modern C# framework for building web applications
- **FastEndpoints**: Lightweight REST API framework for .NET that streamlines endpoint creation
- **Minimal API**: Uses the minimal API approach in ASP.NET Core
- **Dependency Injection**: Demonstrates service registration and usage

## How to Run
1. **Prerequisites**:
   - .NET 9.0 SDK installed on your machine
   - Visual Studio 2022/2025, VS Code, or JetBrains Rider

2. **Clone the repository**:
   ```
   git clone [repository-url]
   cd PoC1_FastEndpoints
   ```

3. **Restore packages and build the project**:
   ```
   dotnet restore
   dotnet build
   ```

4. **Run the application**:
   ```
   dotnet run
   ```

5. **Access the API**:
   - The API will be available at `https://localhost:[port]/api`
   - Available endpoints:
     - `GET /api/Customers`: Retrieve all customers
     - `GET /api/Customers/{id}`: Retrieve a specific customer by ID
     - `POST /api/Customers`: Create a new customer
