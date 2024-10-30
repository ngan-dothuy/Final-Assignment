# Dotnet Training

# Description
- 

# Step by Step
1. Create folder "Final-Assignment" with 3 projects:
- Backend-APIs: APS.NET Core Web API
- CustomerSite: MVC Project
- Lib: Class Library 

2. BACKEND-APIs (ASP.NET Core, EF Core)
- Add folder/ file *.cs as below:

Backend-APIs/
│
├── Data/              # Store the classes related to Database (DbContext, seed data)
│   └── DataExtension.cs
    └── ProjectContext.cs
│
├── Endpoints/                # define the API endpoints of project.
│   └── CategoryEndpoint.cs   # define the endpoints related to the Category resource.
│
├── Entities/                 # contains classes that represent the entities of the app.
│   ├── CategoryEntity.cs/    # define the Category entity, represent the attributes of a category
│   
├── Mapping/                  # define how entities map to data transfer objects (DTOs) 
│   ├── CategoryMapping.cs/   
│   

- 

3. CUSTOMERSITE (ASP.NET MVC Core, Razor Page)
- Open Terminal -> navigate to root folder of project
- Using the following command to create Razor page:
dotnet new page --name Category --namespace Category.Pages --output Pages

- Folder "Pages" is generated:
Pages -- Category.cshtml
      -- Category.cshtml.cs

- Integrate with HttpClientFactory for .Net MVC Project:
In Program.cs, add: 
// Register HttpClientFactory
builder.Services.AddHttpClient();

- Use HttpClient to call category endpoint of .Net Core Minimal API to get all categories data
(refer to Category.cshtml.cs)

- Go to Views/ Shared/ _Layout.cshtml and add "Category" menu:
<li><a class="nav-link text-dark" asp-area="" asp-page="/Category">Category</a></li>


4. LIBRARY
- Create folder [Dtos] -> Add new Class [CategoryDto.cs]
- CategoryDto.cs -> declare CategoryDto object as below:
public record class CategoryDto(int Id, string Name);

- To add Library to project -> Open Termmal, navigate to project and run command
dotnet add reference D:\Final-Assignment\Library\Library.csproj

- Add [using Library.Dtos;] in file *.cs when calling CategoryDto object.

