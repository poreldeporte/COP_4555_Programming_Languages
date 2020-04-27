type 'a stream = Cons of 'a * (unit -> 'a stream)

let rec plus x = Cons(x, fun() -> plus(x+23))

let test = plus 0

printf "%A" test