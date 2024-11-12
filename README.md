# Minimal Hello World Web API Container

This repo contains a minimal web API container that can be used to quickly ascertain that a container can serve requests. This is helpful, for example, when verifying connectivity to Azure Container Apps and other container hosting platforms.

## How to Create & Test this Web API

Some steps are referenced from the [Azure Container Apps .NET Workshop](https://azure.github.io/aca-dotnet-workshop).

1. Follow the [Prerequisites](https://azure.github.io/aca-dotnet-workshop/aca/00-workshop-intro/4-prerequisites/) for `.gitignore` and `global.json` files.
1. Create a new, minimal web API: `dotnet new webapi -n HelloWorld`
1. Change directories to *HelloWorld* and build the project: `dotnet build`
1. Strip down the project as much as you want.
1. Execute `dotnet run` and open both [http://localhost:8080]. A request to the root simply returns a *Hello World!* string.

You can also test it via curl: `curl -v http://localhost:8080`

## How to Create & Test the Container

1. You can use something like the VS Code Docker Extension (`CTRL + Shift + P` -> *Docker: Add Docker Files to Workspace...*) or edit  *Dockerfile* in the *HelloWorld* folder from this repo.
1. Ensure Docker (or podman or similar) is running, switch to the root in your terminal, then execute `docker build -t hello-world -f .\HelloWorld\Dockerfile .` to create the first image.
1. Run the container via `docker run -d -p 8080:8080 --name hello-world hello-world`.
1. Use a browser or curl to test.

## How to Optmize the Container

Run `docker image ls` to see the image you just created. Using `mcr.microsoft.com/dotnet/aspnet:9.0 AS base` as the base image for this very simple *Hello World* container creates a 224 MB container. We follow [Module 12 - Optmize Containers](https://azure.github.io/aca-dotnet-workshop/aca/12-optimizes/) of the Azure Container Apps .NET Workshop to create a smaller container:

### Regular Container

1. `docker build -t hello-world -f .\HelloWorld\Dockerfile .`
1. `docker run -d -p 8080:8080 --name hello-world hello-world`
1. [http://localhost:8080]

### Chiseled Container

1. `docker build -t hello-world-chiseled -f .\HelloWorld\Dockerfile.chiseled .`
1. `docker run -d -p 8081:8080 --name hello-world-chiseled hello-world-chiseled`.
1. [http://localhost:8081]

### Chiseled Ahead-of-Time (AOT) Container

1. `docker build -t hello-world-chiseled-aot -f .\HelloWorld\Dockerfile.chiseled.aot .`
1. `docker run -d -p 8082:8080 --name hello-world-chiseled-aot hello-world-chiseled-aot`.
1. [http://localhost:8082]
