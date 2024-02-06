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



#Share Data With Components

#By using component parameters
In this hierarchy of parent and child components, you can share information between them by using component parameters. Define these parameters on child components, and then set their values in the parent. For example, if you have a child component that displays pizza photos, you could use a component parameter to pass the pizza ID. The child component looks up the pizza from the ID and obtains pictures and other data. If you want to display many different pizzas, you can use this child component multiple times on the same parent page, passing a different ID to each child.

You start by defining the component parameter in the child component. It's defined as a C# public property and decorated with the [Parameter] attribute:
![alt text](Readme-Images/image.png) or ![alt text](Readme-Images/image-1.png)

#By using cascading parameters
Component parameters work well when you want to pass a value to the immediate child of a component. Things become awkward when you have a deep hierarchy with children of children and so on. Component parameters aren't automatically passed to grandchild components from ancestor components or further down the hierarchy. To handle this problem elegantly, Blazor includes cascading parameters. When you set the value of a cascading parameter in a component, its value is automatically available to all descendant components to any depth.

In the parent component, using the <CascadingValue> tag specifies the information that will cascade to all descendants. This tag is implemented as a built-in Blazor component. Any component that's rendered within that tag is able to access the value.
![alt text](Readme-Images/image-2.png)

In the descendant components, you can access the cascading value by using component members and decorating them with the [CascadingParameter] attribute.
![alt text](Readme-Images/image-3.png)


#Share information by using AppState
Another approach to sharing information between different components is to use the AppState pattern. You create a class that defines the properties you want to store and register it as a scoped service. In any component where you want to set or use the AppState values, you inject the service and then you can access its properties. Unlike component parameters and cascading parameters, values in AppState are available to all components in the application, even components that aren't children of the component that stored the value.

As an example, consider this class that stores a value about sales: ![alt text](Readme-Images/image-4.png)
You would add the class as a scoped service in the Program.cs file: ![alt text](Readme-Images/image-5.png)

Now, in any component where you want to set or retrieve AppState values, you can inject the class and then access properties:
![alt text](Readme-Images/image-6.png)

