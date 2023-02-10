using NewChallengeApp;
User user1 = new User("Lukasz", "qwerty");
User user2 = new User("Daria", "qwerty");
User user3 = new User("Kacper", "qwerty");
User user4 = new User("Dawid", "qwerty");

user1.AddScore(5);
user1.AddScore(5);
user1.AddScore(5);
var result = user1.Result;
Console.WriteLine(result);