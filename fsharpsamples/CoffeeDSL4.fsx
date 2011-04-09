open System

[<Measure>] type oz

type Coffee(size:int<oz>, hasMilk:bool, hasSugar:bool) =
    let mutable extras = Seq.empty<string>
    member this.Extras
        with get() = extras
        and set s = extras <- s
    override this.ToString() = 
        String.Format("New Coffee {0}, with milk: {1}, with sugar: {2}", (int(size)), hasMilk, hasSugar)

let (!+) (condiment:string) (caf:Coffee) =
    caf |> caf.Extras <- Seq.append caf.Extras [condiment] yield caf


let (!!+) (condiment:string) (caf:Coffee) =
    caf.Extras <- Seq.append caf.Extras [condiment;condiment]
    caf

let milk = true
let sugar = true

let ``Make Coffee`` size hasMilk hasSugar =
    new Coffee(size, hasMilk, hasSugar)


let nicksCoffee =
    ``Make Coffee`` 16<oz> milk (not sugar)
        |> !+ "Nutmeg"
        |> !!+ "Whipped Cream"
    