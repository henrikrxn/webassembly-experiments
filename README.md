# webassembly-experiments

This repository contains experiments with WebAssembly and using it across different languages.

So far it contains:

* `wasiconsole-hello-world`
  Building a WASI compliant WASM file on .NET 8, which is currently in Preview 5.
  Currently only writes to console and should be expanded to do the same as the `go` sample, i.e. use functionality only available in WASI.
* `samples\wasi\go`
  Hello World in go. Copied from [meteatamel/wasm-basics](https://github.com/meteatamel/wasm-basics/tree/main/samples/go-wasm)


