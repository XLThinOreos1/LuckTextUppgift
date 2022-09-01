string name;
string bodyPart;
string liquid;

Console.WriteLine("What is your name?");
name = Console.ReadLine();

Console.WriteLine("Please name a body part:");
bodyPart = Console.ReadLine();

Console.WriteLine("Please name a liquid:");
liquid = Console.ReadLine();

Console.WriteLine($"{name} decided to stay home from school because their {bodyPart} hurts and has to drink {liquid} to recover from their injury");

Console.ReadLine();

