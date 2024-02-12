int usd, cent; String s;
Console.Write("Enter the koppeek: ");
s = Console.ReadLine() ?? "";
cent = int.Parse(s);
usd = cent / 100;
cent = cent % 100;
Console.WriteLine("You have " + rub + "rub, " + kopeek + "kop.");

//**12. Пример 

int km, meter;
Console.Write("Enter the metres: ");
meter = int.Parse(Console.ReadLine());
km = meter / 1000;
meter = meter % 1000;
Console.WriteLine("Distance is " + km + " km " + meter + " meter.");
