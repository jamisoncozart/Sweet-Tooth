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
|User clicks signup, redirect user to signup form|*clicks signup*|*show user signup form*|
|User clicks submit on signup form, redirect to login page|*clicks submit*|*show user the sign in page*|
|User clicks submit after filling out login info, redirect user to homepage and show username in top right corner|*clicks submit on login form*|*log user in, redirect to homepage*|
|User clicks signout, sign user out and redirect to homepage|*clicks signout*|*sign user out, redirect to homepage*|
|User visits homepage, show all treats and flavors|*visits homepage*|*Show treats and flavors*|
|User clicks on a treat, show treat details with name, and all flavors of treat|*clicks treat*|*Show all details of treat*|
|User clicks on a flavor, show flavor details with name and all treats of flavor|*clicks flavor*|*Show all details of treat*|
|User clicks on a flavor in treat details page, show flavor details|*clicks flavor*|*show flavor details*|
|User clicks on a treat in flavor details page, show treat details|*clicks treat*|*show treat details*|
|User clicks add new treat, take user to new treat form|*clicks add new treat*|*show new treat form*|
|User clicks submit on a filled out new treat form, create new treat and send user back to homepage|*clicks submit*|*user redirected to homepage with new treat*|
|User clicks delete on a treat, delete treat and send user back to homepage|*clicks delete*|*send user back to homepage*|
|User clicks edit, show edit form for treat|*clicks edit*|*redirect user to treat edit page*|
|User clicks submit on the treat edit form, edit details of the treat and redirect user to homepage|*clicks submit*|*redirect user to homepage with updated treat details*|

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