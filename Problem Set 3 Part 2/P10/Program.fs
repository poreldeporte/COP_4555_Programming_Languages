let seqInf =
    Seq.initInfinite (fun index ->
        let n = float (index + 1)
        1.0 / (3.0*n))

printfn "%A" seqInf