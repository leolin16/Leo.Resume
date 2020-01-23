# resume api & ui

## start up the project by using dotnet new template

> dotnet new webapi -n/-o ${some project name}

## installing packages

1. > dotnet add package Microsoft.EntityFrameworkCore --version 3.0.0
2. > dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.0.0
3. > dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.0.0

## project settings

### appsettings.json

no change

## project startup

    ```C#
    // ConfigureServices
    services.AddControllers();
    services.AddScoped<IResumeRepository, ResumeRepository>();
    servies.AddDbContext<ApplicationDbContext>(options => {
        options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ResumeDB;Trusted_Connection=True;");
    });
    ```
    ```C#
    // Configure
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    app.UseRouting();
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
    ```

## db setup

### creating Entities

### creating db context

### creating repository services

### configure startup in ConfigureService with repository as scoped and dbcontext

### ensure seed data logic is implemented within Program or seeddata extension method

## entity framework migration setup

1. establish container db

* for windows container in windows server 2016 or windows 10  
    `docker run -d -p 1433:1433 -e sa_password=P@ssw0rd -e ACCEPT_EULA=Y microsoft/mssql-server-windows-developer`  
    can be accessed via **localhost:1433**
* for linux container in mac/linux/windows 10  
    `docker run --name mssqldb -d -p 1433:1433 -e 'SA_PASSWORD=P@ssw0rd' -e 'ACCEPT_EULA=Y' mcr.microsoft.com/mssql/server:2019-GA-ubuntu-16.04` (" in powershell and ' for mac/linux, SA_PASSWORD should be in upper case)
 
2. setup db connection string correctly: `Server=localhost;Database=resumeDb;User=sa;Password=P@ssw0rd;Trusted_Connection=False;MultipleActiveResultSets=true;`
3. > dotnet tool install --global dotnet-ef
4. > dotnet ef migrations add initial
5. > dotnet ef database update