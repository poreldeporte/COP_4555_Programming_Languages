// Write function that reverses a list, without using and built-in List functions.
open System

let list = [1;5;10;15;11]

let reverse l =
  let rec loop acc = function
    | [] -> acc
    | hd :: tl -> loop (hd :: acc) tl
  loop [] l

[<EntryPoint>]
let main argv = 
  printf "%A" (reverse list)
  0
  