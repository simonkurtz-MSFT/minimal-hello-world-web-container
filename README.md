# Minimal Hello World Web API Container

This repo contains a minimal web API container that can be used to quickly ascertain that a container can serve requests. This is helpful, for example, when verifying connectivity to Azure Container Apps and other container hosting platforms.

The images are hosted on [Docker Hub](https://hub.docker.com/r/simonkurtzmsft/minimal-hello-world-web).

## Create & Test the Web API

1. Download the [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0).
1. From within the `HelloWorld` project directory, execute `dotnet run`, then open http://localhost:8080 or `curl -v http://localhost:8080`. A request to the root simply returns a *Hello World!* string.

The Web API was created via the .NET CLI (`dotnet new webapi -n HelloWorld`), then stripped down to only contain the essentials.

## Create & Optimize the Container

The base images are hosted on the Microsoft Artifact Registry:

- ASP.NET Core Runtime: https://mcr.microsoft.com/en-us/artifact/mar/dotnet/aspnet
- .NET SDK (for building): https://mcr.microsoft.com/en-us/artifact/mar/dotnet/sdk

Switch to the `HelloWorld` project directory before proceeding.

### Regular Container

1. `docker build -t hello-world -f .\Dockerfile .`
1. `docker run -p 8080:8080 hello-world`
1. http://localhost:8080

The image size will be ~224 MB.

### Chiseled Container

For a .NET Web API, the smallest base image we can use is a chiseled ASP.NET image (see *Dockerfile.chiseled*)

1. `docker build -t hello-world-chiseled -f .\Dockerfile.chiseled .`
1. `docker run -p 8081:8080 hello-world-chiseled`
1. http://localhost:8081

The image size will be ~117 MB.
