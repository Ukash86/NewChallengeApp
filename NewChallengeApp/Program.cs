long numbers = 7647565839368881884;
string digits = "012356789";

Console.WriteLine("Wynik dla liczby 7647565839368881884:");
Console.WriteLine();

foreach (char digit in digits)
{
    var count = 0;
    foreach (var number in numbers.ToString())
    if(number == digit)
    {
        count++;
    }
    Console.WriteLine(digit + " => " + count);
}