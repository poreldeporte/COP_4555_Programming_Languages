// Problem 21

let rec countaux = function
	| (deck, target) when deck = target -> 0
	| (deck, target) -> 1 + countaux ((shuffle deck), target)

let countshuffle n = countaux((shuffle [1..n]), [1..n]) + 1
