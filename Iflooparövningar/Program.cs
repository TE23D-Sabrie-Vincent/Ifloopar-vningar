// if (6>3)
// {
// Console.WriteLine("Hello, World!");
// }

// using System.ComponentModel;

// System.Console.WriteLine("What is your username???");
// string name = Console.ReadLine();
// string password = Console.ReadLine();
// if (name == "kalleanka")
// {
//     System.Console.WriteLine("What is the password??");
//     if (password == "12345")
//     {
//         System.Console.WriteLine($"Welcome {name}!");
//     }
// }
// else {
//  System.Console.WriteLine("Wrong username or password");
// }


// int i = 0;
// while (i < 32){
//    System.Console.WriteLine("Hello World");
//    i++;
// }
// // while loop

// for (int i=0; i < 32; i++ ){
//     System.Console.WriteLine("Hello World!");
// }
// //for loop

// string password = Console.ReadLine();
// while (password != "simon"){
//     System.Console.WriteLine("Du har fel");
//     password = Console.ReadLine();
// }

for (int i = 0; i < 5; i++)
{
    string svar = Console.ReadLine();
    int num;
    bool Isanumber = int.TryParse(svar, out num);

    if (num > 5)
    {
        System.Console.WriteLine("Talet är högre än 5");
    }
}