type 'a stream = Cons of 'a * (unit -> 'a stream)

let rec float2over3 x = Cons(x, fun() -> float2over3((x*2.0)/3.0))

let test = float2over3 5.0

printf "%A" test