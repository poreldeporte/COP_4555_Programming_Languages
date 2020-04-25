let rec interp = function
|NUM n -> NUM n       
|BOOL true -> BOOL true  
|BOOL false -> BOOL false 
|SUCC -> SUCC      
|PRED -> PRED      
|ISZERO -> ISZERO
|ERROR s-> ERROR s  

