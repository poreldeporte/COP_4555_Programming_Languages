(*
a) subst (APP(SUCC, ID "a")) "a" (NUM 3)


b) subst (IF (BOOL true, FUN ("a", APP (SUCC, ID "a")), FUN ("b", APP (SUCC, ID "a")))) "a" (NUM 3)

*)