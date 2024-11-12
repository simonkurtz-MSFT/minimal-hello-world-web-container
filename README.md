# Minimal Hello World Web API Container

This repo contains a minimal web API container that can be used to quickly ascertain that a container can serve requests. This is helpful, for example, when verifying connectivity to Azure Container Apps and other container hosting platforms.

## How to Create this Container

Some steps are referenced from the [Azure Container Apps .NET Workshop](https://azure.github.io/aca-dotnet-workshop).

1. Follow the [Prerequisites](https://azure.github.io/aca-dotnet-workshop/aca/00-workshop-intro/4-prerequisites/) for `.gitignore` and `global.json` files.

1. Create a new, minimal web API: `dotnet new webapi -n HelloWorld`

1. Change directories to *HelloWorld* and build the project: `dotnet build`
