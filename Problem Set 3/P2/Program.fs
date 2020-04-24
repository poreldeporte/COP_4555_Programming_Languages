(*
a.  Describe the strings that the CFG recognizes.
The grammar recognizes binary strings, since they only have 0s and 1s.

b.  This language is ambiguous. Find a string that is recognized by this grammar which has two derivations.
001101

c.  Show the two derivation trees for the string in part (b).
        S                                       S
       / \                                     / \
      0   A                                   0   A
        / | \                                   / | \
       0  A  A                                 0  A  A
         / \  \                                   |  |
        1   S  \                                  1  | 
           / \  \                                   / \
          1   B  \                                 1   S
              |   \                                   / \
              0    1                                 0   A
                                                         |
                                                         1
*)