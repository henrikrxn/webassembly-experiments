## .NET WASI app

Staying on .NET 8 as it seems that `wasi-experimental` will not be supported in .NET 9. See [issue on Github](https://github.com/dotnet/runtime/pull/108877)

## Instructions last updated for this configuration

* .NET 10.0.200 (10.0.4)
* Wasmtime 42.0.1
* WASI SDK v32

## Build

You should also be able to use the `Release` configuration, but I only tried it with `Debug`. 

You can build the app from Visual Studio or from the command-line:

```
dotnet build -c Debug
```

After building the app, the result is in the `bin/Debug/net10.0/wasi-wasm/` directory. The `Appbundle` folder is still
there and used to be the place, but that no longer works.

## Run

You can run the app from Visual Studio or the command-line, which does not work for .NET 10:

```
dotnet run -c Debug
```

So you'll have to start from the `wasi-wasm` directory:

```
cd .\bin\Debug\net10.0\wasi-wasm\
wasmtime run --wasi http --dir . dotnet.wasm wasiconsole-hello-world
```

## If you want single file WASM

* Get the WebAssembly [WASI SDK](https://github.com/WebAssembly/wasi-sdk/releases) archive
* "Install" it
* Set environment variable `WASI_SDK_PATH`

[This](https://henrikrxn.github.io/blog/Webassembly-dotnet-8-hello-world/)
blog post has precise information for a Windows setting.
