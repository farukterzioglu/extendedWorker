Run with development settings  
```
$ export ENVIRONMENT=Development
$ dotnet run
```

Run with production settings  
```
$ export ENVIRONMENT=Production
$ dotnet run
```

Set app settings as environment parameter  
```
$ export ENVIRONMENT=Production # Production settings activated (interval= 5 sec)
$ export Settings__WorkerIntervalSec=3 # Overrides prod settings (interval= 3 sec)
$ dotnet run
```

VS Code Debug snippets  
```
launch.json
{
    "name": "Debug Company.Application1",
    "type": "coreclr",
    "request": "launch",
    "preLaunchTask": "build",
    "program": "${workspaceFolder}/Company.Application1/bin/Debug/netcoreapp3.0/Company.Application1.dll",
    "args": [],
    "cwd": "${workspaceFolder}/Company.Application1",
    "console": "internalConsole",
    "stopAtEntry": false
}

tasks.json
{
    "label": "build",
    "command": "dotnet",
    "type": "process",
    "args": [
        "build",
        "${workspaceFolder}/Company.Application1/Company.Application1.csproj",
        "/property:GenerateFullPaths=true",
        "/consoleloggerparameters:NoSummary"
    ],
    "problemMatcher": "$msCompile"
}
```