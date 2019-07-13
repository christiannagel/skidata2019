# 20487 Exam Areas

Source: [Developing Microsoft Azure and Web Services](https://www.microsoft.com/en-us/learning/exam-70-487.aspx)

## 20487 Course Materials

* Module 1 - Overview of Service and Cloud Technologies
* Module 2 - Querying and Manipulating Data Using Entity Framework Core
* Module 3 - Creating and Consuming ASP.NET Core Web APIs
* Module 4 - Extending ASP.NET Core HTTP Services (opt.)
* Module 5 - Hosting Services
* Module 6 - Deploying and Managing Services
* Module 7 - Implementing Data Storage in Azure
* Module 8 - Monitoring and Diagnostics
* Module 9 - Securing Services On-premises and in Microsoft Azure
* Module 10 - Scaling Services

## Accessing Data

* Module 2 - Querying and Manipulating Data Using Entity Framework Core
* Module 7 - Implementing Data Storage in Azure

* Choose data access technologies 
  * Choose a data access technology, including ADO.NET, Entity Framework, WCF Data Services, and Azure Cosmos DB, based on application requirements
* Implement caching 
  * Cache static data, apply cache policies, including policy expirations; use CacheDependency to refresh cache data; query notifications; implement caching using Redis
* Implement transactions 
  * Manage transactions by using the API from System.Transactions namespace; implement distributed transactions including distributed transaction on SQL Azure; specify a transaction isolation level
* Implement data storage in Microsoft Azure 
  * Access data storage in Windows Azure; choose a data storage mechanism in Microsoft Azure. including blobs, tables, queues, Azure SQL, and Cosmos DB; distribute data by using the Content Delivery Network (CDN) and Azure File Sync; handle exceptions by using retries; use Elastic client library with Azure SQL
* Create and implement a WCF Data Services service 
  * Address resources; implement filtering; create a query expression; access payload formats, including JSON; use data service interceptors and service operators; version a data service; implement data services providers; host the dataservice; use actions to implement server-side behavior

[Transaction Isolation Levels](https://docs.microsoft.com/en-us/sql/odbc/reference/develop-app/transaction-isolation-levels?view=sql-server-2017)

[WCF Data Services](https://docs.microsoft.com/en-us/dotnet/framework/data/wcf/index)

[XML Documents and Data](https://docs.microsoft.com/en-us/dotnet/standard/data/xml/index)

## Querying and Manipulating Data using Entity Framework

* Module 2 - Querying and Manipulating Data Using Entity Framework Core

* Query and manipulate data by using the Entity Framework 
  * Query, update, and delete data by using DbContext; build a query that uses deferred execution; implement lazy loading and eager loading; create and run compiled queries; query data by using Entity SQL; create global query filters
* Query and manipulate data by using Data Provider for Entity Framework 
  * Query and manipulate data by using Connection, DataReader, and Command objects from the System.Data.EntityClient namespace; perform synchronous and asynchronous operations; manage transactions (API)
* Query data by using LINQ to Entities 
  * Query data by using LINQ operators, including project, skip, aggregate, filter, and join; log queries; implement query boundaries
* Query and manipulate data by using ADO.NET 
  * Query and manipulate data by using Connection, DataReader, and Command objects; perform synchronous and asynchronous operations; manage transactions
* Create an Entity Framework data model 
  * Structure a data model using Table per type, table per class, and table per hierarchy; select and implement an approach to manage a data model, including code first, model first, and database first; implement POCO objects; describe a data model by using conceptual schema definitions, storage schema definitions, and mapping languages, including CSDL, SSDL, and MSL
* Implement Entity Framework with third party databases 
  * Implement Entity Framework using MySQL and SQLite databases; design a strategy to manage differences between database capabilities; leverage database specific technologies, including ON DUPLICATE KEY using Entity Framework

[Entity Framework](https://docs.microsoft.com/en-us/ef/ef6/index)

[Loading related entities](https://docs.microsoft.com/en-us/ef/ef6/querying/related-data)

[IQueryable<T> Interface](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1?redirectedfrom=MSDN&view=netframework-4.8)

## Creating and consuming Web API-based services

* Module 3 - Creating and Consuming ASP.NET Core Web APIs

* Design a Web API 
  * Define HTTP resources with HTTP actions; plan appropriate URI space, and map URI space using routing; choose appropriate HTTP method to meet requirements; choose appropriate Web API formats for responses to meet requirements; plan when to make HTTP actions asynchronous
* Implement a Web API 
  * Accept data in JSON format; use content negotiation to deliver different data formats to clients; define actions and parameters to handle data binding; implement dependency injection to create more flexible applications; implement action filters and exception filters to manage controller execution; implement asynchronous and synchronous actions; implement streaming actions; implement middleware
* Secure a Web API 
  * Implement Identity for authentication; implement authorization using roles, claims, and custom authorization; implement Data Protection APIs; enable cross-domain requests (CORS); prevent cross-site request forgery (XSRF); implement and extend authorization filters to control access to applications
* Host and manage Web API 
  * Host Web API in IIS; self-host a Web API in your own process; host Web API in Kestrel; host services in a Windows Azure Web App; host services in Docker containers; configure the host server for streaming; work with a hosting environment
* Consume Web API web services 
  * Consume Web API services by using HttpClient; send and receive requests in different formats; handle retry logic; implement content negotiation; use Swagger to construct Uris and payloads; use AutoRest to build clients

[Getting started with ASP.NET Web API 2 (C#)](https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api)

[Implementing Basic CRUD functionality with the Entity Framework in ASP.NET MVC application](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/implementing-basic-crud-functionality-with-the-entity-framework-in-asp-net-mvc-application)

[Json class](https://docs.microsoft.com/en-us/dotnet/api/system.web.helpers.json?redirectedfrom=MSDN&view=aspnet-webpages-3.2)

## Designing and implementing Web services

* Module 10 - Scaling Services

* Consume a WCF service 
  * Generate proxies by using SvcUtil; generate proxies by creating a service reference; create and implement channel factories; configure WCF services by using configuration settings; create and configure bindings for WCF services; relay bindings to Azure using service bus endpoints; integrate with the Azure service bus relay
* Implement serverless Azure Web Services 
  * Host web services using App Services, including Logic Apps and API Apps; design and implement Azure Function based services; design and implement Azure Web Jobs; design and implement Service Fabric based web services; implement schedule-based processing in a serverless environment
* Implement traffic management in Azure 
  Implement Azure Load Balancer, including scaling; implement Azure Application Gateway; implement Azure Traffic Manager; design for multiple regions; leverage Azure CDN for caching web services; implement Log Analytics
* Implement Azure API Management 
  * Secure Web Services using certificates, Azure Active Directory, and OAuth; define and implement policies, including secrets, caching, external services, monitoring and throttling; define API interface using the Azure Portal and Swagger; manage running services using logging, disaster recovery, and multiple regions
* Monitor web services 
  * Collect logs and metrics using Azure Event Hubs; process logs and metrics using Azure Event Hubs, Stream Analytics, and Machine Learning; use Azure App Insights to monitor and troubleshoot web services

## Deploying Web Applications and Services

* Module 5 - Hosting Services
* Module 6 - Deploying and Managing Services

* Design a deployment strategy 
  * Deploy using Web Deploy; deploy using Web Publishing in Visual Studio; deploy a web application by using XCopy; automate a deployment from VSTS or TFS Build Server; deploy a web application to a Docker container; design a continuous deployment pipeline; deploy using cloud sync
* Choose a deployment strategy for Azure 
  * Determine appropriate service; perform an in-place upgrade and deployment slot swap; create staging environments; configure an upgrade domain; create and configure input and internal endpoints; specify operating system configuration; implement ARM templates to customize deployment; deploy to Service Fabric; deploy to Azure Stack
* Configure a web application for deployment 
  * Switch from production or release mode to debug mode; transform configuration files ; configure Azure configuration settings; configure Azure Key Vault for application secrets; configure deployment credentials for Azure App Service
* Manage packages by using NuGet 
  * Create and configure a NuGet package; install and update an existing NuGet package; resolve versioning conflict issues; connect to a local repository cache for NuGet, set up your own package repository; manage NuGet dependencies
* Share assemblies between multiple applications and servers 
  * Prepare the environment for use of assemblies across multiple servers; sign assemblies by using a strong name; deploy assemblies to the global assembly cache; implement assembly versioning; create an assembly manifest; configure assembly binding redirects; target netstandard for cross platform libraries

[ASP.NET Web Deployment using Visual Studio: Introduction](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/deployment/visual-studio-web-deployment/introduction)

[How to: Create a Web Deployment Package in Visual Studio](https://docs.microsoft.com/en-us/previous-versions/aspnet/dd465323(v=vs.110))

[Installing NuGet](https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools)
