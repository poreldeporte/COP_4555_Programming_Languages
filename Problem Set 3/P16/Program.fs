let rec interp = function
|NUM n -> NUM n       
|BOOL true -> BOOL true  
|BOOL false -> BOOL false 
|SUCC -> SUCC      
|PRED -> PRED      
|ISZERO -> ISZERO
|ERROR s-> ERROR s  
| APP (e1, e2) ->
    match (interp e1, interp e2) with
    | (ERROR s, _)  -> ERROR s       
    | (_, ERROR s)  -> ERROR s
    | (SUCC, NUM n) -> NUM (n+1)       
    | (SUCC, v)     -> ERROR (sprintf "'succ' needs int argument, not '%A'" v)
    | (PRED, NUM 0) -> NUM 0         
    | (PRED, NUM n) -> NUM (n-1)     
    | (PRED, v) ->  ERROR (sprintf "pred needs an int arg, not %A" v)
    | (ISZERO, NUM 0) -> BOOL true    
    | (ISZERO, NUM n) -> BOOL false    
    | (ISZERO, v) ->  ERROR (sprintf "iszero needs an int arg, not %A" v) 
|IF (b, e1, e2) ->  
  match (interp b) with
  | (BOOL true) -> interp e1   
  | (BOOL false)-> interp e2   
  | (v) -> ERROR (sprintf "if statement has to have boolean, not %A" v)

let rec subst exp str term =
    match exp with  
    |ID s when s = str -> term 
    |ID s -> ID s
    |NUM n -> NUM n
    |BOOL b -> BOOL b
    |SUCC -> SUCC
    |PRED -> PRED
    |ISZERO -> ISZERO
    |IF(c, e1, e2) ->
        IF(subst c str term, subst e1 str term, subst e2 str term)
    |APP(e1,e2) -> APP(subst e1 str term, subst e2 str term)
    |FUN(x, body) when x = str -> FUN(x, body)
    |FUN(x, body) -> FUN(x, subst body str term)
