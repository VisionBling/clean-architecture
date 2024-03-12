# Clean Architecture Web API - ASP.NET Core

This project is an example of implementing Clean Architecture in a Web API using ASP.NET Core. It is a starting point for building ASP.NET Core Web API applications following Clean Architecture principles. It aims to provide a well-defined project structure that separates concerns into different layers, making the application easier to manage, develop, and test.

# Give it a Star !!!⭐
If you find this project useful helpful as a starting template in implementing Clean Architecture in ASP.NET Core, please give it a star, on GitHub to help others developers discover it! Thanks  

## Table of Contents#

-[Introduction to Clean Architecture](#introduction-to-clean-Architecture)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Architecture Overview](#architecture-overview)
- [Usage](#usage)
- [Running the tests](#running-the-tests)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Introduction to Clean Architecture
Clean Architecture is a software design philosophy that separates the elements of a project into ringed levels, promoting the independence of system components. This approach ensures that the system is easy to maintain and evolve, particularly in complex applications with extensive business rules.

At the heart of Clean Architecture is the principle of dependency inversion. Dependencies flow from the outer layers (mechanisms such as UI, frameworks, and tools) towards the inner layers (policies like Entities and Use Cases), ensuring that the core business logic remains independent of external frameworks and technology. This separation of concerns makes the system more flexible and adaptable to changes in technology or business requirements.
## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them:

Before you begin, ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) (Version .Net 8)
- An IDE of your choice (e.g., [Visual Studio](https://visualstudio.microsoft.com/), [VS Code](https://code.visualstudio.com/))

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/ulomaramma/clean-architecture.git

2. Navigate to the project directory:
   ```bash
   cd clean-architecture

3. Install dependencies:
   ```bash
   dotnet restore
4. Update the database connection string in appsettings.json within the Presentation Layer project.
5. Apply the migrations to your database:
   ```bash
   dotnet ef database update
6. Run the Application
   ```bash
   dotnet run



### Architecture Overview
Clean Architecture is centered around the Domain and Application layers, promoting loose coupling and separation of concerns. This project is structured as follows:

**Domain Layer**: Contains all entities, enums, exceptions, interfaces, types, and logic specific to the domain problem this project is solving.
**Application Layer**: Houses the application logic and defines the interfaces that are implemented by the outside layers. Depends on the domain layer but has no dependencies on any other layer or project.
**Infrastructure Layer**: Implements external concerns such as database access, file system access, network calls, etc.
**Presentation Layer**: In this case, the ASP.NET Core Web API, responsible for delivering HTTP responses to the client, parsing requests, and handing them off to the application layer for processing.
