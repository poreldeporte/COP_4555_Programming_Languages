(*

E(x) = int* var            
----------------- (ID)      
E |- x : int* var           
----------------- (R-VAL)   
E |- x : int*               
----------------- (L-VAL)   
E |- *x : int var 

E |- *x : int var           E |- 7 : int
--------------------------------------------- (ASSIGN)
E |- *x =  7 : int
*)