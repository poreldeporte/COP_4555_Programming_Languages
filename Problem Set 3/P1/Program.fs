type tree =
    | E
    | N of int * tree

let n5 = N(5, E)
let n4 = N(4, n5)
let n3 = N(3, n4)
let n2 = N(2, n3)

let list = N(1, n2)
printf "%A\n" list

let rec tolink xs =
    match xs with
    |[] -> E
    |x::xs -> N(x, tolink (xs))

let reglist = [1..5]

let test = tolink reglist

printf "%A\n" test

let rec tolinktail list xs =
    match xs with
    |[] -> list
    |x::[] -> N(x,list)
    |x::xs -> let newlist = N(List.last(xs), list)
              tolinktail newlist (x::(List.truncate (List.length xs - 1) xs))

let reglist2 = [1;2;3;4;5]

let test2 = tolinktail E reglist2

printf "%A\n" test2