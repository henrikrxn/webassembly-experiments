# Experimenting with WASI as library

Trying out new functionality based on `dotnet/runtime` Github [issue](https://github.com/dotnet/runtime/issues/96869) 
and [PR](https://github.com/dotnet/runtime/pull/102806)

Can build, but not publish trimmed.

Invoking exports using wasmtime does not work either, but comments in various issues related to wasi / wasm seem to 
indicate this needing more work by the .NET team.

Invoking function without arguments and with no return value:

`$ wasmtime --invoke helloWorld .\calculator-wasi-library.wasm`

results in 

```txt
Assertion failed: class (C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Runtime.Mono.wasi-wasm\9.0.0-preview.6.24327.7\runtimes\wasi-wasm\native\src\runtime.c: mono_wasm_marshal_get_managed_wrapper: 380)
Error: failed to run main module `.\calculator-wasi-library.wasm`

Caused by:
    0: failed to invoke `helloWorld`
    1: error while executing at wasm backtrace:
           0: 0x20893f - <unknown>!<wasm function 7819>
           1: 0x5550 - <unknown>!<wasm function 53>
           2: 0x4be1 - <unknown>!<wasm function 43>
    2: wasm trap: wasm `unreachable` instruction executed
```

Invoking function with arguments and return value:

`$ wasmtime --invoke add .\calculator-wasi-library.wasm 31 11`

```txt
warning: using `--invoke` with a function that takes arguments is experimental and may break in the future
Assertion failed: class (C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Runtime.Mono.wasi-wasm\9.0.0-preview.6.24327.7\runtimes\wasi-wasm\native\src\runtime.c: mono_wasm_marshal_get_managed_wrapper: 380)
Error: failed to run main module `.\calculator-wasi-library.wasm`

Caused by:
    0: failed to invoke `add`
    1: error while executing at wasm backtrace:
           0: 0x20893f - <unknown>!<wasm function 7819>
           1: 0x5550 - <unknown>!<wasm function 53>
           2: 0x4c2d - <unknown>!<wasm function 44>
    2: wasm trap: wasm `unreachable` instruction executed
```
