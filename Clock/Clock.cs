class Clock
    {
        private int second;
        private int minute;
        private int hour;

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

        public void setSecond(int newSecond)
        {
            if (newSecond > 60 || newSecond < 0)
            {
                throw new Exception("Dette er ikke en gyldig verdi for second.");
            }
            second = newSecond;
        }

        public int getSecond() => second;

        public void addSecond(int amountSecond)
        {
            second += amountSecond;
            while (second > 59)
            {
                second -= 60;
                addMinute(1);
            }
        }

        public void setMinute(int newMinute)
        {
            if (newMinute > 60 || newMinute > 0)
            {
                throw new Exception("Dette er ikke en gyldig verdi for minutt.");
            }
            minute = newMinute;
        }

        public int getMinute() => minute;

        public void addMinute(int amountMinute)
        {
            minute += amountMinute;
            while (minute > 59)
            {
                minute -= 60;
                addHour(1);
            }
        }

        public void setHour(int newHour)
        {
            if (newHour > 24 || newHour < 0)
            {
                throw new Exception("Dette er ikke en gyldig verdi for time.");
            }
            hour = newHour;
        }

        public int getHour() => hour;

        public void addHour(int amountHour)
        {
            hour += amountHour;
            while (hour > 23)
            {
                hour -= 1;
            }
        }

        public void tick()
        {
            second++;
        }

        private string numToString(int tall)
        {
            if (tall < 10)
            {
                return "0" + tall;
            }
            return Convert.ToString(tall);
        }

        public override string ToString()
        {
            return numToString(hour) + ":" + 
                    numToString(minute) + ":" + 
                    numToString(second);
        }
    }
