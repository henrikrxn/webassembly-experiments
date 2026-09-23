# How to build and run

Based on example from [componentize-dotnet](https://github.com/bytecodealliance/componentize-dotnet)

For now not the best developer experience, but build in this order:

- Library
- Consumer
- Composed component

## Library component

```powershell
> dotnet build -c Debug
> cd bin\Debug\net10.0\wasi-wasm\publish\
> wasmtime run --invoke 'add(123,456)' .\library-component.wasm
579
> wasmtime run --invoke 'subtract(456,123)' .\library-component.wasm
333
```

## Composed component

```powershell
> dotnet build -c Debug
> cd dist
> wasmtime run --dir . .\calculator.wasm
```


## Consumer component

??
