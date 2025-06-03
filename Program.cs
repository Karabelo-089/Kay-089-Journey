// See https://aka.ms/new-console-template for more information
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434:";
Console.WriteLine("View English output:");
Console.Write("\t");
Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");
Console.Write("\n");
Console.WriteLine(russianMessage);
Console.Write("\t");
Console.WriteLine($@"c:\Exercise\{projectName}\ru-RU\data.txt");
// Another of completing this challenge using only two instructions
string projectName1 = "ACME";
string englishLocation = $@"c:\Exercise\{projectName1}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage1 = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName1}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage1}:\n\t\t{russianLocation}\n");
