# Portfolio.CalendarEvent
## Overview
The objective of this repository is to complete a quick task to demonstrate skill, thought process, and coding practices per the following guidelines:

> If this takes longer than one hour, please stop at an appropriate point and send what you have. This gives us an idea of efficiency.
> 
> Create a web api project in C#. You can use Framework or Core, but explain your decision.
> Write a DTO class that would be used to show an event on a calendar. It is up to you to decide the fields, explain your choices in comments.
> 
> Skeleton (just function headers) a REST API that will handle requests for the above DTO. It is up to you to decide what the functions should be. Explain your choices in comments.
> 
> Please upload the code to a GitHub repository so we can review it.

## Choosing .NET Core - Explanation
.NET Core was selected based on the following two recommendations in [Microsoft's article](https://docs.microsoft.com/en-us/dotnet/standard/choosing-core-framework-server) on the subject:
- You have cross-platform needs.
- You are targeting microservices.

### Cross-platform
.NET is not tied to a specific platform, thus making it a better candidate for this exercise.  Because platform needs were not 
specified this approach will have the best chance of success for the assessment.

### Microservice
Since this application is organized around a single business capability, displaying an event on a calendar, this use 
case naturally fits into the microservice architectural paradigm.  The microservice approach also defers security and data-access 
concerns to elsewhere within the microservices architecture, limiting the scope of changes required for shipping this API.


## CalendarEvent DTO Properties - Explanation
Based on the use case of "show an event on a calendar", it is implied that the relationship between a calendar and an event
exists, and does not preclude that a single event may exist on multiple calendars.  DateTime is captured in UTC to allow
clients consuming the API to render the local time.  Other fields allow overview or detail information to be displayed.

### CalendarEventId
A CalendarEvent may most uniquely be distinguished among CalendarEvents by it's ID.  Type Guid is used here to more uniquely distinguish this specific DTO among 
other DTOs or identifiers in tables.

### CalendarIds
Provides IEnumerable CalendarIds which identify the various calendars for which this event appears.  Type Guid is used here to more uniquely distinguish this specific DTO among 
other DTOs or identifiers in tables.  

### DateTimeUtc
UTC DateTime to provide a specific universal point in time and remove any ambuiguity due to time zone differences.

### Title
Field allowing for overview of this DTO.

### Description
Field allowing for detail of this DTO.

### IsActive
An activation flag allowing for a simple archive/soft delete operation.

## REST Controller Skeleton - Richardson Maturity Model Level 2
This RESTful service is organized first by the resource CalendarEvent, and further into HTTP Verbs for each given endpoint.  I choose not to achieve RMM3 due to time
constraints and in part because the given use-case is agnositic of actions available to a CalendarEvent.

### Rest Controller Endpoints - Explanation
#### async methods
Use of asynchronous controller methods due to the potential risk for this DTO specific API to have long running threads on data access or HTTP request.

#### return ActionResult<T>
Use of ActionResult<T> allows return of a response envelope with HTTP status code and body.  This best practice will allow consuming clients the ability to
intepret the results; this is especially useful when the response is a 400, 404, or 500 error.

#### Accessors 
  - Get All
  - Get List By ID
  - Get List By Calendar ID

The above accessors provide obvious read capabilities for the system.  Future iterations may choose to limit the "Get All" with a pagination pattern for performance reasons.
Leaving as-is due to time constraints.

#### Mutators
   - Update
   - Create
   - Delete

The above accessors provide the ability to update, create, and delete a specific CalendarEvent within the system.  Future iterations may choose to implement a partial "PATCH"
style update but leaving as-is due to time constraints.

