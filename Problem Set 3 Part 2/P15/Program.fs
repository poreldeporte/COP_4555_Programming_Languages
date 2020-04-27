let thrice f = f << f << f

let twice f = f << f

let successor n = n+1

let test = thrice twice successor 0

printf "%A" test

(*
Value of twice thrice successor 0 will be 9
1+1+1=3 ; 3+3+3=9

Value of thrice twice successor 0 will be 8
1+1=2 ; 2+2=4 ; 4+4=8
*)