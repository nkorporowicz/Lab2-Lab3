string name = "Yen";
char symbol = '*';
int level = 7;
int gold = 213;
double weight = 43.5;
bool hasMap = true;    

Console.WriteLine("===CHARACTER CARD===");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Symbol: {symbol}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Gold: {gold}");
Console.WriteLine($"Weight: {weight}");
Console.WriteLine($"Has Map: {hasMap}");

gold = gold + 50;
level += 1;

Console.WriteLine("\n===UPDATED CHARACTER CARD===");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Symbol: {symbol}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Gold: {gold}");
Console.WriteLine($"Weight: {weight}");
Console.WriteLine($"Has Map: {hasMap}");