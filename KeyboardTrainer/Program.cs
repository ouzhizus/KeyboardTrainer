using Pastel;

Random rnd = new Random(); ;
string[] Words = {"hello bye how are you i hope everything is good"};
string chosenWord = Words[rnd.Next(0,Words.Length)];
char[] partedWord = chosenWord.ToCharArray();
char[] rightArray = new char[partedWord.Length];
char[] incorrectArray = new char[partedWord.Length];
for (int i = 0; i < rightArray.Length;i++)
{
    rightArray[i] = ' ';
}

for (int i = 0; i < incorrectArray.Length;i++)
{
    incorrectArray[i] = ' ';
}

int counter = 0;
while (counter != partedWord.Length)
{
    int rightCounter = 0;
    int incorCounter = 0;
    Console.CursorVisible = false;
    Console.SetCursorPosition(0,0);
    Console.WriteLine("Test Test");
    Console.SetCursorPosition(0,1);
    Console.WriteLine(partedWord);
    foreach (var letter in rightArray)
    {
        Console.SetCursorPosition(rightCounter, 2);
        if (!letter.Equals(' '))
        {
            Console.Write($"{letter}".Pastel(ConsoleColor.Green));
        }

        rightCounter++;
    }

    foreach (var letter in incorrectArray)
    {
        Console.SetCursorPosition(incorCounter, 2);
        if (!letter.Equals(' '))
        {
            Console.Write($"{letter}".Pastel(ConsoleColor.Red));
        }

        incorCounter++;
    }

    char userLetter = Console.ReadKey().KeyChar;
    if (userLetter.Equals(partedWord[counter]))
    {
        rightArray[counter] = userLetter;
    }
    else
    {
        incorrectArray[counter] = userLetter;
    }

    counter++;
}

Console.ReadLine();