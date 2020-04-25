(*
fun f -> f (f 17.3)

Step 1: 'a -> 'b
Step 2: ('c -> 'd) -> 'b
Step 3: (float -> 'd) -> b
Step 4: (float -> float) -> 'b
Step 5: (float -> float) -> float 
*)