# ninja-shop-api
The .net core web api that is accompanied by the ninja-store-ui. It's purpose is to store data and provide RESTful routes to access each resource.


Clone or Download the project from github
### Prerequisites
* .net core 2.0
* optional - vscode, rider, Visual Studio to view/edit
* optional - git scm to clone 

### Getting started / Restore the packages
Clone or Download the project from github


In command line in the root folder, retrieve the latest nuget packages by triggering:
> >   `dotnet restore` 

### Run the project
Drill into to the api project: `cd ninja-shop.api` and then trigger the following:
>>`dotnet run`

The api is now running on port 5000 (http://localhost:5000)

To run the unit tests, drill into the tests folder "cd ninja-shop.tests" and run `dotnet test`.
if successful, you should recieve:
>> Total tests: 26. Passed: 26. Failed: 0. Skipped: 0.

### Postman Script
For extra fun, download [Postman](https://www.getpostman.com) and use the supplied `NinjaStore.postman_collection` to test all of the routes with real data.
Find the above file in the root directory and click import. you can then drag/drop the file into Postman and all your routes are ready to test.

### Angular project
The accompanying project [ninja-shop-ui](https://github.com/elAndyG/ninja-shop-ui) is already set up to look at port 5000. So be sure the api is running prior to starting the angular application
