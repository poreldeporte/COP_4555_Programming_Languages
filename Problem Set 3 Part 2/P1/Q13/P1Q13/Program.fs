﻿type TERMINAL = IF|THEN|ELSE|BEGIN|END|PRINT|SEMICOLON|ID|EOF

type 'a tree =
    | Lf
    | Br of ('a * 'a tree * 'a tree)
    | Br_IF of ('a tree * 'a tree * 'a tree)
    | Br_BEGIN of ('a tree * 'a tree)
    | Br_PRINT of ('a tree)
    | Br_END of ('a tree)
    | Br_SEMICOLON of ('a tree * 'a tree)
    | Br_ID of ('a tree)

let eat terminal = function 
| [] -> failwith "SYNTAX ERROR: Empty token on EAT"
| x::xs -> if x = terminal then xs else failwith "SYNTAX ERROR: No matching token"