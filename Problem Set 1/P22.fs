// Problem 22

// the cartesian function uses the List.map function to create the list pairs 
let rec cartesian (xs, ys) =
	match (xs, ys) with
	| (_, []) -> []
	| ([], _) -> []
	// the list pairs that represents the Cartesian product
	| (x::xs, _) -> (List.map (fun y -> (x,y)) ys)@cartesian (xs, ys)
