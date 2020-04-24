let rec iltr list xs ys =
    match xs, ys with  
    |[], [] -> list
    |x::xs, y::ys -> let newlist = list @ [x;y]
                     iltr newlist xs ys