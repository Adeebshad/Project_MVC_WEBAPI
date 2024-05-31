# Project_MVC_WEBAPI

## FrontEnd
- PatientInformationsln Project is frontend project with using MVC Core 6.0
- A form is create for patient information entry

## Backend
- AspDotNetStartUp project is Backend using Web API 6.0
- Entity Framework Core(ORM) to insert, update, delete and display data
- MS SQL is used for database.
- Repository Pattern with unit of work is implemented here.

## How to run the Project
### Database Setup
* Approach 1 -> DB with BackUp file
  *  A Database BackUp file Test01.bak added with populated data.
* Approach 2 -> Db with migration command
  * There is a migration file to setup DB. To setup with migration command add a database "Test01".
  * Run update-database command in package-manager-console with target project "Basic.DataAccesEF".
  
### Application Run
* Frist of all run AspDotNetStartUp.
* After run the project swagger will be opened on browser.
* Then run PatientInformationsln project you see the form.
* Need to populate some data for Allergies and NCD for dropdown.

### In Swagger
CRUD operation can be done
