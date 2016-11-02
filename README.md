# RedNArch
Part - 1:- How to implement a decoupled, unit testable, N-Tier Architecture based on Generic Repository Pattern with Entity Framework, IOC container and dependency injection in ASP.NET MVC

There are 5 sub projects for implementing a decoupled, unit testable architecture. Once the project is downloaded, build the project to download the appropriate references.
1. RedNArch.Model
2. RedNArch.Repository
3. RedNArch.Service
4. RedNArch.MVC - My Client Application. Not yet added in this version. Will be explained in the next version
5. RedNArch.Test - My Unit testing application using Microsoft VSTS. Will be explained in coming version

The first three projects are completed. In the next coming versions, I will implement CRUD operations using these layers and Autofac IOC container in RedNArch.MVC and test app using NUnit and MOQ testing.

Technologies/Tools used for this project:
1.NET Framework 4.5
2.ASP.NET MVC 5
3.Entity Framework 6.0
4.SQL Server 2008
5.Autofac 3.4
6.MOQ
7.Visual Studio 2015

Objective
1.Clean seperation of concern
2.Easy Unit Testing
3.Usage of design patterns - Repository, UOQ and Dependency Injection

Implementation contains different layers
1. Database (to manage data)
2. Data Access Layer (contains EF LINQ queries, models and datacontext)
3. Service Layer (Business and domain Logic)
4. MVC Web Layer (UI part which talks to service layer only)
5. Test Layer (for unit testing…etc)
