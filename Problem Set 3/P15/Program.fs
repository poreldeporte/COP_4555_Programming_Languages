open System

let makeMonitoredFun f =
    let c = ref 0
    (fun x -> c := !c+1; printf "Called %d times.\n" !c; f x)

let msqrt = makeMonitoredFun sqrt

let mrev = makeMonitoredFun List.rev

(*
Mrev is inferred to have a generic type of
('_a list -> '_a list) -> ('_a list -> '_a list) instead of ('a -> 'b) -> ('a -> 'b)
*)