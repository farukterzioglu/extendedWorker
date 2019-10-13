
Includes:  
Worker Service (Extended)  
Worker Service (Extended) Class  

Install "Worker Service (Extended)" from source code
```
dotnet new -i ./Company.Application1
```

Install "Worker Service (Extended) Class" from source code
```
dotnet new -i ./extendedWorkerClass
```

Usage  
```
cd test/
dotnet new workerextended -n NewWorkerApp

cd NewWorkerApp/
dotnet run
// Hit 'CTRL+C' to exit

dotnet new workerextended-service -n Worker2
//Update Program.cs ->
...
.ConfigureServices((hostContext, services) =>
{
    ...
    services.AddHostedService<Worker2>();
});

dotnet run
// Hit 'CTRL+C' to exit
```

Create Nuget Package  
```
dotnet pack
// To install from .nupkg file
dotnet new -i bin/Debug/Worker.Extended.1.0.0.nupkg
```

References:  
https://github.com/aspnet/AspNetCore/tree/master/src/ProjectTemplates/Web.ProjectTemplates/content/Worker-CSharp  
https://github.com/dotnet/templating/wiki/%22Runnable-Project%22-Templates  
https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/   
https://github.com/sayedihashimi/dotnet-new-samples  
https://github.com/dotnet/dotnet-template-samples  
