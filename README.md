# .NET.API.Case

This case revolves around building an ASP.NET Core Web API project that aims to:

CRUD APIs.

Search by Column , Value , Order By , Suffix.

Distance Calculating between two existing addresses in data base.


### Let's Start !
## Technologies

### Start By :

#### Downloading Microsoft Visual Studio 2022

Download Link : https://visualstudio.microsoft.com/fr/vs/

#### Downloading DB SQL Browser is recommended

Download Link : https://sqlitebrowser.org/dl/

#### Generate An API Key By Creating An Account (It's Free) 

Generation Link : https://positionstack.com

## Dependencies

#### To run our project we need the following dependencies to be installed.
#### Please make sure to install the adequate version which is indicated below !

[![AGPL License](https://img.shields.io/badge/Microsoft.VisualStudio.Web.CodeGeneration.Design-5.0.2%20Verison-blueviolet)](http://www.gnu.org/licenses/agpl-3.0)
[![AGPL License](https://img.shields.io/badge/Microsoft.EntityFrameworkCore.Sqlite.Core-5.0.9%20Verison-blueviolet)](http://www.gnu.org/licenses/agpl-3.0)
[![AGPL License](https://img.shields.io/badge/Microsoft.EntityFrameworkCore.SqlServer-5.0.9%20Verison-blueviolet)](http://www.gnu.org/licenses/agpl-3.0)
[![AGPL License](https://img.shields.io/badge/Microsoft.EntityFrameworkCore.Sqlite-5.0.9%20Verison-blueviolet)](http://www.gnu.org/licenses/agpl-3.0)
[![AGPL License](https://img.shields.io/badge/Microsoft.EntityFrameworkCore.Tools-5.0.9%20Verison-blueviolet)](http://www.gnu.org/licenses/agpl-3.0)
[![AGPL License](https://img.shields.io/badge/Microsoft.EntityFrameworkCore-5.0.9%20Verison-blueviolet)](http://www.gnu.org/licenses/agpl-3.0)
[![AGPL License](https://img.shields.io/badge/Swashbuckle.AspNetCore.Annotations-6.4.0%20Version-blue)](http://www.gnu.org/licenses/agpl-3.0)
[![AGPL License](https://img.shields.io/badge/Swashbuckle.AspNetCore-6.1.5%20Version-blue)](http://www.gnu.org/licenses/agpl-3.0)


## Possible Errors

#### To start the project make sure set it as a Startup Project

- The project files in the Github will contain my datbaase which might lead to an Error while running the project saying that database already exists ! 
Solution : Just delete the database and the Migrations folder and follow these insctructions :

    Click on Tools in the Taskbar

       Choose Nuget Packager Manager 
       
            Package Manager Console 

                     Run the following code :  Addi-Migration "Name"

                                               Update-Database 

And the Error should be gone ! 
    
## Design Patterns

- While building this project I opted for SOLID design
SOLID stands for five key design principles: 

- Single responsibility principle

- Open-closed principle

- Liskov substitution principle

- Interface segregation principle

- Dependency inversion principle 

## Objective of this method 

- the SOLID principles is to reduce dependencies so that engineers change one area of software without impacting others. Additionally, they’re intended to make designs easier to understand, maintain, and extend. Ultimately, using these design principles makes it easier for software engineers to avoid issues and to build adaptive, effective, and agile software.

## Parts I'm Proud Of
### Guid 
- To ensure that our application works in the best security conditions I chose to workd with Guit instead of normal Id also it has  it have very low probability of being duplicated as it is 128-bit integer(16 bytes) which allow to use GUID across all databse and computer without data collision.
### BAL
- Creating a Service folder whitch contains the methods and its implementations for the logic part will be helpful in making the code more legible, clear and understandable
### DTO
- I opt for the DTO mainly to prevent the user to change the Id in the Post Method by giving a specific structure that doesn't contain the Id, It will also help to further decouple presentation from the service layer and the domain model.

## Parts I'm NOT Proud Of
### Geolocation API
#### - Problem : 

Since this API works with lines of length and width from the position given in the database, It may get tricked by someone who doesn't insert the exact address

#### - Poosible Solution : 

 Work with google API location or an API that works with
 "IP address" but I didn't want to change the structure of the database given in the Case.
#### - Problem :
 Also I wanned to ensure that the user will understand exactly how to test the APIs but I had some troubles in the xml file.
#### - Solution :
I Wrote the instructions in the testing page near every request and I will provide a DEMO below for every method.
## Possible improvement

To esure that the this case works in its best manners we can implement Unit testing. 
## Demo
### Preview 
![Logic](https://user-images.githubusercontent.com/73751988/197685478-d99677eb-d140-4a50-a180-47e2c924ef7e.png)
### GetAllAddresses
![Login](https://user-images.githubusercontent.com/73751988/197683617-ae39cb8a-899c-455f-8674-5f2e71867519.png)

### GetAddressById
![Login](https://user-images.githubusercontent.com/73751988/197683859-bc278b88-c720-41f8-a596-8414ec41a589.png)

### PostAddress
![Login](https://user-images.githubusercontent.com/73751988/197683187-ebb12c89-78f8-4f68-9350-feec8ebac0f5.png)
)
### PutAddressById
![Login](https://user-images.githubusercontent.com/73751988/197684078-d47ec76c-b1a1-4615-bf46-f079710518d7.png)

### DeleteAddressById
![Login](https://user-images.githubusercontent.com/73751988/197684215-e34b45ff-1c84-4479-8f0d-f4d52bd5f888.png)

### Search By "Country" Order By "ZipCode" in an "ASC" Way
![Logic](https://user-images.githubusercontent.com/73751988/197684509-bfc59495-5d86-4768-b8dd-14e942283888.png)

### Result Search ASC
![Logic](https://user-images.githubusercontent.com/73751988/197684681-6e1ec9a3-d022-4f6c-b398-438f26aca733.png)

### Search By "Country" Order By "ZipCode" in an "DESC" Way
![Logic](https://user-images.githubusercontent.com/73751988/197684845-57a2cf9b-57c4-4c0c-8b86-57f950bae87c.png)

### Result Search DESC
![Logic](https://user-images.githubusercontent.com/73751988/197684957-8532d1d1-95d6-4dc3-8649-d4e8aa27a8ab.png)

### Distance Between Me And My Goal (The Netherlands - Tunisia)
![Logic](https://user-images.githubusercontent.com/73751988/197685174-433d59dd-4901-4566-b72f-4693b966fedf.png)

### Distance Verification
![Logic](https://user-images.githubusercontent.com/73751988/197685306-9feaf0d9-69b8-47d2-9162-1cb108657773.png)

## Authors

- [@AdelGuizani](https://github.com/GuizaniAdel)

