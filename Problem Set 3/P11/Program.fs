let fib n =
    let fp = ref 0
    let f = ref 1
    let temp = ref 0
    let cnt = ref 2
    if (n <= 1) then 
        f := n
    else 
        while (!cnt <= n) do
            temp := !f
            f := !f + !fp
            fp := !temp
            cnt := !cnt + 1
    !f

let test = fib 4
printf "%A" test