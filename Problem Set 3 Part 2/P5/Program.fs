(*
Perform a type derivation to prove that x = 7 is well typed.
E(p) = int var
----------------- (ID)
E |- p : int var 
----------------- (R-VAL)  
E |- p : int 
----------------- (L-VAL)
E |- *p : int* var

E |- e1 : t var   E |- e2 : t
-----------------------------
E |- e1 = e2 : t

Perform a type derivation to prove that x = x + 7 is well typed.
E(p) = int var
----------------- (ID)
E |- p : int var 
----------------- (R-VAL)  
E |- p : int 
----------------- (L-VAL)
E |- *p : int* var

E |- e1 : t var   E |- e2 : t
-----------------------------
E |- e1 = e2 : t
*)