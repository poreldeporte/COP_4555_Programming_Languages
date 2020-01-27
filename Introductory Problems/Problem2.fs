open System

let getName() = 
  printf "What is your name?"
  Console.ReadLine()

let output(s:String) =
  printf "Hello %s" s

[<EntryPoint>]
let main argv = 
  let input = getName()
  output input
  0
    