var
  a, s: integer;

begin
  read(a);
  s := 0;
  while a > 0 do
  begin
    s := s + a mod 10;
    a := a div 10;
  end;
  writeln(s);
end.