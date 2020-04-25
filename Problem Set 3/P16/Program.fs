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
    | (ERROR s, _)  -> ERROR s        // ERRORs are propagated
    | (_, ERROR s)  -> ERROR s
    | (SUCC, NUM n) -> NUM (n+1)      // Rule (6)  
    | (SUCC, v)     -> ERROR (sprintf "'succ' needs int argument, not '%A'" v)
    | (PRED, NUM 0) -> NUM 0         
    | (PRED, NUM n) -> NUM (n-1)      // Rule 7  I added rule 7 to interpreter.
    | (PRED, v) ->  ERROR (sprintf "pred needs an int arg, not %A" v)
    | (ISZERO, NUM 0) -> BOOL true    
    | (ISZERO, NUM n) -> BOOL false    
    | (ISZERO, v) ->  ERROR (sprintf "iszero needs an int arg, not %A" v) 
|IF (b, e1, e2) ->  
  match (interp b) with
  | (BOOL true) -> interp e1   // If true lazy evaluation.
  | (BOOL false)-> interp e2   // if false lazy evaluation.
  | (v) -> ERROR (sprintf "if statement has to have boolean, not %A" v)