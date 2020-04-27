let helper x = x + 10

let rec tailmap list xs =
    match xs with
    |[] -> list
    |x::xs -> let newlist = list @ [helper x]
              tailmap newlist xs
    
let list = [1;2;3]

let test = tailmap list

printf "%A" test