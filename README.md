<br>
<p align="center">
  <u><big>|| <b>Animal Shelter API</b> ||</big></u>
</p>
<p align="center">
    <p align="center">
    </p>
    <p align="center"> 
        <a href="https://github.com/janetkarpenske">
            <strong>Janet Karpenske</strong>
        </a> | 
    </p>
    <!-- Project Shields -->   
</p>

<p align="center">
  <medium>Created on 10/30/2020, Updated on 10/30/2020.</medium>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/janetkarpenske/AnimalShelter.Solution"><big>Project Docs</big></a> ·
    <a href="https://github.com/janetkarpenske/AnimalShelter.Solution/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/janetkarpenske/AnimalShelter.Solution/issues"><big>Request Feature</big></a>
</p>

------------------------------

------------------------------

## 🌐 About the Project

### 📖 Description
A web API for an animal shelter. It utilizies the RESTful principles, pagination, and Swagger. The user is able to see the in-use version of the API when using Postman. Currently v1.0.

### 🦠 Known Bugs

* Authoriziation not set up on client facing side of application, therefore it is not secure.

### 🛠 Built With
* VS Code
* C#
* ASP.NET Core MVC
* MySQL Workbench
* Entity Framework Core 2.2.0
* Swagger - Swashbuckle 5.6.2
* Postman

## 🏁 Getting Started

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [Animal Shelter repository here](https://github.com/janetkarpenske/C-AnimalShelterAPI).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/janetkarpenske/C-AnimalShelterAPI`
  5) Run the command `cd AnimalShelter.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the AnimalShelter.Solution/AnimalShelter directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to AnimalShelter.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell.
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to AnimalShelter.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell.
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the Cretaceous Park API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`


### Note on Pagination
The Animal Shelter API returns a default of 5 results per page at a time.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

### Animals
Access information about animals in the animal shelter.

#### HTTP Request
```
GET /api/animals
POST /api/animals
GET /api/animals/{id}
PUT /api/animals/{id}
DELETE /api/animals/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| ingredient | string | none | false | Return any recipe with a specific ingredient. |

#### Example Query
```
https://localhost:5000/api/animals/?name=Benji&species=dog
```

#### Sample JSON Response
```
{
    "Id": 1,
    "Name": "Benji",
    "Species": "Dog",
    "Breed": "Golden Retriever",
    "Age": 5,
    "Gender": "Male"
}
```
### ✉️ Contact and Support

If you have any feedback or concerns, please contact Janet Karpenske via Github.

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (c) 2020 Janet Karpenske. All Rights Reserved.
```
MIT License

Copyright (c) 2020 Jeff Dinsmore, Janet Karpenske, Johnny Duverseau, & Chloe Hellberg.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
<center><a href="#">Return to Top</a></center>