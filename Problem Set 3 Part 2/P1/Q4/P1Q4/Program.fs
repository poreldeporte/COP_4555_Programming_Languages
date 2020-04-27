type TERMINAL = ID|EOF|ADD|SUB|MUL|RPAREN|LPAREN|DIV

let accept = "Compiled successfully"

let error = "Compiled unsuccessfully"

let advance t = List.tail t

let rec e xs =
    let newlist = t xs
    match List.head newlist with
    |ADD -> advance newlist |> e 
    |SUB -> advance newlist |> e
    |_ -> newlist

and b xs =
    if List.head xs = RPAREN then advance xs else failwith "No close Parenthesis"

and t xs = 
    let newlist = f xs
    match List.head newlist with
        |MUL -> advance newlist |> t 
        |DIV -> advance newlist |> t
        |_ -> newlist

