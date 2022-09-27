// This is a comment to my code

//rakendus palub kasutajal sisestada tema nime
//rakenus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //output
//string - sõne
string userName = Console.ReadLine(); //input

Console.WriteLine("Hello, " + userName + "!"); //output

//string interpolation
Console.WriteLine($"Hello, {userName}!"); //output