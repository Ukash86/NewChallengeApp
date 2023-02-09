long numbers = 7666689993322173223;
char[] chars = numbers.ToString().ToCharArray();
string digits = "0123456789";

Console.WriteLine("Wynik dla liczby 7666689993322173223");
Console.WriteLine();

foreach (char digit in digits)
{
    var times = 0;
        foreach (var number in chars)
    {
        if (number == digit)
            times++;
    }
    Console.WriteLine(digit + " => " + times);
}

//int number = 993692331;
//char[] numbers = number.ToString().ToArray();
//string digits = "0123456789";

//foreach (var digit in digits)
//{
//    var times = 0;
//    foreach (var numberinnumbers in numbers)
//    {
//        if (numberinnumbers == digit)
//            times++;
//    }
//    Console.WriteLine(digit + " => " + times);
//}