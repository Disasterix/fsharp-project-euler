open System

let prime n =
    Seq.exists (fun x -> (n % x = 0))

let isPrime n =
    match n with
        | _ -> seq { 2 .. Convert.ToInt32(Math.Sqrt(float n))}
        |> prime n
        |> not

let primes =
    Seq.initInfinite (fun i -> i + 2)
    |> Seq.filter isPrime

[<EntryPoint>]
let main argv = 
    printfn "%A" (primes |> Seq.take 10001 |> Seq.max )
    Console.ReadLine() |> ignore
    0 // return an integer exit code
