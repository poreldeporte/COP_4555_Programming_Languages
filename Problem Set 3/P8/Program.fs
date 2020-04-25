let rec power result x =
    match x with
    |_ when x = 0I -> 1I
    |_ when x = 1I -> result
    |x -> let newresult = result * 2I
          power newresult (x - 1I)

let test = power 2I 4I

printf "%A\n" test