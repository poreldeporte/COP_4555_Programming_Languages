open System

let rec conca = function 
  |1 -> 1
  |n -> n + conca(n-1)

[<EntryPoint>]
let main argv = 
  Console.Write("Enter Number: ")
  let number = (Console.ReadLine() |> int)
  printfn "The sum is: %A" (conca number)
  0
  