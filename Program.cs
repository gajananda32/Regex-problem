//creating object 
//taking input from user
using RegexUC2;

Pattern p = new Pattern();
Console.WriteLine("Enter the pattern ");
string LastName = Console.ReadLine();
bool value = p.validatePincode(LastName);
if (value)
{
    Console.WriteLine("Pattern is matched ");
}
else
{
    Console.WriteLine("Pattern is not matched ");
}