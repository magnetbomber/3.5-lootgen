// See https://aka.ms/new-console-template for more information

using LootGenerator_Three_Five;

Console.WriteLine("Please enter a CR:");
double cr = Convert.ToDouble(Console.ReadLine());
Hoard myHoard = new Hoard(cr);
Console.WriteLine(myHoard.ToString());