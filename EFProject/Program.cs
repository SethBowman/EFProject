using EFProject.Data;
using EFProject.Models;


using (var context = new Testdb())
{
    //var newUser = new User("Cruz", "Sanchez");

    //context.Users.Add(newUser);

    //var existingUser = context.Users.Find(2);
    //existingUser.FirstName = "Humphrey";
    //existingUser.LastName = "Bogart";

    context.SaveChanges();

    var users = context.Users.ToList();

    users.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));
}