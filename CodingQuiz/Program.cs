//Here I initialize all my arrays with questions and answers
//There's an array containing the question strings, one containing the answer option strings, and one containing the number of the correct option  
string[] questions = {
    "What is a string?",
    "What does a float do?",
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

//Here I have a little intro, getting the players name and such.
Console.Clear();
Console.WriteLine("\nWelcome to my coding quiz!");
Console.WriteLine("Please enter your name to start: ");
string playerName = Console.ReadLine();
Console.WriteLine("\nReady up " + playerName + "\nHere we go!\n");

//Here I initialize the QNA class so I can use it later on
QNA QuizBackend = new QNA();

//Here's the loop which loops through all the questions in the questions array
for (int QNAIncr = 0; QNAIncr < questions.Length; QNAIncr++)
{
    Console.Clear();
    //Here it sets the Question string from the QNA class to what it is in the array at this index (which it gets from QNAIncr)
    QuizBackend.Question = questions[QNAIncr];
    //Here it loops through to print all the options
    for (int i = 0; i < 4; i++) QuizBackend.Answers[i] = answers[QNAIncr, i];

    //Here it sets the answer int to what the answer is at this index in the answersIndex array.
    QuizBackend.Answer = answersIndex[QNAIncr];
    Console.WriteLine("\nQuestion " + (QNAIncr + 1) + ") " + QuizBackend.Question + "\n");
    for (int i = 0; i < 4; i++) Console.WriteLine(i + 1 + ") " + QuizBackend.Answers[i]);
    //Here I initialize a string that's gonna contain what the player answers
    string playerAnswer = "";
    //Here it reads the input from the player and uses it as the answer
    playerAnswer = Console.ReadLine();
    if (playerAnswer != "1" || playerAnswer != "2" || playerAnswer != "3"|| playerAnswer != "4") {
        Console.WriteLine("Invalid answer, please try again");
        playerAnswer = Console.ReadLine();
    }
    //Here it converts the playerAnswer string to an int so it can be used to compare to the QuizBackend.Answer int
    if (Convert.ToInt32(playerAnswer) - 1 == QuizBackend.Answer)
    {
        Console.WriteLine("Correct!");
        Thread.Sleep(400);
        QuizBackend.Score++;
        QuizBackend.Streak++;
    }
    else
    {
        Console.WriteLine("Wrong!");
        Thread.Sleep(400);
        QuizBackend.OldStreak = QuizBackend.Streak;
        QuizBackend.Streak = 0;
    }
}
Console.Clear();
int LongestStreak = (QuizBackend.Streak > QuizBackend.OldStreak) ? QuizBackend.Streak : QuizBackend.OldStreak;

float floatScore = (float)QuizBackend.Score;
float PercentageCorrect = (floatScore / questions.Length) * 100;
Console.WriteLine("\nHere come the results: ");
Console.WriteLine("Score: " + QuizBackend.Score + "\nLongest Streak: " + LongestStreak + "\nPercentage Correct: " + PercentageCorrect + "%");



/*
Gir navn
Gjør quiz
***BACKEND***
Teller streak
Teller poeng
% rette spørs
play again?
*/