let rec multipleSum value x =
    match x with
    |0 | 1 | 2 -> value
    |x -> if x % 3 <> 0 then 
            multipleSum value (x - (x % 3))
          else 
            let newValue = value + x
            multipleSum newValue (x - 3)

let test = multipleSum 0 8

printf "%A" test