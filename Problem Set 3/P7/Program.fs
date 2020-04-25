type 'a stream = Cons of 'a * (unit -> 'a stream)

let rec mult xs = Cons(xs, fun() -> mult(xs))

let test = mult [2;3;10;21]

printf "%A" test