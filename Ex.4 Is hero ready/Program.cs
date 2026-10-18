Console.WriteLine("How many lifepoint does hero have?");
int lifepoints = int.Parse(Console.ReadLine()!);

Console.WriteLine("How many potions does hero have?");
int potions = int.Parse(Console.ReadLine()!);

Console.WriteLine("Does hero have the key? (true/false)");
bool hasKey = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Does hero has the map? (true/false)");
bool hasMap = bool.Parse(Console.ReadLine()!);

bool alive = lifepoints > 0;
bool hasFullHealth = lifepoints == 100;
bool needsHealing = !hasFullHealth;
bool hasPotions = potions >= 1;
bool hasMapOrKey = hasKey || hasMap;
bool readyForAdventure = alive && hasPotions && hasMapOrKey;

Console.WriteLine($"Is hero alive? {alive}");
Console.WriteLine($"Does hero have full health? {hasFullHealth}");
Console.WriteLine($"Does hero need healing? {needsHealing}");
Console.WriteLine($"Does hero have potions? {hasPotions}");
Console.WriteLine($"Does hero have the map or the key? {hasMapOrKey}");
Console.WriteLine($"Is hero ready for adventure? {readyForAdventure}");