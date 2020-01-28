// Write a function that returns the largest element in a list.
open System

let list = [1;5;10;15;11]

let rec largestNum = function
  | [] -> printf "List is empty"
  | [x] -> x
  | x::xs -> let big = largestNum(xs)
    		 if x > big then x
    		 else big  

[<EntryPoint>]
let main argv = 
  printfn "The largest num is: %d" (largestNum list)
  System.Console.ReadLine() |> ignore
  0
  