open System

[<EntryPoint>]
let main argv = 
    let square x = x*x
    Console.WriteLine (square ([1..100] |> List.sum) - ([1..100] |> List.map square |> List.sum ))
    Console.ReadKey() |> ignore
    0 // return an integer exit code
