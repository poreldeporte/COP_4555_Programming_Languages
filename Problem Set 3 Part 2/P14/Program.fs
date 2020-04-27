type 'a stream = Cons of 'a * (unit -> 'a stream)

let rec tuple (x,y) = Cons((x,y), fun() -> tuple(x+2,y-0.01))

let test = tuple (0,0.0)

printf "%A" test