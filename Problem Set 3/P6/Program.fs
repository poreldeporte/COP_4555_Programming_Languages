let seqInfinite =
    Seq.initInfinite (fun index ->
        let n = float (index + 1)
        1.0 / (2.0**n * (if ((index + 1) % 2 = 0) then -1.0 else 1.0)))

printfn "%A" seqInfinite

let seq5to15 = 
    Seq.init 11 (fun index -> 1.0 / (2.0**(float(index) + 5.0)* (if ((index + 1) % 2 = 0) then -1.0 else 1.0)))
Seq.iter (fun elem -> printf "%f " elem) seq5to15