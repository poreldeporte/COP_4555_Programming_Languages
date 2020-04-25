type Stack = {Push: int -> int list; Pop: unit -> int list; Top: unit -> int; isEmpty: unit -> bool}

let stack =
    let stk = ref [2;3;4]
    {Push = fun x -> x :: (!stk); 
     Pop = fun () -> stk := List.tail (!stk); 
     Top = fun () -> List.head (!stk); 
     isEmpty = fun () -> List.isEmpty(!stk);
    }
