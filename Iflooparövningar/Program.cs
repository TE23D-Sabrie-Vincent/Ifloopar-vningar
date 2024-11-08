// if (6>3)
// {
// Console.WriteLine("Hello, World!");
// }

using System.ComponentModel;

System.Console.WriteLine("What is your username???");
string name = Console.ReadLine();
string password = Console.ReadLine();
if (name == "kalleanka")
{
    System.Console.WriteLine("What is the password??");
    if (password == "12345")
    {
        System.Console.WriteLine($"Welcome {name}!");
    }
}
else {
 System.Console.WriteLine("Wrong username or password");
}

Console.ReadLine();