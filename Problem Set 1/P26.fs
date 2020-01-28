// Problem 26

// The mergesort function is missing a case causing the type to be 'a list -> 'b list instead of 'a list -> 'a list. This is because we are not looking to change the type of the list.

// Another problem with the code is that neither merge nor split is tail recursive. This means that it will therefore get stack overflow exceptions on large lists

// Make split and merge functions tail recursive by using the accumulator pattern
