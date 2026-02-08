var name = "Jacek";
var age = 17;
string sex = "male";

if (sex == "female" && age < 30)
{
    Console.WriteLine(("Koobieta poniżej 30 lat."));
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (age < 18 && sex == "male")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
