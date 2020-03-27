# Sweet Tooth
#### March 27 2020

ASP.NET core MVC application using Entity Framework Core and Identity for user authenticationa and authorization using MySQL. Application handles treats and flavors in a many-to-many relationship. Practice with ASP.NET core MVC, Entity Framework Core, Identity, and MySQL.

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/jamisoncozart/Sweet-Tooth
    ```
2. Change directories into the project working directory:
    ```
    cd Sweet-Tooth/SweetTooth
    ```
3. Restore all dependencies:
    ```
    dotnet restore
    ```
4. Run the following commands in the working directory of the project
    ```
    dotnet ef database update
    ```
5. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
6. Open the locally hosted server in your preferred web browser:
    ```
    start http://localhost:5000
    ```

## BDD Specifications

|Behavior|Input|Output|
|:-:|:-:|:-:|
||||


## Technologies Used

* C#
* ASP.NET core MVC 2.2
* Entity Framework Core
* Identity Authentication/Authorization
* MySQL + MySQL Workbench version 8.0.15
* RESTful Routing
* CRUD Functionality
* Git

## Authors

* **Jamison Cozart** - (https://github.com/jamisoncozart)

## License

Licensed under the MIT license.

&copy; 2020 - Jamison Cozart