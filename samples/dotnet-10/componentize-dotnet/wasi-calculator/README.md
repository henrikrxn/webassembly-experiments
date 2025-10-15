# How to build and run

For now not the best developer experience:

## Composed component

```powershell
> dotnet build -C debug
> cd dist
> wasmtime run --dir . .\calculator.wasm
```

## Library component

```powershell
> dotnet build -C debug
> cd  bin\Debug\net10.0\wasi-wasm\publish\
> wasmtime run --invoke 'add(123,456)' .\library-component.wasm
```

## Consumer component

??
