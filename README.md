# StudentInfo

This is a simple web application developed using Angular and .NET technologies to manage student information. The project allows users to perform CRUD (Create, Read, Update, Delete) operations on student records and utilizes LINQ queries to interact with a SQL database.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Project Structure](#project-structure)
- [Usage](#usage)


## Features

- **CRUD Operations:** Perform Create, Read, Update, and Delete operations on student records.
- **LINQ Queries:** Utilize LINQ queries to fetch and manipulate data from the SQL database.
- **Responsive Design:** The application is designed to be responsive, ensuring a seamless experience across various devices.

## Technologies Used

- **Angular:** A front-end web application framework.
- **.NET:** A back-end framework for building web applications.
- **SQL Server:** A relational database management system for storing student information.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [Node.js](https://nodejs.org/): Required for running the Angular application.
- [.NET SDK](https://dotnet.microsoft.com/download): Required for building and running the .NET application.
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads): Required for storing and retrieving student information.

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/student-information-project.git
   cd student-information-project
   ```

2. Set up the Angular application:

   ```bash
   cd ClientApp
   npm install
   ```

3. Set up the .NET application:

   ```bash
   cd ..
   dotnet restore
   ```

## Project Structure

The project is organized into the following directories:

- **ClientApp:** Contains the Angular front-end application.
- **Controllers:** Contains .NET controllers for handling HTTP requests.
- **Models:** Defines the data models used in the application.
- **Services:** Contains .NET services for interacting with the database.
- **Migrations:** Includes database migration files for setting up the initial database schema.

## Usage

1. Ensure that both the Angular and .NET applications are set up (follow the installation steps).
2. Configure the database connection string in the `appsettings.json` file.
3. Apply database migrations:

   ```bash
   dotnet ef database update
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

5. Access the application in your web browser at `http://localhost:5000`.

