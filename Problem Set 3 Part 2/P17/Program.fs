[<Measure>] type ft
[<Measure>] type inches
[<Measure>] type cm

let ininft = 12.0<inches/ft>
let inincm = 0.393701<inches/cm>

let coninchestoft (x : float<inches>) = (x / ininft)
//Type:(x:float<inches> -> float<ft>)
let coninchestocm (x : float<inches>) = (x / inincm)
//Type:(x:float<inches> -> float<cm>)
