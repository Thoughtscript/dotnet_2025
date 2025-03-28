# dotnet_2025

[![](https://img.shields.io/badge/ASP.NET-9.0.3-purple.svg)](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-9.0)
[![](https://img.shields.io/badge/MSSQL-2022-blue.svg)](https://hub.docker.com/r/microsoft/mssql-server)
[![](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://learn.microsoft.com/en-us/dotnet/?WT.mc_id=dotnet-35129-website) 
[![](https://img.shields.io/badge/Docker-blue.svg)](https://www.docker.com/) 

## Set Up and Use

**Docker Compose**:
```bash
docker compose up
```

**Visual Studio Code**:
1. Install the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
2. Install [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-9.0.202-windows-x64-installer)

> https://code.visualstudio.com/docs/csharp/get-started

## Topics

### .NET CLI

```bash
dotnet new mvc --language "C#"
dotnet run
```

### C#

[![](https://img.shields.io/badge/C%23-13-purple.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/?WT.mc_id=dotnet-35129-website) [![](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-9.0) 

1. Autogenerate most boiler-plate using [dotnet new console --language "C#"](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new).

### ASP.NET

[![](https://img.shields.io/badge/ASP.NET-9.0.3-purple.svg)](mcr.microsoft.com/dotnet/aspnet:9.0.3)

*Refresh for `ASP.NET 9.0.3`* 

> Much easier now to launch a basic app!

1. Autogenerate most boiler-plate using [dotnet new mvc --language "C#"](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new).
2. Port binding can be set in [appsettings.json](./asp_entity/src/appsettings.json) `Urls`.
    * `"Urls": "https://0.0.0.0:5177"`
    * Should bind to `localhost`.
    * Can view at: https://localhost:5177
    * SSL can be set there too.
3. Controllers [automatically append](./asp_entity/src/Controllers/ExampleController.cs) their Handler names as subpaths (quite handy).
4. Controllers using [IActionResult](https://medium.com/@dilanlakshitha194/understanding-iactionresult-in-net-core-simplifying-http-response-handling-1e406e22dbcc) and the relevant helper method (`Ok()`, `NotFound()`, etc.) will automatically [serialize data](https://learn.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-9.0) into JSON.
5. https://medium.com/@nwonahr/working-with-json-data-in-asp-net-core-web-api-fbc4f0ee39c4

Views and Endpoints:
* Simple String/Text Response -> http://localhost:5177/Example/SimpleString
* Automatic JSON Serialization -> http://localhost:5177/Example/JsonResponse
* Default Home -> http://localhost:5177/
* Prebuilt Context Path Example -> http://localhost:5177/Home/Privacy

### Entity Framework

[![](https://img.shields.io/badge/Entity-Framework-purple.svg)](https://learn.microsoft.com/en-us/ef/) 


### MSSQL

[![](https://img.shields.io/badge/MSSQL-2022-blue.svg)](https://hub.docker.com/r/microsoft/mssql-server)



## Resources and Links

1. https://code.visualstudio.com/docs/csharp/get-started
2. https://hub.docker.com/r/microsoft/dotnet
3. https://hub.docker.com/r/microsoft/mssql-server
4. https://medium.com/@dilanlakshitha194/understanding-iactionresult-in-net-core-simplifying-http-response-handling-1e406e22dbcc
5. https://learn.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-9.0
6. https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new
7. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons
8. https://learn.microsoft.com/en-us/dotnet/standard/exceptions/exception-class-and-properties
9. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/
10. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
11. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
12. https://dev.to/waelhabbal/the-right-way-to-check-for-null-in-c-6gf
13. https://github.com/ggagnaux/CSharp-Publisher-Subscriber-Demo/blob/master/PublisherSubscriberDemo/Publisher.cs

Some prior examples of mine:

1. https://www.thoughtscript.io/blog/000000000005
2. https://github.com/Azure-Samples/Azure-Time-Series-Insights/pull/12
3. https://github.com/Azure-Samples/digital-twins-samples-csharp/pull/67
4. https://github.com/Thoughtscript/more_sql_notes/blob/main/3%20-%20mssql/queries.sql
5. https://github.com/Thoughtscript/jupyter_notebook