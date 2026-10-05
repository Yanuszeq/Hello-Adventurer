Console.WriteLine("Podaj swoje imię: ");
string imie = Console.ReadLine();
Console.WriteLine($"Cześć, {imie}!");
int HP = 100;
int mana = 50;
int złoto = 3;
double exp = 6.66; 
Console.WriteLine("+===============================+");
Console.WriteLine("|       Hello, Adwenturer       |");
Console.WriteLine("+===============================+");
Console.WriteLine($"|Imię: {imie}\t\t\t|");
Console.WriteLine("+===============================+");
Console.WriteLine($"|♥ HP: {HP}\t\t\t|");
Console.WriteLine($"|● Mana: {mana}\t\t\t|");
Console.WriteLine($"|◆ Złoto: {złoto}\t\t\t|");
Console.WriteLine($"|⚔ Exp: {exp}\t\t\t|");
Console.WriteLine($"|Wymagany exp: {100 - exp}\t\t|");
Console.WriteLine("+===============================+");
//działa