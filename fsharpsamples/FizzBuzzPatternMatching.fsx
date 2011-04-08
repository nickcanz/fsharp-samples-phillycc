
let (|FizzBuzz|Fizz|Buzz|Number|) x =
    if x%5=0 && x%3=0   then FizzBuzz
    elif x%3=0          then Fizz
    elif x%5=0          then Buzz
    else                Number

[1..100]
    |> List.map
        (fun n ->
            match n with
            |FizzBuzz -> printfn "FizzBuzz"
            |Fizz -> printfn "Fizz"
            |Buzz -> printfn "Buzz"
            |Number -> printfn "%d" n
         )