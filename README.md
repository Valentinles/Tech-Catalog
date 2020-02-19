# TechCatalog
**TechCatalog** is ASP.NET Core web application which simulates catalog of laptops, tvs, refrigerators, cookers, mobile phones and other 
appliances.

<img src="https://i.postimg.cc/JhGQ9Shw/Screenshot-1.png" width="285"/> <img src="https://i.postimg.cc/cH3BJYYX/Screenshot-2.png" width="285"/> <img src="https://i.postimg.cc/BvkCsN8j/Screenshot-3.png" width="285"/> 
## Getting Started

###### To run the application you need:
- .NET Core 3.1

- Cloned and started [TechCatalog Admin Panel](https://github.com/Valentinles/TechCatalog-AdminPanel) repository(follow admin panel repository's readme to run the application).

- If you don't have *Sql server* on your machine you should replace the configuration in *TechCatalogAdminPanel.Web/appsettings.json* with this code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=TechCatalog;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## Used technologies
- C#
- .NET Core 3.1
- .NET Core MVC
- Entity Framework Core
- Bootstrap 
- HTML
- CSS
