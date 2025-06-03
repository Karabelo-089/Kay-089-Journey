// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Congratulations!");
Console.Write("");
Console.Write("You wrote your first lines of code.");
Console.WriteLine();
Console.WriteLine('b');
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);
Console.WriteLine(true);
Console.WriteLine(false);
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;
// learning Character escape sequence 
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
// format output using character escape sequence
Console.WriteLine("Generating invoices for customer \"Contoso Corp\"...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
//Learning Verbatim string litral
Console.WriteLine(@"    c:\source\repos
(this is where your code goes)");
//Learning Unicode escape characters
//Console.WriteLine(@"    c:\source\repos
//(this is where your code goes)");
Console.WriteLine(@"c:\invoices");
//Learning Unicode escape characters(use the \u escape sequence)
// Kon'nichiwa World(UTF-16)
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// To generate Japanese invoices:
// Nihon no seikyu-sho o seisei suru ni wa:
Console.WriteLine("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");