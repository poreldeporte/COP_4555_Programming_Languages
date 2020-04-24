type tree =
    | E
    | N of int * tree

let n5 = N(5, E)
let n4 = N(4, n5)
let n3 = N(3, n4)
let n2 = N(2, n3)

let list = N(1, n2)
printf "%A\n" list