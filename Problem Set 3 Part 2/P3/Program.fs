let helper x = x + 10

let rec tailmap list xs =
    match xs with
    |[] -> list
    |x::xs -> let newlist = list @ [helper x]
              tailmap newlist xs
    