let seqInf =
    Seq.initInfinite (fun index ->
        let n = float (index + 1)
        1.0 / (n*n))

printfn "%A" seqInf