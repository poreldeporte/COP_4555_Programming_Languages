// Problem 19

let answer() =
	let cut xs = gencutdata((List.length xs) / 2, xs)

	// cut calls this F# function that cuts a list into two equal parts
	let rec gencutdata(n, list) =
		let rec cut n (val : int list) (list : int list) =
		match (n , list ) with
		| 0, _ -> val, list
		| _, [] -> val, list
		| _, b :: list -> cut (n - 1) (List.rev (b :: val )) list
	cut n [] list

// Call cut with the list value
cut [1;2;3;4;5;6]
