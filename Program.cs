using RegexUC5;

Pattern p = new Pattern();
Console.WriteLine("enter the pattern");
string password= Console.ReadLine();
bool value = p.ValidateRegex(password);
if (value)
{
    Console.WriteLine("Pattern is Matched");
}
else
{
    Console.WriteLine("Pattern is Not Matched");
}