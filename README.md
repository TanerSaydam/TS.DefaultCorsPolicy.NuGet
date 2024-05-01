# DefaultCorsPolicy NuGet Package

## Overview
The DefaultCorsPolicy NuGet package provides a simple and efficient way to enable Cross-Origin Resource Sharing (CORS) in your .NET applications. This package is designed to allow all incoming requests from different origins, making it ideal for development environments or applications where origin restrictions are not a concern.

## Features
- Allows any header.
- Permits any method (GET, POST, PUT, DELETE, etc.).
- Supports credentials in cross-origin requests.
- Sets the policy to allow requests from any origin.

## Installation
To install the DefaultCorsPolicy package, you can use the NuGet Package Manager console in Visual Studio:

```shell
Install-Package TS.DefaultCorsPolicy
```

Or use the .NET CLI:

```shell
dotnet add package TS.DefaultCorsPolicy
```

## Usage
To use the TS.DefaultCorsPolicy in your .NET application:

```csharp
builder.Services.AddDefaultCors();
...
...
app.UseCors();
```