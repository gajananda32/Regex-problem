using RegexxUC1;
//creating object 
//taking input from user
Pattern p = new Pattern();
Console.WriteLine("Enter the pattern ");
string FirstName = Console.ReadLine();
bool value = p.validatePincode(FirstName);
if (value)
{
    Console.WriteLine("Pattern is matched ");
}
else
{
    Console.WriteLine("Pattern is not matched ");
}
