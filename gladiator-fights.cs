Random rand = new Random();
float health1 = rand.Next(80, 100);
int damage1 = rand.Next(5, 70);
int armor1 = rand.Next(30, 65);

float health2 = rand.Next(80, 150);
int damage2 = rand.Next(5, 40);
int armor2 = rand.Next(30, 100);

Console.WriteLine("[!] ХАРАКТЕРИСТИКИ:");
Console.WriteLine($"   - Гладиатор 1 - {health1} ХП {damage1} Урон {armor1} Броня");
Console.WriteLine($"   - Гладиатор 2 - {health2} ХП {damage2} Урон {armor2} Броня");
Console.WriteLine("[!] Нажмите на [F] что бы нажать бой.");
Console.WriteLine("");
Console.ReadKey();

while (health1 > 0 && health2 > 0)
{
    health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
    health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;
    Thread.Sleep(350);
    Console.WriteLine("Здоровье гладиатора 1: " + health1);
    Thread.Sleep(350);
    Console.WriteLine("Здоровье гладиатора 2: " + health2);
}

if (health1 <= 0 && health2 <= 0)
{
    Console.WriteLine("[-] Ничья!");
    Console.WriteLine("    Оба гладиатора повержены.");
}
else if (health1 <= 0) 
{
    Console.WriteLine("Первый гладиатор пал!");
} 
else if (health2 <= 0) 
{
    Console.WriteLine("Первый гладиатор пал!");
}
