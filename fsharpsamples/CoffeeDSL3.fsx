
[<Measure>] type oz

type Coffee(size:int<oz>, hasMilk:bool, hasSugar:bool) =
    do printfn "New Coffee %d, with milk: %b, with sugar: %b" (int(size)) hasMilk hasSugar

let milk = true
let sugar = true





let ``Make Coffee`` size hasMilk hasSugar =
    let mycoffee = new Coffee(size, hasMilk, hasSugar)
    ignore


``Make Coffee`` 16<oz> milk (not sugar)
