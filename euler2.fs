: even?
  2 mod 0= ;

: fibonacci
  swap over + ;

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
  drop drop ;

cr euler2 cr
