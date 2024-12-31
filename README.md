Student Details Form Web Application
This is a simple web application that allows users to input, store, and view student details. The application uses ASP.NET Core with an in-memory database to manage the data.

Features
Student Details Form: A form where users can enter student information such as Name, Age, and Course.
Student List: A page that displays a list of all students that have been entered through the form.
Technologies Used
ASP.NET Core MVC
Entity Framework Core with an in-memory database
Razor Views
HTML, CSS (basic styling)
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/yourusername/WebApplication13.git
cd WebApplication13
Install the required packages:

Ensure that you have the .NET SDK installed. Then, run:

bash
Copy code
dotnet restore
Run the application:

bash
Copy code
dotnet run
Access the application:

Visit https://localhost:7049/Student/Details to view and submit the student details form.
Visit https://localhost:7049/Student/List to view the list of students.
Project Structure
Models/Student.cs: Contains the Student model with properties like Id, Name, Age, and Course.
Views/Student/Details.cshtml: The form where users can enter student details.
Views/Student/List.cshtml: Displays a list of students.
Controllers/StudentController.cs: Contains actions to handle displaying the form and saving student data.
Data/StudentContext.cs: The database context for the in-memory database.
Program.cs: Configures the application, including setting up services and routes.
How to Use
Start the application by running the project.
Open the Student Details Form page to enter a new student.
Submit the form to save the student data.
Visit the Student List page to view all the students entered through the form.
License
This project is licensed under the MIT License - see the LICENSE file for details.

Additional Notes:
Replace "yourusername" in the clone URL with your GitHub username.
Ensure the version of .NET Core used matches the version for your project.
