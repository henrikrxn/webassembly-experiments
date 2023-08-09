//go:build wasm && js && !wasi

package main

// Attempt at dirty hack to avoid TinyGo depending upon fd_write
// See https://github.com/tinygo-org/tinygo/issues/1123
// But in TinyGo 0.28.1 this no longer prevents the import from being generated
//
// export fd_write
//func fd_write() (errno uint) {
//	return 0
//}

// DOES NOT WORK IN tinygo 0.28.1:  go:wasm-module calculator-in-go
// See https://github.com/tinygo-org/tinygo/issues/3839
//
//export add
func add(x int32, y int32) int32 {
	return x + y
}

// DOES NOT WORK IN tinygo 0.28.1:  go:wasm-module calculator-in-go
// See https://github.com/tinygo-org/tinygo/issues/3839
//
//export subtract
func subtract(x int32, y int32) int32 {
	return x - y
}

// Needed even though it is a noop
func main() {}

// Right now it seems like tinygo does not care and always builds wasi ?
