# dotnet_2025

[![](https://img.shields.io/badge/ASP.NET-9.0.3-purple.svg)](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-9.0)
[![](https://img.shields.io/badge/MSSQL-2022-blue.svg)](https://hub.docker.com/r/microsoft/mssql-server)
[![](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) 
[![](https://img.shields.io/badge/Docker-blue.svg)](https://www.docker.com/) 

## Set Up and Use

**Docker Compose**:
```bash
docker compose up
```

> **Warning**: the default configuration is configured for local non-containerized use.

1. Tweak the SSL settings in [appsettings.json](./asp_entity/src/appsettings.json) if required. (`https` -> `http`) 
   * Adding `RUN dotnet dev-certs https` [here](./asp_entity/dockerfile) will automatically generate and associate a Dev SSL cert usable from *within* the Container.
2. Comment out **Line 14** in [](./csharp/src/Program.cs) - **.NET** Console input within a Docker Container will error out. 
   * It can be run by Exec'ing into the Docker Container thereafter (and uncommenting out that line).

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

[![](https://img.shields.io/badge/C%23-13-purple.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/?WT.mc_id=dotnet-35129-website) [![](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) 

1. Autogenerate most boiler-plate using [dotnet new console --language "C#"](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new).
2. [C# 13+](csharp/src/language/) examples.

### ASP.NET

[![](https://img.shields.io/badge/ASP.NET-9.0.3-purple.svg)](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-9.0)

*Refresh for `ASP.NET 9.0.3`* 

> Much easier now to launch a basic app!

1. Autogenerate most boiler-plate using [dotnet new mvc --language "C#"](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new).
2. Port binding can be set in [appsettings.json](./asp_entity/src/appsettings.json) `Urls`.
    * `"Urls": "https://0.0.0.0:5177"`
    * Should bind to `localhost`.
    * Can view at: https://localhost:5177
    * SSL can be set there too using: `dotnet dev-certs https` within the same Docker Image.
3. Controllers [automatically append](./asp_entity/src/Controllers/ExampleController.cs) their Handler names as subpaths (quite handy).
4. Controllers using [IActionResult](https://medium.com/@dilanlakshitha194/understanding-iactionresult-in-net-core-simplifying-http-response-handling-1e406e22dbcc) and the relevant helper method (`Ok()`, `NotFound()`, etc.) will automatically [serialize data](https://learn.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-9.0) into JSON.
5. https://medium.com/@nwonahr/working-with-json-data-in-asp-net-core-web-api-fbc4f0ee39c4

Views and Endpoints:
* Simple String/Text Response -> https://localhost:5177/Example/SimpleString
* Automatic JSON Serialization -> https://localhost:5177/Example/JsonResponse
* Default Home -> https://localhost:5177/
* Prebuilt Context Path Example -> https://localhost:5177/Home/Privacy
* Asynchronous SQL Response -> https://localhost:5177/Example/SqlExamples

### Entity Framework

[![](https://img.shields.io/badge/Entity-Framework-purple.svg)](https://learn.microsoft.com/en-us/ef/) 

1. Changes to [Connection String](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/breaking-changes?tabs=v7) require `TrustServerCertificate=True` or `Encrypt=False` for basic Docker dev testing.

### MSSQL

> Exercise in PowerShell and MSSQL admin.

[![](https://img.shields.io/badge/MSSQL-2022-blue.svg)](https://hub.docker.com/r/microsoft/mssql-server)

1. To execute commands within the Container appears to require using **Windows PowerShell**: `docker exec -u root -it <MY_CONTAINER_ID> "bash"`
      * If you Exec in through Docker Desktop the default user is set to `mssql` not `root` and you won't have permission to execute: `/opt/mssql-tools18/bin/sqlcmd`
      * If you attempt to Exec in through Bash (in a new Terminal aside from Docker Desktop), the following error will appear: `the input device is not a TTY.  If you are using mintty, try prefixing the command with 'winpty'` from using Bash on a Windows machine (apparently).
      * Run the following command from a new Windows PowerShell Terminal instead: `/opt/mssql-tools18/bin/sqlcmd -U sa -P FD83wr9DF_*9pke89 -S localhost -No` as described [here](https://learn.microsoft.com/en-us/sql/linux/sql-server-linux-docker-container-deployment?view=sql-server-ver16&pivots=cs1-bash#tools-inside-the-container). (The `-No` flag bypasses local HTTPS auth.)
1. `docker-entrypoint-initdb.d` isn't supported within the Docker Container but I've kept the convention for familiarity's sake.
      * Execute: `/opt/mssql-tools18/bin/sqlcmd -U sa -P FD83wr9DF_*9pke89 -S localhost -No -i docker-entrypoint-initdb.d/init_sql.sql` to run the initial scripts.
      * Since initialization doesn't happen immediately, I've added `sleep 120` to the [Bash script](./asp_entity/run.sh).

> https://learn.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver16

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
14. https://learn.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver16
15. https://learn.microsoft.com/en-us/ef/core/
16. https://github.com/grpm98/pisofinderapi/blob/f114d5860c60267a05ccfd8ed41c162ce8e51224/Data/PisoFinderContext.cs
17. https://github.com/adamajammary/simple-web-app-mvc-dotnet/blob/master/SimpleWebAppMVC/Controllers/TasksApiController.cs
18. https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/breaking-changes?tabs=v7

Some prior examples of mine:

1. https://www.thoughtscript.io/blog/000000000005
2. https://github.com/Azure-Samples/Azure-Time-Series-Insights/pull/12
3. https://github.com/Azure-Samples/digital-twins-samples-csharp/pull/67
4. https://github.com/Thoughtscript/more_sql_notes/blob/main/3%20-%20mssql/queries.sql
5. https://github.com/Thoughtscript/jupyter_notebook