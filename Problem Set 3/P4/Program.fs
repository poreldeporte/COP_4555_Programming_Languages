﻿(*
({i=5; j=8}, i := 2 + j * i) => {i=42; j=8}

Answer:
({m}; i) = 5
({m}; j) = 8
({m}; 2) = 2
({m}; j * i) = 40
({m}; 2 + j * i) = 42
({m}; i = 2 + j * i) = 42    = {i=42; j=8} = m'

({i=3; j=8}, if (3*i > j) then i := 3*j else j := 3*i) => {i=24; j=8}

Answer:
({m}; i) = 3
({m}; j) = 8
({m}; 3) = 3
({m}; 3 * i) = 9
({m}; 3 * i > j) = 1
({m}; 3 * j) = 24
({m}; i = 3 * j) = 24    = {i=24; j=8} = m'

({i=1; j=10}, while (3*i <= j) do i := 3*i) => {i=9; j=10}

Answer:
({m}; i) = 1
({m}; j) = 10
({m}; 3) = 3
({m}; 3 * i) = 3
({m}; 3 * i <= j) = 1
({m}; 3 * i) = 9
({m}; i = 3 * i) = 9
({m}; 3 * i) = 27
({m}; 3*i <= j) = 0      = {i=9; j=10} = m'
*)