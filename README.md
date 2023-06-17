# PierresTreats

## Description

PierresTreats is a web application that allows users to view and manage sweet and savory treats. The application has user authentication where only logged in users can create, update, and delete functionality. All users can read functionality. The application also has a many-to-many relationship between Treats and Flavors.

## Setup/Installation Requirements

* Clone this repository from GitHub: https://github.com/JBShaffer91/PierresTreats.git
* Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
* Install [.Net Core](https://dotnet.microsoft.com/download/dotnet/7.2.202)
* To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
* Run dotnet restore in terminal to get all dependencies.
* Create your own version of the database by importing the pierrestreats.sql file from the repository to MySQL Workbench.
* Create an appsettings.json file in the PierresTreats directory and add the following code to the file:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=PierresTreats;uid=root;pwd=YourPassword;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```
* Replace 'YourPassword' with your own MySQL password.
* To start the program, run dotnet run.

## Technologies Used
* C#
* .NET 7.2.202
* ASP.NET Core MVC
* Entity Framework Core
* MySQL 8.0.33
* Identity
* Razor Pages

## Known Issues
* No known issues

## Contact
If you have any questions, comments, or concerns, please contact me at `justinbshaffer91@gmail.com`

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
Copyright Justin Shaffer 2023

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.