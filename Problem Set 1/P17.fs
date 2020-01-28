// Problem 17

let answer () =
	// this method in List.map reverses the list
	let revlists xs = 
		List.map List.rev xs
	revlists [[0;1;1];[3;2];[];[5]]