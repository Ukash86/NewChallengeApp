string name = "Lukasz";
char sex = 'M';
int age = 33;

if (sex != 'M')
{
    Console.WriteLine("to jest kobieta");
}
else if (sex == 'M')
{
    Console.WriteLine("to jest mężczyzna");
    if (name == "Lukasz")
    {
        Console.WriteLine("to jest mężczyzna o imieniu " + name);
        if (age == 33)
        {
            Console.WriteLine("to jest mężczyzna o imieniu " + name + " który ma " + age + " lat.");
        }
    }
}
else
{
    Console.WriteLine("nie wiadomo kto to");
}
