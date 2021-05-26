program aasdasd;
uses crt;
var s:string;
    n,i:integer;
begin
writeln ('Введите строку;');
read(s);
n:=length(s);
for i:=1 to n do
if s[i] in ['a'..'z','а'..'я'] then s[i]:=chr(ord(s[i])-32)
else if s[i]='ё' then s[i]:='Ё';
write(s);
end.