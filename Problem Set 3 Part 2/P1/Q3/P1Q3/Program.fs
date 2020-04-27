type TERMINAL = IF|THEN|ELSE|BEGIN|END|PRINT|SEMICOLON|ID|EOF

let accept = "Compiled successfully"

let error = "Compiled unsuccessfully"

let eat terminal = function
| [] -> failwith "Empty token on eat"
| x::xs -> if x = terminal then xs else failwith "Not a valid token for eat"

let e = eat ID

