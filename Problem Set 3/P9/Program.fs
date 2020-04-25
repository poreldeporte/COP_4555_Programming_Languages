let twice f = (fun x -> f (f x))

let succ n = n+1

let result = (twice (twice (twice (twice succ)))) 0
//Twice called; 1: 2 (2^1) 2: 4 (2^2) 3: 8 (2^3) 4: 16 (2^4)
let result2 = twice twice twice twice succ 0
//Twice called; 1: 2 (2^1) 2: 4 (2^2) 3: 16 (2^4) 4: 65536 (2^16)

printf "%A\n" result

printf "%A\n" result2

(* 
When called as twice succ 0, it will return 2^n, where n is the result 
from the previous call.
*)