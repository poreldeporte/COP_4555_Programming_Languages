let rec divisorSum counter value x =
    match counter with
    |0 -> value
    |_ -> if x % counter <> 0 then 
            divisorSum (counter - 1) value x
          else 
            let newValue = value + counter
            divisorSum (counter - 1) newValue x
