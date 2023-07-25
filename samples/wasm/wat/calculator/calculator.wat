(module
    (func $add (param $p1 i32) (param $p2 i32) (result i32)
        (i32.add (local.get $p1) (local.get $p2))
    )

    (func $subtract (param $p1 i32) (param $p2 i32) (result i32)
        (i32.sub (local.get $p1) (local.get $p2))
    )

    (export "add" (func $add))
    (export "subtract" (func $subtract))
)