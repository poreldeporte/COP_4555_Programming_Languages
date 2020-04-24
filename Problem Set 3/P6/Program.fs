let seqInfinite =
    Seq.initInfinite (fun index ->
        let n = float (index + 1)
        1.0 / (2.0**n * (if ((index + 1) % 2 = 0) then -1.0 else 1.0)))

printfn "%A" seqInfinite