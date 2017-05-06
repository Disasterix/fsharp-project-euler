open System

let checkPalindrome (n : int) = 
    let x = Convert.ToString n
    let isPal str = 
        let str = str |> Seq.filter ((<>) ' ') |> Seq.toList
        str = (str |> List.rev)
    isPal x

let multi x y = x * y

let rec calcFull x y z a =
    let rec calcX x y z a =
        let value = multi x y
        if x = z then
            calcFull 0 y z a
        elif checkPalindrome(value) then
            calcX (x+1) y z (value::a)
        else
            calcX (x+1) y z a
    if y > z then
            a
    else
        calcX x (y+1) z a

    
[<EntryPoint>]
let main argv = 
    calcFull 0 0 999 [] |> List.max |> printfn "%i" 
    Console.ReadKey() |> ignore
    0 // return an integer exit code
