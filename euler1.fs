: multiple? ( n1 n2 -- f )
  mod 0= ;

: 3multiple? ( n -- f )
  3 multiple? ;

: 5multiple? ( n -- f )
  5 multiple? ;

: euler1
  0
  1000 0 do
    i 3multiple? i 5multiple? or if
      i +
    then
  loop ;

cr euler1 . cr