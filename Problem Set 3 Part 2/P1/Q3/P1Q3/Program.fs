﻿type TERMINAL = IF|THEN|ELSE|BEGIN|END|PRINT|SEMICOLON|ID|EOF

let accept = "Compiled successfully"

let error = "Compiled unsuccessfully"

let eat terminal = function
| [] -> failwith "Empty token on eat"
| x::xs -> if x = terminal then xs else failwith "Not a valid token for eat"

let e = eat ID

let rec s xs =
    match xs with
        | IF::xs -> xs |> e |> eat THEN |> s |> eat ELSE |> s
        | BEGIN::xs -> xs |> s |> l
        | PRINT::xs -> xs |> e
        | _ -> failwith "Not a valid token for s"

and l xs =
    match xs with
        | [] -> failwith "premature end of data"
        | END::xs -> xs
        | SEMICOLON::xs -> xs |> s |> l
        | _ -> printf "%A" (List.head xs)
               failwith "Not a valid token for l %A"

let test program =
    let result = program |> s
    match result with 
    | [] -> failwith "Early termination or missing EOF"
    | x::xs -> if x = EOF then accept else error

printf "%A" (test [IF;ID;THEN;BEGIN;PRINT;ID;SEMICOLON;PRINT;ID;END;ELSE;PRINT;ID;EOF])
    
printf "%A" (test [IF;ID;THEN;IF;ID;THEN;PRINT;ID;ELSE;PRINT;ID;ELSE;BEGIN;PRINT;ID;END;EOF])
    
//shouldn't work
printf "%A" (test [IF;ID;THEN;BEGIN;PRINT;ID;SEMICOLON;PRINT;ID;SEMICOLON;END;ELSE;PRINT;ID;EOF])