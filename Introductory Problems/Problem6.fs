open System

let rec conca = function 
  |1 -> 0
  |n -> if n%3=0 || n%5=0 then n + conca(n-1) else conca(n-1)
   

[<EntryPoint>]
let main argv = 
  Console.Write("Enter Number: ")
  let number = (Console.ReadLine() |> int)
  printfn "The sum is: %A" (conca number)
  0
  