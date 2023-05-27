## .NET WASI app

## Build

You should also be able to use the `Release` configuration, but I only tried it with `Debug`. 

You can build the app from Visual Studio or from the command-line:

```
dotnet build -c Debug
```

After building the app, the result is in the `bin/Debug/net8.0/wasi-wasm/AppBundle` directory.

## Run

You can build the app from Visual Studio or the command-line:

```
dotnet run -c Debug
```

Or directly start node from the AppBundle directory:

```
cd .\bin\Debug\net8.0\wasi-wasm\AppBundle\
wasmtime .\dotnet.wasm --dir . wasiconsole-hello-world
```
