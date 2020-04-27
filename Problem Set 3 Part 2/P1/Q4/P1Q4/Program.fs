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

