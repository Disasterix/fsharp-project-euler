let largestPrimeFactor n =
    let rec factorise n x y = 
        if x = n then
            x::y
        elif n % x = 0L then
            factorise (n/x) x (x::y)
        else
            factorise n (x+1L) y
    factorise n 2L [] |> List.max
let fac = largestPrimeFactor 600851475143L 

[<EntryPoint>]
let main argv = 
    fac |> printfn "%i" 
    System.Console.ReadKey(true) |> ignore 
    0
