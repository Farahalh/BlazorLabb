# Blazor Lab - User Management Web App

## Project Overview

This project is a Blazor-based web application built with .NET for a programming assignment in C#. The purpose of the assignment is to develop a basic web application with Blazor that includes structured navigation, user data handling, and integration with an external API.

The application consists of three pages accessible via a navigation menu:

1. **Home Page**: Contains custom content as an entry point to the app.
2. **New User Page**: Allows users to enter personal information through text inputs. After filling out the form and clicking "Save," the input data is displayed as a confirmation message (though data is not actually stored).
3. **Users Page**: Displays a list of user data in a table format. The page simulates asynchronous loading using a delay and shows a placeholder until data is available. Initially, the page displays the first five users, sorted by name. Users can view all available users by clicking "Show All."

## Requirements

### Basic Features (Grade G)

1. **Version Control**: 
   - Managed with Git and contains at least two branches: `main` and `development`.
   - Includes at least three commits.

2. **Three Navigable Pages**:
   - A menu allows navigation to the Home, New User, and Users pages.

3. **Data Handling on Users Page**:
   - A simulated data layer provides user data, with at least ten users generated. 
   - The data model includes `id`, `name`, `email`, `address` (street, city, zipcode), and `company` (name and catchphrase).
   - Users are initially displayed sorted by first name using LINQ, with an option to view all users.
   - The data is dynamically generated in a non-sorted order to demonstrate sorting functionality.

4. **Code Quality**:
   - Clear naming conventions and readable code structure.

### Advanced Features (Grade VG)

1. **Data Layer Enhancements**:
   - The data layer is abstracted with an interface and implemented separately.
   - The app integrates with an external API ([JSONPlaceholder API](https://jsonplaceholder.typicode.com/users)) for retrieving user data, offering an alternative data source.

2. **Enhanced User Sorting and Search**:
   - Users can be sorted in ascending or descending order by `id` and first name.
   - A search bar allows text-based searches, filtering users dynamically to show only matching entries.

3. **Intuitive GUI**:
   - The interface is designed to be user-friendly with clean, well-organized code following .NET naming conventions.

## Technology Stack

- **Framework**: Blazor (.NET)
- **Languages**: C#
- **Data Source**: JSONPlaceholder API for advanced functionality
- **UI/UX**: Responsive design with intuitive controls for searching, sorting, and data display

## Setup and Submission

The project should be submitted as a `.zip` file by the due date. The folder structure and code readability will be evaluated as part of the submission criteria.
