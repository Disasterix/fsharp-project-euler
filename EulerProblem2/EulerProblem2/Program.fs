open System

let rec fibonacciRec a b =
  if a + b < 4000000 then
    let current = a + b
    let rest = fibonacciRec b current  
    current :: rest
  else 
    []

let isEven x = x % 2 = 0
   
[<EntryPoint>]
let main argv = 
    let fibonacciList = 1::2::(fibonacciRec 1 2)
    Console.WriteLine(fibonacciList |> List.filter isEven |> List.sum)
    Console.ReadLine() |> ignore
    0
