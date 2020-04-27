let rec revlist xs =
    match xs with
    |[] -> []
    |x::xs -> revlist xs @ [x]

let list = [1;2;3;4;5]
let test = revlist list

printf "%A" test

let rec revlisttail list xs =
    match xs with 
    |[] -> list
    |x::xs -> let newlist = x::list
              revlisttail newlist xs

let test1 = revlisttail [] list
              
printf "%A" test1

(* 
Time Complexity of revlist: O(n^2)
Time Complexity of revlisttail: O(n)
*)