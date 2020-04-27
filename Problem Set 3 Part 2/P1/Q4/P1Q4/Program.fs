type TERMINAL = ID|EOF|ADD|SUB|MUL|RPAREN|LPAREN|DIV

let accept = "Compiled successfully"

let error = "Compiled unsuccessfully"

let advance t = List.tail t

