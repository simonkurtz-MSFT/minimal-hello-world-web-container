# Minimal Hello World Web API Container

This repo contains a minimal web API container that can be used to quickly ascertain that a container can serve requests. This is helpful, for example, when verifying connectivity to Azure Container Apps and other container hosting platforms.

## How to Create & Test this Web API

Some steps are referenced from the [Azure Container Apps .NET Workshop](https://azure.github.io/aca-dotnet-workshop).

1. Download the [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0).
1. Follow the [Prerequisites](https://azure.github.io/aca-dotnet-workshop/aca/00-workshop-intro/4-prerequisites/) for `.gitignore` and `global.json` files.
1. Create a new, minimal web API: `dotnet new webapi -n HelloWorld`
1. Change directories to *HelloWorld* and build the project: `dotnet build`
1. Strip down the project as much as you want.
1. Execute `dotnet run` and open http://localhost:8080. A request to the root simply returns a *Hello World!* string.

You can also test it via curl: `curl -v http://localhost:8080`

## Create & Optimize the Container

Switch to the `HelloWorld` project directory before proceeding.

### Regular Container

1. `docker build -t hello-world -f .\Dockerfile .`
1. `docker run -p 8080:8080 hello-world`
1. http://localhost:8080

### Chiseled Container

1. `docker build -t hello-world-chiseled -f .\Dockerfile.chiseled .`
1. `docker run -p 8081:8080 hello-world-chiseled`
1. http://localhost:8081
