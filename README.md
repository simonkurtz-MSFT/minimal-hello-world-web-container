# Minimal Hello World Web API Container

This repo contains a minimal web API container that can be used to quickly ascertain that a container can serve requests. This is helpful, for example, when verifying connectivity to Azure Container Apps and other container hosting platforms.

## How to Create & Test this Web API

Some steps are referenced from the [Azure Container Apps .NET Workshop](https://azure.github.io/aca-dotnet-workshop).

1. Follow the [Prerequisites](https://azure.github.io/aca-dotnet-workshop/aca/00-workshop-intro/4-prerequisites/) for `.gitignore` and `global.json` files.
1. Create a new, minimal web API: `dotnet new webapi -n HelloWorld`
1. Change directories to *HelloWorld* and build the project: `dotnet build`
1. Strip down the project as much as you want.
1. Set up the dev cert via `dotnet dev-certs https --trust`.
1. Execute `dotnet run` and open both http and https URLs. A request to the root simply returns a *Hello World!* string. Note that I left both configured depending on how you may want to reach the web app.

You can also test it via curl: `curl -v http://localhost:5080` and `curl -v https://localhost:5443`.
