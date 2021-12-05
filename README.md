# _Animal Shelter API_

#### By _**Carlos Urquiza**_

#### _API for animal shelter._

## Technologies Used

* _C#_
* _RESTful Routing_
* _.NET 5.0_
* _Entity Framework_
* _MySQL Workbench_
* _Swagger_
* _Git_

## Description

_This API allows users to view animal data. The application has CRUD functionality and uses Swagger documentation._

## Setup/Installation Requirements

#### **Before taking the following installation steps, ensure you have [C#, .NET](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net), [dotnet script](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-dotnet-script) and [MySql](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-and-configuring-mysql)    installed on your computer.** 

* _Clone this repository._
* _Open your terminal._
* _Navigate to the directory (such as your Desktop folder) where you want the cloned repository to be housed._
* _Run `git clone https://github.com/webquiza/AnimalShelter.Solution.git`._
* _Press Enter._

#### **Connect database**

* _Connect the database to the project by creating a `appsettings.json` file inside `AnimalShelter.Solution/Factory`._
* _Within your new `appsettings.json` file, add the following piece of code. Note that you will need to enter the password you created for your specific MySQL configuration ( remove the [ ] ):_

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

* _Navigate to `AnimalShelter` directory._
* _Run `dotnet restore` to retrieve and install the packages we listed in .csproj._
* _Run `dotnet build` to build the project._
* _Update the database by running `dotnet ef database update` (ensure you have MySQL Workbench open)._ 
* _Run `dotnet run` to start up your local host (http://localhost:5000)._

## Swagger and endpoints

* _To view Swagger and relevant endpoints, navigate to the following URL: `http://localhost:5000/swagger/index.html`._
* _In the above URL, you will see the Swagger interface with all endpoints available from Aninal Shelter API._
* _You can execute GET, POST, PUT and DELETE endpoints through the Swagger interface._

## Known Bugs

* _No known bugs._

## License

MIT License

Copyright (c) 2021 Carlos Urquiza

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

## Contact Information

_Feel free to contact me at webquiza@gmail.com with any questions regarding this webpage._