using NewChallengeApp;

Console.WriteLine("Welcome to the 'BEST WORKER' employee evaluation program.");
Console.WriteLine();
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

var employee = new Employee("Karol", "Sikora");

while (true)
{
    Console.WriteLine("Add employee rating: ");
    var input = Console.ReadLine();
    if(input == "q")
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


//Employee employee1 = new Employee("Karol ", "Sikora ", 24, new int[] { 9, 1, 3, 8, 5, });
//Employee employee2 = new Employee("Damian ", "Wągrowski ", 35, new int[] { 9, 3, 2, 5, 4 });
//Employee employee3 = new Employee("Paweł ", "Chobot ", 44, new int[] { 8, 6, 8, 7, 4 });

//var result1 = employee1.Ratings.Sum();
//var result2 = employee2.Ratings.Sum();
//var result3 = employee3.Ratings.Sum();
//int[] results = { result1, result2, result3 };
//int max = 0;

//foreach (int bestResult in results)
//{
//    if (bestResult > max)
//    {
//        max = bestResult;
//    }
//}

//Employee bestWorker = employee1;

//if (max == result2)
//{
//    bestWorker = employee2;
//}
//else if (max == result3)
//{
//    bestWorker = employee3;
//}

//Console.WriteLine("The best worker:");
//Console.WriteLine("name               -  " + bestWorker.Name);
//Console.WriteLine("surname            -  " + bestWorker.Surname);
//Console.WriteLine("age                -  " + bestWorker.Age);
//Console.WriteLine("number of ratings  -  " + bestWorker.Ratings.Length);
//Console.WriteLine("sum of ratings     -  " + max);