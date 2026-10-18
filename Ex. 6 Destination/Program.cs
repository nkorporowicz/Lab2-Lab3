Console.WriteLine("What the destination path? north/south/east/west" );
string destinationPath = Console.ReadLine()!;

switch (destinationPath)
{
    case "north":
        Console.WriteLine("You're heading to mountains.");
        break;
    case "south":
        Console.WriteLine("You're heading to the desert.");
        break;
    case "east":
        Console.WriteLine("You're heading to the forest.");
        break;
    case "west":
        Console.WriteLine("You're heading to the sea.");
        break;    
    default:
        Console.WriteLine("Invalid destination path.");
        break;
}