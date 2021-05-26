var
  x:integer;
begin
 repeat
  write('x=');
  readln(x);
 until x<>0;
 if (x mod 5=0)  then writeln('Yes') else
 writeln('No');
 readln;
end.