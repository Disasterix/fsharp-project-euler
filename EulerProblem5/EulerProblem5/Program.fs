open System

let rec searchDivisible n a =
    let rec isDiv n a =
        a |> List.filter (fun x -> n % x = 0)
    let result = isDiv n a

    if result = a then
        n
    else
        searchDivisible (n+1) a
    
[<EntryPoint>]
let main argv = 
    searchDivisible 1 [1..20] |> printfn "%i" 
    Console.ReadKey() |> ignore
    0