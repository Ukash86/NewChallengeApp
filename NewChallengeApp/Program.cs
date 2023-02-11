Employee employee1 = new Employee("Karol ", "Sikora ", 24, new int[] { 1, 2, 3, 4, 5 });
Employee employee2 = new Employee("Damian ", "Wągrowski ", 35, new int[] { 8, 3, 2, 5, 4 });
Employee employee3 = new Employee("Paweł ", "Chobot ", 44, new int[] { 3, 6, 2, 7, 3 });

var result1 = employee1.Ratings.Sum();
var result2 = employee2.Ratings.Sum();
var result3 = employee3.Ratings.Sum();
int[] results = { result1, result2, result3 };
int max = 0;

foreach (int bestResult in results)
{
    if (bestResult > max)
    {
        max = bestResult;
    }
}

max = result1;
Employee bestWorker = employee1;

if (max < result2)
{

    bestWorker = employee2;
}
else if (max < result3)
{
    bestWorker = employee3;
}

int sumOfRatings = 0;

foreach (int rating in bestWorker.Ratings)
{
    sumOfRatings += rating;
}

Console.WriteLine("The best worker:");
Console.WriteLine("name               -  " + bestWorker.Name);
Console.WriteLine("surname            -  " + bestWorker.Surname);
Console.WriteLine("age                -  " + bestWorker.Age);
Console.WriteLine("number of ratings  -  " + bestWorker.Ratings.Length);
Console.WriteLine("sum of ratings     -  " + max);