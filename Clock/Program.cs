//Here I get the time parameters for Clock
Console.WriteLine("Enter current second: ");
string? usrSecond = Console.ReadLine();
Console.WriteLine("Enter current minute: ");
string? usrMinute = Console.ReadLine();
Console.WriteLine("Enter current hour: ");
string? usrHour = Console.ReadLine();
Console.Clear();
//Here I initialize clock as a new Clock() object
Clock clock = new Clock(Convert.ToInt32(usrSecond), Convert.ToInt32(usrMinute), Convert.ToInt32(usrHour));
Console.WriteLine("Index: \nExit: 0\nPrint hour: 1\nPrint minute: 2\nPrint second: 3\nPrint time: 4\nSet hour: 5\nSet minute: 6\nSet second: 7\nAdd hour(s): 8\nAdd minute(s): 9\nAdd second(s): 10\nTick: 11\n");
//Here is a while loop that just keeps going until exited, which listens for commands in console
while (true)
{
    string? usrInput = Console.ReadLine();
    //Here it checks the input and if it matches any of the cases it executes the code within that case, if not, it defaults to an error message
    switch (usrInput)
    {
        case "0":
            Environment.Exit(0);
            break;
        case "1":
        //prints currnet amount of hours on the clock
            Console.WriteLine(clock.getHour() + " hour(s)");
            break;
        case "2":
        //prints current amount of minutes on the clock
            Console.WriteLine(clock.getMinute() + " minute(s)");
            break;
        case "3":
        //prints current amount of seconds on the clock
            Console.WriteLine(clock.getSecond() + " second(s)");
            break;
        case "5":
        //here it accepts user input to set hour
            Console.WriteLine("Enter hour you wish to set it to: ");
            usrInput = Console.ReadLine();
            clock.setHour(Convert.ToInt32(usrInput));
            Console.WriteLine($"Hour is now set to: {clock.getHour()}");
            break;
        case "6":
                //here it accepts user input to set minute
            Console.WriteLine("Enter minute you wish to set it to: ");
            usrInput = Console.ReadLine();
            clock.setMinute(Convert.ToInt32(usrInput));
            Console.WriteLine($"Minute is now set to: {clock.getMinute()}");
            break;
        case "7":
                //here it accepts user input to set second
            Console.WriteLine("Enter second you wish to set it to: ");
            usrInput = Console.ReadLine();
            clock.setSecond(Convert.ToInt32(usrInput));
            Console.WriteLine($"Second is now set to: {clock.getSecond()}");
            break;
        case "8":
        //here it accepts user input to add to hour
            Console.WriteLine("Enter amount of hours you want to add: ");
            usrInput = Console.ReadLine();
            clock.addHour(Convert.ToInt32(usrInput));
            Console.WriteLine($"Hour is now set to: {clock.getHour()}");
            break;
        case "9":
        //here it accepts user input to add to minute
            Console.WriteLine("Enter amount of minutes you want to add: ");
            usrInput = Console.ReadLine();
            clock.addMinute(Convert.ToInt32(usrInput));
            Console.WriteLine($"Minute is now set to: {clock.getMinute()}");
            break;
        case "10":
        //here it accepts user input to add to second
            Console.WriteLine("Enter amount of seconds you want to add: ");
            usrInput = Console.ReadLine();
            clock.addSecond(Convert.ToInt32(usrInput));
            Console.WriteLine($"Second is now set to: {clock.getSecond()}");
            break;
        case "4":
        //Here it prints the time
            Console.WriteLine(clock.ToString());
            break;
        case "11":
        //Here it adds 1 second to the seconds
            clock.tick();
            Console.WriteLine("1 second has now been added");
            break;
        default:
        //here it prints the error message
            Console.WriteLine("Not a valid operation, please try again.");
            break;
    }
}