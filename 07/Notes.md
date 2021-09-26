## Asp.Net MVC
- MVC stands for *model-view-controller*. MVC is a pattern for developing applications that are well architected, testable and easy to maintain. MVC-based applications contain:
    - **M** odels: Classes that represent the data of the application and that use validation logic to enforce business rules for that data.
    - **V** iews: Template files that your application uses to dynamically generate HTML responses.
    - **C** ontrollers: Classes that handle incoming browser requests, retrieve model data, and then specify view templates that return a response to the browser.
- [Web Forms vs MVC](https://www.c-sharpcorner.com/UploadFile/ff2f08/mvc-vs-Asp-Net-web-form/)

## Advantages of a Web Forms-Based Web Application
- The Web Forms-based framework offers the following advantages:
  1. It supports an event model that preserves state over HTTP, which benefits line-of-business Web application development. The Web Forms-based application provides dozens of events that are supported in hundreds of server controls.
  2. It uses a Page Controller pattern that adds functionality to individual pages. For more information, see Page Controller on the MSDN Web site.
  3. It uses view state or server-based forms, which can make managing state information easier.
  4. It works well for small teams of Web developers and designers who want to take advantage of the large number of components available for rapid application development.
  5. In general, it is less complex for application development, because the components (the Page class, controls, and so on) are tightly integrated and usually require less code than the MVC model.

## Advantages of an MVC-Based Web Application
- The ASP.NET MVC framework offers the following advantages:
    1. It makes it easier to manage complexity by dividing an application into the model, the view, and the controller.
    2. It does not use view state or server-based forms. This makes the MVC framework ideal for developers who want full control over the behavior of an application.
    3. It uses a Front Controller pattern that processes Web application requests through a single controller. This enables you to design an application that supports a rich routing infrastructure. For more information, see Front Controller on the MSDN Web site.
    4. It provides better support for test-driven development (TDD).
    5. It works well for Web applications that are supported by large teams of developers and Web designers who need a high degree of control over the application behavior.

## Views
- Consists of UI logic
- Extension .cshtml, processed by [Razor Engine](https://docs.microsoft.com/en-us/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c)
- Types of Views:
  - Based on data binding 
    - Static View : Plain HTML 
    - Weakly-Typed Views : Which uses View Bag and View Data
    - Strongly-Type Views : Which is binded to a model
    - Dynamic Typed Views : which are not binded to a model but the model is passed to view via controller and View automatically identify the model type as dynamic
  - Few other types of views
    - Layout View: Replacement of Master pages in the Asp.Net WebForms, to adhere to DRY principle of coding
    - [Partial Views](https://www.completecsharptutorial.com/asp-net-mvc5/adding-partial-views-pages-in-mvc-5-with-example.php): Like User Control in Asp.Net WebForms, to adhere to Reusability principle of coding

## Passing Data in MVC
- Action to View/ Controller to View -> ViewBag, ViewData
- Controller to Controller - TempData, it is normally used for 1 read only. If you want to preserve it for 2nd read then use the method TempData.Keep().
- Session can be for entire request session.
- Model
## Miscellaneous Topics
- [Model Binding](https://www.codeproject.com/Articles/605595/ASP-NET-MVC-Custom-Model-Binder)
  - Whenever an action method demnds for a parameter, model binder comes into the picture. Model Binder binds the value of an actions method's parameter
  - ModelBinder maps http requests from view data to the model. The MVC runtime uses Default ModelBinder to build the model parameters. This is done automatically by MVC Model Binder.
  - Model binder looks for these values:
    - Route (Url)
    - QueryString
    - FormsCollection
    - File
  
- [Filters](https://www.c-sharpcorner.com/article/filters-in-Asp-Net-mvc-5-0-part-twelve/)
  - Filters are used to inject extra logic at the different levels of MVC Framework request processing. Filters provide a way for cross-cutting concerns (logging, authorization, and caching).
  - There are five types of Filters in ASP.NET MVC 5:
    - Authentication:	These are Runs, before any other filters or the action method. It checks if user is identified and valid.
    - Authorization: These Runs first, before any other filters or the action method. Checks user's role if it is allowed to access a resource. 
    - Action:	These Runs before and after the action method.
    - Result:	Runs before and after the action result are executed.
    - Exception:	Runs only if another filter, the action method, or the action resultthrows an exception.
## [Entity Framework 6](https://docs.microsoft.com/en-us/ef/ef6/)
- [LINQ](https://www.tutorialsteacher.com/linq/linq-tutorials)
- ### References
  - [EF Basics](https://www.entityframeworktutorial.net/what-is-entityframework.aspx)
