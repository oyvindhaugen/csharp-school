string[] questions = {
    "What is a string?",
    "What does a float do?",
    "What is the difference between Console.Write() and Console.WriteLine()?",
    "What is the syntax for an array of numbers with decimals?",
    "If you want to get the first element of an array, what do you write?",
    "What does it mean when a variable has the value of null?"
    };
string[][] answers = {
    {
        "It is a number.",
        "It is a character.",
        "It is an array of characters.", //correct
        "It is collection of letters, symbols and numbers."
    },
    {
        "A float is a number with ~6-9 decimals.", //Correct
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

QNA QuizBackend;
int QNAIncr = 0;
int indexOfAnswer = answersIndex[QNAIncr];
for (QNAIncr; QNAIncr < questions.Length; QNAIncr++)
{
    QuizBackend.Question = questions[QNAIncr];
    for (int i = 0; i < 4; i++) QuizBackend.Answers[i] = answers[QNAIncr][i];
    QuizBackend.Answer = indexOfAnswer;
}

Console.WriteLine("Welcome to my coding quiz!");
Console.WriteLine("Please enter your name to start: ");
string playerName = Console.ReadLine();
Console.WriteLine("Ready up " + playerName + "\nHere we go!");



class QNA
{
    string Question;
    string[] Answers = { "", "", "", "" };
    int Answer;
}
/*
Gir navn
Gjør quiz
***BACKEND***
Teller streak
Teller poeng
% rette spørs
play again?
*/