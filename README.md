# Library Management System (LMS)

## Description
This Library Management System (LMS) is a collaborative university project designed to manage the operations of a university library. The system facilitates the management of book inventories, student registrations, and book borrowing processes, ensuring efficient and streamlined library operations. Built with C# and Windows Forms, this application integrates with MySQL for robust backend database management.

## Features
- **User Registration and Authentication**: Secure login and registration system for students and administrators.
- **Book Management**: Administrators can add, remove, and update book details such as title, author, ISBN, and availability.
- **Borrowing System**: Students can browse available books and register them as borrowed under their account, with automated return date calculations.
- **Search and Filter**: Users can search for books based on various criteria like title, author, or genre, and results can be filtered accordingly.
- **Admin Panel**: A dedicated interface for administrators to manage users, books, and view borrowing statistics.
- **User Profile Management**: Students can update their profiles, including password changes and photo updates.
- **Notification System**: Automated notifications for due dates, book availability, and other alerts.

## Technologies Used
- **C# / .NET Framework**: For creating the application logic and user interface using Windows Forms.
- **MySQL**: Used for database management to store user and book data.
- **Visual Studio 2022**: Integrated development environment (IDE) for building and debugging the application.

## Setup and Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/LMS-Project.git
   ```
2. **Database Setup**:
   - Install MySQL and set up the `LMS` database using the provided SQL scripts in the `DatabaseScripts` folder.
3. **Visual Studio Setup**:
   - Open the solution file in Visual Studio.
   - Restore NuGet packages and rebuild the solution.
   - Ensure local settings are configured to connect to your MySQL instance.

## Usage
Run the application from Visual Studio by setting the LMS project as the startup project and clicking the 'Run' button. Log in as an administrator or student to access respective functionalities.

## Contributing
Contributions are welcome! For major changes, please open an issue first to discuss what you would like to change. Please ensure to update tests as appropriate.

## License
Distributed under the MIT License. See `LICENSE` for more information.

---
