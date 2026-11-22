// string imie = "Mira";
// char symbol = '@';
// int poziom = 2;
// int zloto = 35;
// double waga = 7.5;
// bool mapa = true;

// Console.WriteLine($"==== Ekwipunek ==== Imię {imie}, Symbol {symbol}, Poziom {poziom}, Złoto {zloto}, Waga {waga}, Na mapę {mapa}");

// int punkty = 100;
// int zloto = 20;
// punkty += 25;
// punkty *=2;
// zloto -= 8;
// zloto += 15;
// int trening = 1;
// trening ++;
// Console.WriteLine($"Bohater: Ilosc punktów {punkty}, {zloto} szt. złota, numer treningu {trening}");

//zad 3
// Console.Write("Podaj racje żywnościowe: ");
// string racje = Console.ReadLine()!;

// Console.Write("Podaj liczbę członków drużyny: ");
// string druzyna = Console.ReadLine()!;


// Console.Write("Podaj liczbę dni wyprawy: ");
// string dni = Console.ReadLine()!;
// Console.WriteLine($"Racje żywnościowe na jednego członka:, {racje/druzyna}, racji pozostanie po równym podziale {racje%druzyna}, ");

//4
// Console.Write("Podaj punkty zycia: ");
// int zycie = int.Parse(Console.ReadLine()!);

// Console.Write("Podaj liczbe mikstur: ");
// int mikstura = int.Parse(Console.ReadLine()!);


// Console.Write("czy masz klucz: ");
// bool klucz =bool.Parse(Console.ReadLine()!);


// Console.Write("czy masz mapę: ");
// bool mapa = bool.Parse(Console.ReadLine()!);

// bool zyje = (zycie > 0);
// bool maPelneZdrowie = (zycie == 100);
// bool maZaopatrzenie = (mikstura>=1);
// bool maPrzedmiotNawigacyjny = (klucz||mapa);
// bool gotowyDoWyprawy = ((zyje==true) && (maZaopatrzenie) && (maPrzedmiotNawigacyjny));

//5
Console.Write("Podaj imię bohatera: ");
string imię  = Console.ReadLine()!;

Console.Write("Podaj maksymalne punkty życia: ");
int max = int.Parse(Console.ReadLine()!);

Console.Write("Podaj aktualne punkty życia przed walką: ");
int walka = int.Parse(Console.ReadLine()!);

Console.Write("Podaj podstawowe obrażenia broni: ");
int bron = int.Parse(Console.ReadLine()!);

Console.Write("Premia do siły: ");
int premia = int.Parse(Console.ReadLine()!);

Console.Write("Mnożnik ataku specjalnego");
int spec = int.Parse(Console.ReadLine()!);

Console.Write("Liczba wykonywanych ataków zwyklych: ");
int iloscAtakow = int.Parse(Console.ReadLine()!);

int normal = (bron + premia);
int specObr = (int)(bron * spec);
int laczne = (normal*iloscAtakow + specObr);
double pozostalo = ((double)walka/laczne*100d);
bool zyje = (walka>0);
bool maPelne = (walka==max);
