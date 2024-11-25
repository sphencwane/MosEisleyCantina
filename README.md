# Mos Eisley Cantina API Solution

# Overview 
This solution is designed to build a REST API for Chalmun's Cantina, a popular restaurant located on Tatooine. The API allows consumers to create, view, list, update, and delete dishes and drinks, as well as search, rate, and view the menu items. It uses .NET 8 with Entity Framework Core, SQL Server as the database, and is organized into three main projects:

- Web API Project: This contains the controllers and API endpoints.
- Service Project: This handles the business logic and interacts with the database.
- Data Project: This contains the data models and context for interacting with the database.

# Technologies Used
- .NET 8
- Entity Framework Core
- SQL Server

# Solution Structure
The solution is divided into three primary projects:

1. Web API Project (MosEisleyCantina.WebAPI):
- This project exposes the REST API endpoints for external consumers.
- Controllers: MenuController and CategoryController.

2. Service Project (MosEisleyCantina.Service)
- Contains the business logic and interacts with the database via the data layer.
- Services handle operations like create, update, and delete for menu items, categories, and ratings.

3. Data Project (MosEisleyCantina.Data)
- Contains the data models and the DbContext used for interacting with the SQL Server database.

# Database Schema
The database consists of the following tables:

1. MenuItems Table: 
Stores information about dishes and drinks in the cantina menu.
- Id: INT (Primary Key)
- Name: NVARCHAR
- Description: NVARCHAR
- Price: DECIMAL
- ImageUrl: NVARCHAR
- CategoryId: INT (Foreign Key to Category)

2. Category Table: 
Stores the category information for the menu items (e.g., "Dish" or "Drink").
- Id: INT (Primary Key)
- Name: NVARCHAR

3. Rating Table: 
Stores ratings for menu items given by customers.
- Id: INT (Primary Key)
- MenuItemId: INT (Foreign Key to MenuItem)
- Rating: INT (1 to 5)
- Comment: NVARCHAR

# How to Run the Solution

1. Clone the Repository:
- Clone the repository to your local machine

2. Update the Database:
- You can change the connection string to what DB Server you have currently installed on your machine. If you have SQL Server Express, that should just work. Run the update database command on the “MosEisleyCantina.Data” project so that the solution can create the DB. In package manager console, "update-database".

3. Run the Web API Project:
- Set the Web API project as the startup project and run it. The browser will automatically open Swagger UI, displaying all the API endpoints.


