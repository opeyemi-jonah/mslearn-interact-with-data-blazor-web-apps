#Setup

1. Install SDK with latest version.
2. Create a registered data service (The creation of a registered service starts by writing a class that defines its properties).
3. Next, you would define the service: look at PizzaService.cs

#Services
4. Register the service by adding a line to the Add Services to the container section in the Program.cs file: Look at Program.cs line 7.(An error occured on my after running the project with the seed data a second time, so I switched to using scoped instead of singleton. I would investigate further.)
5. Inject the service in a razor page using @inject service_name. Then call the service inside the @code block to obtain data.

#Database Setup
6. Add package to support database access.
7. Add a database context. This class creates a database context we can use to register a database service. The context also allows us to have a controller that accesses the database.
8. Add a controller. This class creates a controller that allows us to query the database for pizza specials and returns them as JSON at the (http://localhost:5000/specials) URL.

Follow link to learn more: https://learn.microsoft.com/en-us/training/modules/interact-with-data-blazor-web-apps/5-exercise-access-data-from-blazor-components