[<Measure>] type s
[<Measure>] type ms
[<Measure>] type µs
[<Measure>] type ns

let sinms = 0.001<s/ms>
let sinµs = 0.000001<s/µs>
let sinns = 0.000000001<s/ns>

let constoms (x : float<s>) = (x / sinms)
//Type:(x:float<s> -> float<ms>)
let constoµs (x : float<s>) = (x / sinµs)
//Type:(x:float<s> -> float<µs>)
let constons (x : float<s>) = (x / sinns)
//Type:(x:float<s> -> float<ns>)
