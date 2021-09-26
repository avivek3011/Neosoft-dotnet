## [REST API](https://restfulapi.net/)
## [Asp.Net Web API](https://www.tutorialsteacher.com/webapi)
## [EF Core](https://www.entityframeworktutorial.net/code-first/inheritance-strategy-in-code-first.aspx)
- Most conventions and steps for EFCore Code first and EF6 are same
### Packages
Install the listed packages in your DL project:
- ```dotnet add package Microsoft.EntityFrameworkCore.Tools``` or ```Install-Package Microsoft.EntityFrameworkCore.Tools```
- ```dotnet add package Microsoft.EntityFrameworkCore.SQLServer``` or ```Install-Package Microsoft.EntityFrameworkCore.SQLServer```

### DB First Steps
1. Have the following:
    - Data Layer
    - The necessary packages installed in DL project
2. Run the long scaffold code in the DL project:
    - With Fluent API - `dotnet ef dbcontext scaffold "Server=tcp:<server name>.database.windows.net,1433;Initial Catalog=<db name>;User ID=<userid>;Password=<password>" Microsoft.EntityFrameworkCore.SqlServer --force -o Entities`
      or 
    - Connection String with Data Annotations: `dotnet ef dbcontext scaffold "Server=tcp:<server name>.database.windows.net,1433;Initial Catalog=<db name>;User ID=<user id>;Password=<Password>" Microsoft.EntityFrameworkCore.SqlServer --force --data-annotations -o Entities`
3. Edit the DBContext:
    - Change the name if its weird
    - Edit the onconfiguring method to safely refer to the connection string using appsettings.json
4. Any major change to table structure:
    - If you add a new table, delete a table: go to step 2
    - If you've altered columns in an existing table: edit the necessary entity to reflect those changes

Other things you'll need with DBFirst:
- A Mapper to map your DB entities to BL entities

### [Code First Steps](https://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx)
1. Have the following:
    - Data Layer
    - The necessary packages installed in DL project
    - Appsettings.json in both your startup project and root folder of the solution
2. Implement a DbContext
    - Override the `OnConfiguring` method to point to the connection string stored in your appsettings.json
    - Override the `OnModelCreating` method to manually map some relationships EF Core complains about
3. Run the migration code in the DL project
    - `dotnet ef migrations add NameOfMigration -c DbContext --startup-project <relative path to project file>` or
    - ``` Add-Migration "Name of the Migration"``` (In PMC point it to Data project)
4. Update your DB in the DL project
    - `dotnet ef database update --startup-project <relative path to project file>` or
    - ```Update-Database``` (In PMC point it to Data project)
5. Any changes to your models/entities go to step 3


## References:
- [Architecture Principles](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles)
- [Comman web app architectures](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)
- [Asp.net core MVC with EFCore](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio)