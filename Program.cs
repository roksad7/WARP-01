// Console.Write("Hello,");
// Console.Write(" World!");
// Console.WriteLine("Hello, World!");

// Console.Write("Jestem Roksana");
// Console.WriteLine(":D ");
// Console.Write(" Studiuje informatyke zaocznie");

// Console.WriteLine("Na studiach chciałabym nauczyć się programowania ");

// int a = 6;
// float b = 6.5f;
// double c = 3.3d;

// char e = 'a';

// string d = "roksana";

// Console.WriteLine("Podaj swoje imię ");
// d = Console.ReadLine();
// Console.WriteLine($"Imię: {d}");

// string k = "czarny";
// Console.WriteLine("Podaj swój ulubiony kolor ");
// k = Console.ReadLine();
// Console.WriteLine($"kolor: {k}");
// Console.Write("podaj wiek: ");
// string wiekString = Console.ReadLine()!;
// Console.Write(" Twój wiek: "+wiekString);
// // Console.Write("Twoj wiek za rok"+wiekString+1);
// int wiekInt= int.Parse(wiekString);
// Console.Write(" Twoj wiek za rok "+(wiekInt+1));
// Console.Write(" Twoj wiek za pięć lat "+(wiekInt+5));

// Console.Write("Liczba kilometrów do celu: ");
// int length = int.Parse(Console.ReadLine());
// Console.Write("Liczba kilometrów pokonywanych każdego dnia: ");
// int speed = int.Parse(Console.ReadLine());
// Console.WriteLine($"Podróż bedzie trwać: {length/speed} dni ");

//     Console.Write("Ile zlotych");
//     int  z = int.Parse(Console.ReadLine()!);
//      Console.Write("Ile srebnych");
//     int  s = int.Parse(Console.ReadLine()!);
//      Console.Write("Ile miedzianych");
//     int  m = int.Parse(Console.ReadLine()!);
//   Console.WriteLine($"łącznie: {(z*100)+(s*10)+(m*1)} miedziaków");

// Console.Write("Podaj liczbę miksur");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Lista: {(m*3)} kryształów {(m*2)} ziół");
string b = "Bohater 1";
Console.WriteLine("Nazwa bohatera");
b = (Console.ReadLine());

Console.Write("Nazwa krainy");
string k = Console.ReadLine()!;

Console.Write("Liczba dni");
int d = int.Parse(Console.ReadLine()!);

Console.Write("Liczba zdobytych punktów doświadczenia");
int p = int.Parse(Console.ReadLine()!);
// double pString= double.Parse(pString);

Console.Write("Liczba złota");
int z = int.Parse(Console.ReadLine()!);
double sredniaP = (double)p/d;
double sredniaZ = (double)z/d;
Console.WriteLine($"DZIENNIK:  Bohater {b}, Kraina {k}, Liczba dni: {d} Średnia zdobytych punktów za jeden dzień {sredniaP} Średnia zdobytego złota za jeden dzień {sredniaZ}  ");

