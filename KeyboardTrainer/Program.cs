using Pastel;

Random rnd = new Random(); ;
string[] Words = {"hello bye how are you i hope everything is good",
    "Please take your dog, Cali, out for a walk – he really needs some exercise!",
    "What a beautiful day it is on the beach, here in beautiful and sunny Hawaii",
    "Rex Quinfrey, a renowned scientist, created plans for an invisibility machine",
    "Do you know why all those chemicals are so hazardous to the environment?",
    "Those diamonds and rubies will make a beautiful piece of jewelry",
    "The steamboats seemed to float down the Mississippi River at a snail’s pace",
    "In order to keep up at that pace, Zack Squeve would have to work all night",
    "When do you think they will get back from their adventure in Cairo, Egypt?",
    "A weed is no more than a flower in disguise",
    "We'll cross that bridge when we come to it",
    "You can lead a horse to water but you can't make him drink",
    "You can't teach an old dog new tricks",
    "All work and no play robs one of some fun in life",
    "Your car is out of date as soon as it is paid for",
    "A bird in the hand is worth two in the bush",
    "Caught between a rock and a hard place",
    "I have three things to do today: wash my car, call my mother, and feed my dog",
    "The Reckson family decided to go to an amusement park on Wednesday",
    "There are so many places to go in Europe for a vacation--Paris, Rome, Prague, etc.",
    "Max Joykner sneakily drove his car around every corner looking for his dog"
};
string chosenWord = Words[rnd.Next(0,Words.Length)];
char[] partedWord = chosenWord.ToCharArray();
char[] rightArray = new char[partedWord.Length];
char[] incorrectArray = new char[partedWord.Length];

while (true)
{
    Console.WriteLine("Press any key to start ");
    Console.ReadKey();
    Console.Clear();
    int startAgainTime = 3;
    Console.WriteLine($"Game starts in ");
    while (startAgainTime != 0)
    {
        Console.SetCursorPosition(19,0);
        Console.Write(startAgainTime);
        Thread.Sleep(1000);
        startAgainTime--;
    }
    Console.Clear();
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
    Console.WriteLine("\n----------------------------------");
    Console.Write("Do you want to try one more time? \n YES/NO --> ");
    string userAnswer = Console.ReadLine()!.ToLower();
    if (userAnswer.Equals("yes"))
    {
        Console.Clear();
        int startAgainTimer = 3;
        Console.WriteLine($"New game starts in ");
        while (startAgainTimer != 0)
        {
            Console.SetCursorPosition(19,0);
            Console.Write(startAgainTimer);
            Thread.Sleep(1000);
            startAgainTimer--;
        }
        Console.Clear();
    }
    else if(userAnswer.Equals("no"))
    {
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
}