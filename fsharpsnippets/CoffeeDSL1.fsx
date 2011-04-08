type Coffee(size : int, hasMilk:bool, hasSugar:bool) =
    do printfn "New Coffee %d, with milk: %b, with sugar: %b" size hasMilk hasSugar


let myCoffee = new Coffee(16, true, true)