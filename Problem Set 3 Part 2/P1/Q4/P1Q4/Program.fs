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

and f xs =
    match List.head xs with
        |ID -> advance xs 
        |LPAREN -> advance xs |> e |> b
        |_ -> failwith (sprintf "Not a valid token for f %A" xs)

let test_program program =
    let result = program |> e
    match result with 
    | [] -> failwith "Early termination or missing EOF"
    | x::xs -> if x = EOF then accept else error


printf "%A" (test_program [ID;SUB;ID;MUL;ID;EOF])
printf "%A" (test_program [ID;ADD;ID;ADD;ID;ADD;ID;EOF])
printf "%A" (test_program [LPAREN;ID;SUB;ID;RPAREN;MUL;ID;EOF])