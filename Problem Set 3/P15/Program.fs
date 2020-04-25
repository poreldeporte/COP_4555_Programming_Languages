open System

let makeMonitoredFun f =
    let c = ref 0
    (fun x -> c := !c+1; printf "Called %d times.\n" !c; f x)

let msqrt = makeMonitoredFun sqrt

(*
First, explain why F# does not allow the following declaration:
  let mrev = makeMonitoredFun List.rev
F# does not allow the declaration because mrev has been inferred to have a generic type of
('_a list -> '_a list) -> ('_a list -> '_a list) as opposed to ('a -> 'b) -> ('a -> 'b)

Now suppose we rewrite the declaration using the technique of eta expansion:

  let mrev = fun x -> (makeMonitoredFun List.rev) x

Does this solve the problem? Explain why or why not. 
Yes, as it fixes the inference problem since it was specified by the programmer.
*)