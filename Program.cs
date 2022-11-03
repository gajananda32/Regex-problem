//creating object 
//taking input from user
using RegexPhoneNumber;

Pattern p = new Pattern();
Console.WriteLine("Enter the pattern ");
string ph = Console.ReadLine();
bool value = p.validatePincode(ph);
if (value)
{
    Console.WriteLine("Pattern is matched ");
}
else
{
    Console.WriteLine("Pattern is not matched ");
}
