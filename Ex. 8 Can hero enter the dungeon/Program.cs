Console.WriteLine("How much lifepoints does hero have?");
int lifepoints = int.Parse(Console.ReadLine()!);

Console.WriteLine("Does hero have a key? true/false");
bool key = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Does hero know a password? true/false");
bool password = bool.Parse(Console.ReadLine()!);

if (lifepoints <= 0)
{
    Console.WriteLine("Hero cannot enter dungeon, because they are dead");
} else if (lifepoints > 0 && (key || password))
{
    Console.WriteLine("Hero can enter the dungeon");
} else
{
    Console.WriteLine("Hero cannot enter the dungeon, because they can't open the doors");
}