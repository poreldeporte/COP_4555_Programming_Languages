// Problem 27

E -> E+T | E-T | T

T -> T*Y | T/Y | Y

Y -> F^Y | F

F -> i | (E)

// In this way, your grammar works as expected with an expression like :
// 1) i+i^i*i
// 2) p+q^r^s^t*u