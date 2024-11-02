## .NET WASI app

Staying on .NET 8 as it seems that `wasi-experimental` will not be supported in .NET 9. See [issue on Github](https://github.com/dotnet/runtime/pull/108877)

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
wasmtime run wasiconsole-hello-world.wasm
```

## If you want single file WASM

* Get the WebAssembly [WASI SDK](https://github.com/WebAssembly/wasi-sdk/releases) archive
* "Install" it
* Set environment variable `WASI_SDK_PATH`

[This](https://henrikrxn.github.io/blog/Webassembly-dotnet-8-hello-world/)
blog post has precise information for a Windows setting.
