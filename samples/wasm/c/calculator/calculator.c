#include <emscripten.h>

/* EMSCRIPTEN_KEEPALIVE adds a function to the exports in the wasm file */

EMSCRIPTEN_KEEPALIVE
int add(int x, int y) {
  return x + y;
}

EMSCRIPTEN_KEEPALIVE
int subtract(int x, int y) {
  return x - y;
}