using RegexUC6;

Pattern p = new Pattern();
Console.WriteLine("Enter Pattern");
string password = Console.ReadLine();
bool value = p.Validiate(password);
if (value)
{
    Console.WriteLine("Pattern is Matched");
}
else
{
    Console.WriteLine("Pattern is not Matched");
}