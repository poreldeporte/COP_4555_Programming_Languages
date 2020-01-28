// Problem 23

// definition of the function
let rec powerset = function

   // if the list is empty then return empty list
   | [] -> [[]]

   // if the list is not empty, break the list into the subsets and call the function recursively to find all the possible subsets
   | (l::l1) -> let l11 = powerset l1
				List.map (fun l1' -> l::l1') l11 @ l11

// calling powerset and storing in powset
let powset = powerset [1;2;3]

// print the powerset
printfn "%A" powset;;