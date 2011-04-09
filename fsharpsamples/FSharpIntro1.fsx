

//F# is immutable
let x = 5

//Classic Recursive function example
let rec factorial n =
    match n with
    | n when n<=1 -> 1
    | _ -> n * factorial (n-1)


let mylist = [1..10]

//Pretty much list C# arrays
let myarray = [|11..20|]

//sequences equivelent to C#
//`seq` is alias for IEnumerable
//Sequence expressions
let mysequence = seq { 0 .. 10 .. 100 }


//Pipelining
let sum = [0..100] |> List.sum

//Ability to chain
let sum2 =
    [0..100]
        |> List.map (fun x -> x*2) 
        |> List.sum

//Note to self: eval `List.sum`` in FSI

//Explorative programming
(*
    Difference between 
    DateTime.Now.ToString("f")
    DateTime.Now.ToString("g")
*)

//Tuples
let mytuple = (5, [1..100])
fst mytuple
snd mytuple

let mytriple = (1, "one", [1])
let a,b,c = mytriple

//Pattern Matching
let matcharray arr = 
    match arr with
    | [|_;2;_;_;|] -> printfn "match on: %A" arr
    | _ -> printfn "nomatch"