using NewChallengeApp;

Console.WriteLine("Welcome to the 'BEST WORKER' employee evaluation program.");
Console.WriteLine("=========================================================");
Console.WriteLine();
Console.WriteLine("WORKER RATINGS:");
Console.WriteLine();
Console.WriteLine("A - salary increase and chance for advancement");
Console.WriteLine("B - solary increase");
Console.WriteLine("C - standard worker");
Console.WriteLine("D - weak worker without bonus");
Console.WriteLine("E - employee to fired");
Console.WriteLine();
Console.WriteLine("=========================================================");

var employee = new Employee("Karol", "Sikora", 'M', 36);

while (true)
{
    Console.WriteLine("Add employee rating: ");
    var input = Console.ReadLine();
    if(input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine("Exception catched: " + e.Message);
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Number of correct ratings: {statistics.QuantityOfGrades}");
Console.WriteLine($"Average:                   {statistics.Average:N2}");
Console.WriteLine($"Min:                       {statistics.Min}");
Console.WriteLine($"Max:                       {statistics.Max}");
Console.WriteLine($"Your Letter Rating:        {statistics.AverageLetter}");