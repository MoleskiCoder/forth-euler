: even? ( n -- f )
  2 mod 0= ;

: fibonacci ( n1 n2 -- n2 next )
  tuck + ;

: euler2
  0 >r
  0 1
  begin
    fibonacci
    dup even? if
      dup r> + >r
    then
  dup 4000000 >= until
  r> .
  2drop ;

cr euler2 cr
