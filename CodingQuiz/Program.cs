//Here all the arrays with questions and answers are initialized
//There's an array containing the question strings, one containing the answer option strings, and one containing the number of the correct option  
string[] questions = {
    "What is a string?",
    "What is a float do?",
    "What is the difference between Console.Write() and Console.WriteLine()?",
    "What is the syntax for an array of numbers with decimals?",
    "If you want to get the first element of an array, what do you write?",
    "What does it mean when a variable has the value of null?"
    };
string[,] answers = new string[,] {
    {
        "It is a number.",
        "It is a character.",
        "It is an array of characters.", //correct
        "It is collection of letters, symbols and numbers."
    },
    {
        "A float is a number with ~6-9 decimals.", //correct
        "A float is a number with ~15-17 decimals.",
        "A float is a number with 28-29 decimals.",
        "It is an array of characters."
    },
    {
        "Console.Write is not a method in C#.",
        "Console.Write reads input from user.",
        "Console.Write does not let you change lines.",
        "Console.Write does not automatically change lines." //correct
    },
    {
        "int[].withDecimals()",
        "float().array[]",
        "float[]", //correct
        "long[]"
    },
    {
        "testArray.first",
        "testArray[0]", //correct
        "testArray[1]",
        "getFirst(testArray[])"
    },
    {
        "It means the variable has an undefined value.", //correct
        "It means the variable has a value that exceeds the limit.",
        "Null is a different way to write 0.",
        "Null does not exist."
    }
};
int[] answersIndex = {
    2,
    0,
    3,
    2,
    1,
    0
};
string ascii = @"
_________            .___.__                 ________        .__        
\_   ___ \  ____   __| _/|__| ____    ____   \_____  \  __ __|__|_______
/    \  \/ /  _ \ / __ | |  |/    \  / ___\   /  / \  \|  |  \  \___   /
\     \___(  <_> ) /_/ | |  |   |  \/ /_/  > /   \_/.  \  |  /  |/    / 
 \______  /\____/\____ | |__|___|  /\___  /  \_____\ \_/____/|__/_____ \
        \/            \/         \//_____/          \__>              \
";
//Here the intro, getting the players name and such.
Console.Clear();
//This shows some ASCII art
Console.WriteLine(ascii);
Console.WriteLine("\nWelcome to my coding quiz!");
Console.WriteLine("Please enter your name to start: ");
string playerName = Console.ReadLine();
Console.WriteLine("\nReady up " + playerName + "\nHere we go!\n");
Thread.Sleep(300);
Quiz();
//Here I make a method to do the quiz, just to keep it a bit cleaner
void Quiz()
{
    //Here the QNA class is initialized as Quiz
    QNA Quiz = new QNA();

    //Here's the loop which loops through all the questions in the questions array
    for (int QNAIncr = 0; QNAIncr < questions.Length; QNAIncr++)
    {
        //Here I clear the console each time so it's easier to read
        Console.Clear();
        //Here it sets the Question string from the QNA class to what it is in the array at this index (which it gets from QNAIncr)
        Quiz.Question = questions[QNAIncr];
        //Here it loops through to print all the options
        for (int i = 0; i < 4; i++) Quiz.Answers[i] = answers[QNAIncr, i];

        //Here it sets the answer int to what the answer is at this index in the answersIndex array.
        Quiz.Answer = answersIndex[QNAIncr];
        
        Console.WriteLine(ascii);
        Console.WriteLine("\nQuestion " + (QNAIncr + 1) + ") " + Quiz.Question + "\n");
        for (int i = 0; i < 4; i++) Console.WriteLine(i + 1 + ") " + Quiz.Answers[i]);
        //Here I initialize a string that's gonna contain what the player answers
        string playerAnswer = "";
        //Here it reads the input from the player and uses it as the answer
        playerAnswer = Console.ReadLine();
        //Here it converts the playerAnswer string to an int so it can be used to compare to the Quiz.Answer int
        //if the answer is correct it prints 'correct', waits 0.4s then increments the score and the streak
        if (Convert.ToInt32(playerAnswer) - 1 == Quiz.Answer)
        {
            Console.WriteLine("Correct!");
            Thread.Sleep(400);
            Quiz.Score++;
            Quiz.Streak++;
        }
        //if the answer is wrong it prints 'wrong', waits 0.4s then saves the streak and sets it to 0
        else
        {
            Console.WriteLine("Wrong!");
            Thread.Sleep(400);
            Quiz.OldStreak = Quiz.Streak;
            Quiz.Streak = 0;
        }
    }
    Console.Clear();
    //Here it checks if the current streak or the old streak is the longest, and the longest one gets shown as longest streak
    int LongestStreak = (Quiz.Streak > Quiz.OldStreak) ? Quiz.Streak : Quiz.OldStreak;

    //Here it converts the score to a float, so that it can be used to calculate the percent of correct answers
    float floatScore = (float)Quiz.Score;
    //here it calculates the percentage of correct answers
    float PercentageCorrect = (floatScore / questions.Length) * 100;
    //here it prints the results
    Console.WriteLine("\nHere are the results: ");
    Console.WriteLine("Score: " + Quiz.Score + "\nLongest Streak: " + LongestStreak + "\nPercentage Correct: " + PercentageCorrect + "%");
    retry();
}
//Here's the method that asks if you want to try again
void retry()
{
    Console.WriteLine("Do you wish to try again? y/n");
    string answer = Console.ReadLine();
    if (answer == "y") Quiz(); return;
    Environment.Exit(0);
}