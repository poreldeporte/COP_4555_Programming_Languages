type Record = {GPA : unit -> float; addGradept : float -> unit; addCredit : float -> unit}

let student =
    let credithr = ref 0.0
    let gradept = ref 0.0
    {GPA = fun () -> (!gradept * 3.0 / !credithr);
     addGradept = fun d -> gradept := d + !gradept;
     addCredit = fun d -> credithr := d + !credithr} 

student.addCredit(3.0)
student.addGradept(4.0)

printf "%A" (student.GPA())