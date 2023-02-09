int number = 993692331;
char[] numbers = number.ToString().ToArray();
string digits = "0123456789";

foreach (var digit in digits)
{
    var times = 0;
    foreach (var numberInNumbers in numbers)
    {
        if (numberInNumbers == digit)
            times++;
    }
    Console.WriteLine(digit + " => " + times);
}