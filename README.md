# Sweet Tooth
#### March 27 2020

ASP.NET core MVC application using Entity Framework Core and Identity for user authenticationa and authorization using MySQL. Application handles treats and flavors in a many-to-many relationship. Practice with ASP.NET core MVC, Entity Framework Core, Identity, and MySQL.

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

#### Install .NET Core

##### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

##### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

##### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

#### Install MySQL and MySQL Workbench

##### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

_Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

##### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

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