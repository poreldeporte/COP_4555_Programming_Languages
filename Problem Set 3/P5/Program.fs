let rec iltr list xs ys =
    match xs, ys with  
    |[], [] -> list
    |x::xs, y::ys -> let newlist = list @ [x;y]
                     iltr newlist xs ys

let rec il xs ys =
    match xs, ys with
    |[], [] -> []
    |x::xs, y::ys -> x::y::(il xs ys)

let list1 = [1..2..19999]
let list2 = [2..3..20000]

let test = il list1 list2
let test2 = iltr [] list1 list2

printf "%A\n\n" test
printf "%A\n\n" test2

//Tail-recursion is actually slower in this case..