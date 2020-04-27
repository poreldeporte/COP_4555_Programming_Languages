[<Measure>] type ft
[<Measure>] type inches
[<Measure>] type cm

let ininft = 12.0<inches/ft>
let inincm = 0.393701<inches/cm>

let coninchestoft (x : float<inches>) = (x / ininft)
//Type:(x:float<inches> -> float<ft>)
let coninchestocm (x : float<inches>) = (x / inincm)
//Type:(x:float<inches> -> float<cm>)

let confttoinches (x : float<ft>) = (x * ininft)
//Type:(x:float<ft> -> float<inches>)
let concmtoinches (x : float<cm>) = (x * inincm)
//Type:(x:float<cm> -> float<inches>)

//Convert 5.5 feet to inches and then to centimeters.
let x = confttoinches 5.5<ft> |> coninchestocm
printf "%A\n" x

