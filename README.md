# PBNET
PBNET is a tool that understands your PowerBuilder application and converts it to a ASP.NET Core web application that uses frameworks such as Angular, CSS, and Typescript.

This tool has the ability to process the source code to generate C#, Angular, HTML, and CSS files.

Instead of manually rewriting an entire application, we help you by automating this process using PBNET. This reduces costs, risks and time, while keeping the existing business logic intact.

For more details you can go to our [website](https://www.mobilize.net/powerbuilder) or check our documentation at [Mobilize.Net Documentation](https://docs.mobilize.net/)

## PowerBuilder to .Net Core Tailwind App
This repo contains the source code and binaries for the PowerBuilder app.

This app just shows a Powerbuilder Window with a different components to interact for example: Dropdown, checkbox, etc.

The sample was migrated with our [tools](https://mobilize.net/powerbuilder) to a ASP.NET Core web app with an Angular FrontEnd.

## How to Build the app
If you want to build this app, you have to follow the next steps:

###  Requirements
- [Node.js](https://nodejs.org/download/release/v16.20.2/node-v16.20.2-x64.msi) 
- [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.413-windows-x64-installer)
- [SQLite ODBC Driver](http://www.ch-werner.de/sqliteodbc/sqliteodbc.exe) and [SQLite ODBC Driver x64](http://www.ch-werner.de/sqliteodbc/sqliteodbc_w64.exe) 

### Database setup
In the root folder of the app you will find a file called `tailwind.db`. This file is the database of the app. You have to create a folder inside your local `disk C` called `A1` and inside this another folder called `_work` and copy the `tailwind.db` file inside this folder.

The route should be like this: `C:\A1\_work\tailwind.db`

### Steps for build **BackEnd** 
Install [Microsoft Visual Studio](https://visualstudio.microsoft.com/downloads/) 2019 or above if you don't have it, open `MigratedSolution` file in app folder and **build** the solution. 

### Steps for build **FrontEnd**
Open a terminal in the app folder and use the command line with the next commands:

```
cd MigratedSolution\sampleSite\sampleSite-angular
npm set @mobilize:registry=https://packages.mobilize.net/npm/mobilizenet-npm
npm install
npm run build
```

### Run the app
Finally set `productcatalogSite` as startup project and run.

## Code Structure
When you migrate your app from Powerbuilder to ASP.NET core you will have:
- WebSite application based on the original app `pbt`
- A class library for each Powerbuilder `pbl`
- An angular application which will generate an angular module with the UI elements from each `pbl`

## Legacy vs migrated app 

#### Legacy form
![Legacy](https://i.ibb.co/7VgNqJT/TW2.png?raw=true "Title")

#### Migrated form
![Migrated](https://i.ibb.co/D8Vg8m7/TW3.png?raw=true "Title")