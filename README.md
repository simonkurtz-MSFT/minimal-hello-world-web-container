# Minimal Hello World Web API Container

This repo contains a minimal web API container that can be used to quickly ascertain that a container can serve requests. This is helpful, for example, when verifying connectivity to Azure Container Apps and other container hosting platforms.

## How to Create & Test this Web API

Some steps are referenced from the [Azure Container Apps .NET Workshop](https://azure.github.io/aca-dotnet-workshop).

1. Download the [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0).
1. Follow the [Prerequisites](https://azure.github.io/aca-dotnet-workshop/aca/00-workshop-intro/4-prerequisites/) for `.gitignore` and `global.json` files.
1. Create a new, minimal web API: `dotnet new webapi -n HelloWorld`
1. Change directories to *HelloWorld* and build the project: `dotnet build`
1. Strip down the project as much as you want.
1. Execute `dotnet run` and open http://localhost:8080. A request to the root simply returns a *Hello World!* string.

You can also test it via curl: `curl -v http://localhost:8080`

## Create & Optmize the Container

We follow [Module 12 - Optmize Containers](https://azure.github.io/aca-dotnet-workshop/aca/12-optimizes/) of the Azure Container Apps .NET Workshop to create a smaller container:
Run `docker image ls` to see all images and their sizes after executing the below `docker build` commands.

### Regular Container

1. `docker build -t hello-world -f .\HelloWorld\Dockerfile .`
1. `docker run -d -p 8080:8080 --name hello-world hello-world`
1. http://localhost:8080

### Chiseled Container

1. `docker build -t hello-world-chiseled -f .\HelloWorld\Dockerfile.chiseled .`
1. `docker run -d -p 8081:8080 --name hello-world-chiseled hello-world-chiseled`.
1. http://localhost:8081

### Chiseled Ahead-of-Time (AOT) Container

1. `docker build -t hello-world-chiseled-aot -f .\HelloWorld\Dockerfile.chiseled.aot .`
1. `docker run -d -p 8082:8080 --name hello-world-chiseled-aot hello-world-chiseled-aot`.
1. http://localhost:8082
