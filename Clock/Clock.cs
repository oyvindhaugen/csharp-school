class Clock
{
    //here it declares the second, minute and hour variables
    private int second;
    private int minute;
    private int hour;
    //here it initalizes the object once for no parameters and once for parameters
    public Clock()
    {
        second = 0;
        minute = 0;
        hour = 0;
    }

    public Clock(int clSecond, int clMinute, int clHour)
    {
        second = clSecond;
        minute = clMinute;
        hour = clHour;
    }

    //here it sets the second
    public void setSecond(int newSecond)
    {
        if (newSecond > 60 || newSecond < 0)
        {
            throw new Exception("Dette er ikke en gyldig verdi for second.");
        }
        second = newSecond;
    }

    //here it gets the second
    public int getSecond() => second;
    //here it adds the second
    public void addSecond(int amountSecond)
    {
        second += amountSecond;
        while (second > 59)
        {
            second -= 60;
            addMinute(1);
        }
    }
    //here it sets the minute
    public void setMinute(int newMinute)
    {
        if (newMinute > 60 || newMinute > 0)
        {
            throw new Exception("Dette er ikke en gyldig verdi for minutt.");
        }
        minute = newMinute;
    }

    //here it gets the minute
    public int getMinute() => minute;
    //here it adds the minute
    public void addMinute(int amountMinute)
    {
        minute += amountMinute;
        while (minute > 59)
        {
            minute -= 60;
            addHour(1);
        }
    }
    //here it sets the hour
    public void setHour(int newHour)
    {
        if (newHour > 24 || newHour < 0)
        {
            throw new Exception("Dette er ikke en gyldig verdi for time.");
        }
        hour = newHour;
    }
    //here it gets the hour
    public int getHour() => hour;
    //here it adds the hour
    public void addHour(int amountHour)
    {
        hour += amountHour;
        while (hour > 23)
        {
            hour -= 1;
        }
    }
    //here it adds a second
    public void tick()
    {
        addSecond(1);
    }
    //here it adds a 0 to the time output
    private string numToString(int tall)
    {
        if (tall < 10)
        {
            return "0" + tall;
        }
        return Convert.ToString(tall);
    }
    //here it returns the time as a string
    public override string ToString()
    {
        return numToString(hour) + ":" +
                numToString(minute) + ":" +
                numToString(second);
    }
}