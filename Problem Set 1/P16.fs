// Problem 16

let answer() = 
	// defining the gcd function
	let rec gcd = function
		| (a,0) -> a
		| (a,b) -> gcd (b, a % b)

	// defining the addition (.+) operator
	let (.+)(x, y)(p, q) = 
		// performing the fraction addition 
		let a = (x*q)+(y*p) 
		let b = (y*q)

		// simplifying the result
		let c = gcd(a,b) 
		(a/b, b/c);;

	// defining the (.*) operator
	let (.*)(x, y)(p, q) =
		let a = (x*p)
		let b = (y*q)
		let c = gcd(a,b)
		(a/c, b/c);;