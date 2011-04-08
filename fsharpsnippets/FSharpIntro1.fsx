

//F# is immutable
let x = 5

//Warning! This doesn't assign 3 to x
x = 3 //C#: x == 3

//Classic Recursive function example
let rec factorial n =
    match n with
    | n when n<=1 -> 1
    | _ -> n * factorial (n-1)

(*
F# Lists: Immuateable ordered series of elements
http://msdn.microsoft.com/en-us/library/dd233224.aspx
Not equivalent to C# lists
*)
let mylist = [1..10]

//Pretty much list C# arrays
let myarray = [|11..20|]

//sequences equivelent to C#
//`seq` is alias for IEnumerable
let mysequence = seq { 0 .. 10 }

//Sequence expressions
let mysequence2 = seq { 0 .. 10 .. 100 }


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

//Closely related to...
//Active Patterns

let (|Premier|Normal|) accountBalance = 
    if accountBalance > 5000 then Premier
    else Normal

let whatismyaccount x =
    match x with
    | Premier -> printfn "You're a valued customer!!!!!"
    | Normal -> printfn "You're a normal customer."


