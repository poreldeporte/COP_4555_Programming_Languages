// Problem 24

let rec transpose matrix = function
	match matrix with
	// if empty 
	| row::rows -> 	match row with   
	// if not empty
	| col::cols ->  let first = List.map List.head matrix 
					let rest = transpose (List.map List.tail matrix)
						first :: rest
						| _ -> []
						| _ -> [];;
