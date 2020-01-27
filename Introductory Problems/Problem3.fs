open System

let getName() = 
  printf "Enter your name: "
  Console.ReadLine()

let output(s:String) =
  printfn "Hello %s!" s

let rec intro x = 
  if x > 0 then
    let input = getName()
    if input = "Alice" then output input
    if input = "Bob" then output input
    intro (x-1)

[<EntryPoint>]
let main argv = 
  intro 3
  0
