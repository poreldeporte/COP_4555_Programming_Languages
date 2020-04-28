// Learn more about F# at http://fsharp.org

let rec oddSum value x =
    match x with
    |0 -> value
    |1 -> value + 1
    |x -> if x % 2 = 0 then 
            oddSum value (x - 1)
          else 
            let newValue = value + x
            oddSum newValue (x - 2)
