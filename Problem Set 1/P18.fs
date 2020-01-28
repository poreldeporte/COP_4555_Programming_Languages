// Problem 18

// The F# function for interleaving two lists
let rec interleave = function   
	|([], ys) -> ys
	|(xs, []) -> xs
	|(x::xs, y::ys) -> x :: y :: interleave (xs,ys)

interleave ([1;2;3],[4;5;6])
