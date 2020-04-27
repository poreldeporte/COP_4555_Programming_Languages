let rec revlist xs =
    match xs with
    |[] -> []
    |x::xs -> revlist xs @ [x]

let list = [1;2;3;4;5]
let test = revlist list

printf "%A" test

