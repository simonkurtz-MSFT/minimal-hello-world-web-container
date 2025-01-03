# Minimal Hello World Web API Container

This repo contains a minimal web API container that can be used to quickly ascertain that a container can serve requests. This is helpful, for example, when verifying connectivity to Azure Container Apps and other container hosting platforms.

The images are hosted on [Docker Hub](https://hub.docker.com/r/simonkurtzmsft/minimal-hello-world-web).

## .NET Hello World

### Create & Test the Web API

1. Download the [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0).
1. From within the `HelloWorld` project directory, execute `dotnet run`, then open [http://localhost:8080] or `curl -v http://localhost:8080`. A request to the root simply returns a *Hello World!* string.

The Web API was created via the .NET CLI (`dotnet new webapi -n HelloWorld`), then stripped down to only contain the essentials.

### Create & Optimize the Container

The base images are hosted on the Microsoft Artifact Registry:

- ASP.NET Core Runtime: [https://mcr.microsoft.com/en-us/artifact/mar/dotnet/aspnet]
- .NET SDK (for building): [https://mcr.microsoft.com/en-us/artifact/mar/dotnet/sdk]

Switch to the `HelloWorld` project directory before proceeding.

### Regular Container

1. `docker build -t hello-world -f .\Dockerfile .`
1. `docker run -p 8080:8080 hello-world`
1. [http://localhost:8080](http://localhost:8080)

The uncompressed image size will be ~224 MB.
The compressed image size will be ~89.4 MB.

### Chiseled Container

For a .NET Web API, a typical, optimized base image to use is a chiseled ASP.NET image (see [Dockerfile.chiseled](./HelloWorld/Dockerfile.chiseled)). See [.NET Container Images](https://learn.microsoft.com/dotnet/core/docker/container-images#images-optimized-for-size) for details.

1. `docker build -t hello-world-chiseled -f .\Dockerfile.chiseled .`
1. `docker run -p 8081:8080 hello-world-chiseled`
1. [http://localhost:8081](http://localhost:8081)

The uncompressed image size will be ~117 MB.
The compressed image size will be ~49.31 MB.

### Self-Contained, Trimmed Container

For a .NET Web API, the smallest base image we can use is a chiseled ASP.NET image (see [Dockerfile.trimmed](./HelloWorld/Dockerfile.trimmed)). See [.NET Container Images](https://learn.microsoft.com/dotnet/core/docker/container-images#images-optimized-for-size) for details.

1. `docker build -t hello-world-trimmed -f .\Dockerfile.trimmed .`
1. `docker run -p 8082:8080 hello-world-trimmed`
1. [http://localhost:8082](http://localhost:8082)

The uncompressed image size will be ~36 MB.
The compressed image size will be ~13.98 MB.

## Busybox

If you want it even smaller, at its most basic level, you can run a busybox image with `netcat` serving up a static file.

1. Switch to the `HelloWorld-busybox` directory.
1. `docker build -t hello-world-busybox -f .\Dockerfile.busybox .`
1. `docker run -p 8083:8080 hello-world-busybox`
1. [http://localhost:8083](http://localhost:8083)

The uncompressed image size will be ~4.27 MB.
The compressed image size will be ~2.06 MB.
