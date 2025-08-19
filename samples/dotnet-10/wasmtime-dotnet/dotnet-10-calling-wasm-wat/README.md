# Basic instructions

As simple as it gets:

```Powershell
> dotnet run -c Debug
```

doesn't work as reported in this [Github issue](https://github.com/dotnet/runtime/issues/117848), but in a comment
on the same issue a contributor revealed how to make it work:

```Powershell
> dotnet build -c Debug
> cd bin\Debug\net10.0\wasi-wasm\AppBundle
> wasmtime run --wasi http --dir . dotnet.wasm wasiconsole-dotnet-10
```
