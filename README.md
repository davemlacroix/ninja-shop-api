# ninja-shop-api
The .net core web api that is accompanied by the ninja-store-ui.

To get started, you need .net core 2.0 installed on your machine.
Clone or Download the project from github

### Restore the packages
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
