// See https://aka.ms/new-console-template for more information

using BasicApp_Pipeline;

StartProgram sp = new();


int a = 1; int b = 2; string c = "3"; string d = "4";


Console.WriteLine("Hello, World!");


Console.WriteLine("Sum of {0}, {1} :", d, c);
sp.Sum(d,c);

Console.WriteLine("Sum of {0}, {1}, {2} :", a, b, -7);
Console.WriteLine(sp.Sum(a,b, -7));


Console.ReadLine();



