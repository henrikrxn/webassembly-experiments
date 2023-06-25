# Go WASI app

Requires Go 1.21RC2 (or higher) installed and in path

See [Go downloads](https://go.dev/dl/)

Code copied from [meteatamel/wasm-basics](https://github.com/meteatamel/wasm-basics/tree/main/samples/go-wasm)

## How to build and run

`Powershell`

```Powershell
PS> $Env:GOOS="wasip1"
PS> $Env:GOARCH="wasm"
PS> go build -o wasi-in-go.wasm .\wasi.go
PS> wasmtime wasi-in-go.wasm --mapdir /helloworld::.
```

## Status on WASI in Go

NB: [TinyGo}(https://tinygo.org/) can do more, e.g. export functions.

| About      | Description |
| ---- | ---- |
| Version used | 1.21RC2 |
| Maturity | Experimental |

| Feature      | Description |
| :---| :----: |
| Call main      | ✔️       |
| Support WASI, e.g. filesystem      | ✔️       |
| Export function(s)  | ❌        |
