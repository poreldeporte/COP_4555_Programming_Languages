(*
Look at the literals
Look at the functions and other values something interacts with
Look at any explicit type constraints
If there are no constraints anywhere, automatically generalize to generic types
*)

(*
a)  fun f -> match f with 
    |[] -> 5
    |x::xs -> 5 + x
    Does first two steps and gets int list -> int
b)  fun x -> (@) x
    Does second step and 4th step to get a' list -> a' list
c)  fun x -> x::5
    Does first step and second step to get int -> int list
d)  fun f -> String.length (f "cat")
    Does second step and first step to get string -> string
e)  fun x y -> x + " " + y
    Does second step, which gives string -> string -> string
f)  fun f -> f (f "cat")
    Does first step, which gives string -> string -> string
*)