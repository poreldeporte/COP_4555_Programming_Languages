let twice f = (fun x -> f (f x))

let succ n = n+1

let result = (twice (twice (twice (twice succ)))) 0
//Twice called; 1: 2 (2^1) 2: 4 (2^2) 3: 8 (2^3) 4: 16 (2^4)
