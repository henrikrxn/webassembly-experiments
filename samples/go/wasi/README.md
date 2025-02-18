# Go WASI app

TODO: Update for Go 1.24

## Implementations

TinyGo has been ahead of Go when it comes to WASI support.

### Go

wasip1 introduced in Go 1.21, see https://go.dev/doc/go1.21#wasip1

See [Go downloads](https://go.dev/dl/)

Code copied from [meteatamel/wasm-basics](https://github.com/meteatamel/wasm-basics/tree/main/samples/go-wasm)

### TinyGo

https://tinygo.org/docs/guides/webassembly/wasi/

## How to build and run

`Powershell`

```Powershell
PS> $Env:GOOS="wasip1"
PS> $Env:GOARCH="wasm"
PS> go build -o wasi-in-go.wasm .\wasi.go
PS> wasmtime wasi-in-go.wasm --mapdir /helloworld::.
```

## Status on WASI in Go and TinyGo



NB: [TinyGo](https://tinygo.org/) can do more, e.g. export functions.
Both WASI Preview 1 (wasip1) and WASI Preview 2 (wasip2) are currently supported.

| About      | Description |
| ---- | ---- |
| Version used | 1.21RC2 |
| Maturity | Experimental |

| Feature      | Description |
| :---| :----: |
| Call main      | ✔️       |
| Support WASI, e.g. filesystem      | ✔️       |
| Export function(s)  | ❌        |

TODO:

1) Update with never versions. Also Go got better support since this was originally written I think
2) Add links to the issue about implementation