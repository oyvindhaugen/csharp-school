
Console.WriteLine("Enter current second: ");
string? usrSecond = Console.ReadLine();
Console.WriteLine("Enter current minute: ");
string? usrMinute = Console.ReadLine();
Console.WriteLine("Enter current hour: ");
string? usrHour = Console.ReadLine();
Clock clock = new Clock(Convert.ToInt32(usrSecond), Convert.ToInt32(usrMinute), Convert.ToInt32(usrHour));
Console.WriteLine("Index: \nExit: 0\nPrint hour: 1\nPrint minute: 2\nPrint second: 3\nSet hour: 4\nSet minute: 5\nSet second: 6\nAdd hour: 7\nAdd minute: 8\nAdd second: 9");
while (true)
{
    string? usrInput = Console.ReadLine();
    if (Convert.ToInt32(usrInput) == 0)
    {
        Environment.Exit(0);
    }
    else if (Convert.ToInt32(usrInput) == 1)
    {
        Console.WriteLine(clock.getHour());
    }
    else if (Convert.ToInt32(usrInput) == 2)
    {
        Console.WriteLine(clock.getMinute());
    }
    else if (Convert.ToInt32(usrInput) == 3)
    {
        Console.WriteLine(clock.getSecond());
    }
    else if (Convert.ToInt32(usrInput) == 4)
    {
        Console.WriteLine("Enter hour you wish to set it to: ");
        usrInput = Console.ReadLine();
        clock.setHour(Convert.ToInt32(usrInput));
        Console.WriteLine($"Hour is now set to: {clock.getHour()}");
    }
    else if (Convert.ToInt32(usrInput) == 5)
    {
        Console.WriteLine("Enter minute you wish to set it to: ");
        usrInput = Console.ReadLine();
        clock.setMinute(Convert.ToInt32(usrInput));
        Console.WriteLine($"Minute is now set to: {clock.getMinute()}");
    }
    else if (Convert.ToInt32(usrInput) == 6)
    {
        Console.WriteLine("Enter second you wish to set it to: ");
        usrInput = Console.ReadLine();
        clock.setSecond(Convert.ToInt32(usrInput));
        Console.WriteLine($"Second is now set to: {clock.getSecond()}");
    }
    else if (Convert.ToInt32(usrInput) == 7)
    {
        Console.WriteLine("Enter amount of hours you want to add: ");
        usrInput = Console.ReadLine();
        clock.addHour(Convert.ToInt32(usrInput));
        Console.WriteLine($"Hour is now set to: {clock.getHour()}");
    }
    else if (Convert.ToInt32(usrInput) == 8)
    {
        Console.WriteLine("Enter amount of minutes you want to add: ");
        usrInput = Console.ReadLine();
        clock.addMinute(Convert.ToInt32(usrInput));
        Console.WriteLine($"Minute is now set to: {clock.getMinute()}");
    }
    else if (Convert.ToInt32(usrInput) == 9)
    {
        Console.WriteLine("Enter amount of seconds you want to add: ");
        usrInput = Console.ReadLine();
        clock.addSecond(Convert.ToInt32(usrInput));
        Console.WriteLine($"Second is now set to: {clock.getSecond()}");
    }
    else
    {
        Console.WriteLine("Not a valid operation, please try again.");
    }
}
