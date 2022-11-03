using RegexUC3;
//creating object 
//taking input from user
Pattern p = new Pattern();
Console.WriteLine("Enter the pattern ");
string Email = Console.ReadLine();
bool value = p.validatePincode(Email);
if (value)
{
    Console.WriteLine("Pattern is matched ");
}
else
{
    Console.WriteLine("Pattern is not matched ");
}