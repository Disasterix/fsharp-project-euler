open System.Collections.Generic
open System

let list = new List<int>()
let mutable total = 0;
let checkNumber x = (x%3 = 0)||(x%5 = 0)

let count() = 
    for i = 1 to 999 do
        if checkNumber(i) then
            list.Add(i)
        
[<EntryPoint>]
let main argv = 
    count()
    for number in list do
        total <- total + number
    Console.WriteLine(total)
    Console.ReadLine() |> ignore
    0 // return an integer exit code

