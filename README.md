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
1. Run the container via `docker run -d -p 8080:8080 --name hello-world-container hello-world`.

