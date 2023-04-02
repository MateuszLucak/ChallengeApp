String name = "Ewa";
String sex = "female";
var age = 30;

if (sex == "female" && name == "Ewa" && age == 30)
{
     //Console.WriteLine("Ewa lat 30");
}
if (sex == "female" || age < 29)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
if (sex == "female" && age > 24)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}