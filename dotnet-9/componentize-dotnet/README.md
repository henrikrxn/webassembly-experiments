# Straight from blog post

100% Based on BytecodeAlliance [blogpost ](https://bytecodealliance.org/articles/simplifying-components-for-dotnet-developers-with-componentize-dotnet)

Will try to update from time to time.

## Build + run 

Works on .NET 9 RC 2 and Wasmtime 26.0.0

```
$ dotnet build
$ wasmtime serve -S cli .\bin\Debug\net9.0\wasi-wasm\native\componentize-dotnet.wasm --addr 127.0.0.1:3000
```