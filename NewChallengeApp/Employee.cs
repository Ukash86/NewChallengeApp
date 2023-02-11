class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int[] Ratings { get; set; }

    public Employee(string name, string surname, int age, int[] ratings)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Ratings = ratings;
    }
}