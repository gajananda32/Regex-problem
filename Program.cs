using RegexUC8;

Pattern p = new Pattern();
Console.WriteLine("Enter Pattern");
string password = Console.ReadLine();
bool value = p.validiate(password);
if (value)
{
    Console.WriteLine("Pattern is Matched");
}
else
{
    Console.WriteLine("Pattern is not Matched");
}

