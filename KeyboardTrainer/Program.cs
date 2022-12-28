using System.Diagnostics;
using Pastel;

Random rnd = new Random(); ;
string[] Words = {
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
    "Max Joykner sneakily drove his car around every corner looking for his dog",
    "Trixie and Veronica, our two cats, just love to play with their pink ball of yarn",
    "The two boys collected twigs outside, for over an hour, in the freezing cold!",
    "We climbed to the top of the mountain in just under two hours; isn’t that great?",
    "Don't make a mountain out of a molehill",
    "Friends are flowers in the garden of life",
    "The grass is always greener on the other side",
    "Just staying one day ahead of yesterday",
    "You can lead a horse to water but you can't make him drink",
    "All work and no play robs one of some fun in life"
};
Stopwatch timer = new Stopwatch();
char space = (char)32;
char enter = (char)13;
char backspace = (char)8;
while (true)
{
    Console.CursorVisible = false;
    string chosenWord = Words[rnd.Next(0,Words.Length)];
    char[] partedWord = chosenWord.ToCharArray();
    char[] rightArray = new char[partedWord.Length];
    char[] incorrectArray = new char[partedWord.Length];

    Console.Clear();
    Console.WriteLine("Press any key to start ");
    Console.ReadKey();
    Console.Clear();
    int startAgainTime = 3;
    Console.WriteLine($"Game starts in ");
    while (startAgainTime != 0)
    {
        Console.SetCursorPosition(15,0);
        Console.Write(startAgainTime);
        Thread.Sleep(1000);
        startAgainTime--;
    }
    Console.Clear();
    timer.Start();
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
        Console.CursorVisible = false;
        Console.SetCursorPosition(0,0);
        Console.WriteLine(partedWord);
        for (int i = 0; i < rightArray.Length; i++)
        {
            Console.SetCursorPosition(i, 1);
            if (rightArray[i] != ' ')
            {
                Console.Write($"{rightArray[i]}".Pastel(ConsoleColor.Green));
            }
        }

        for (int i = 0; i < incorrectArray.Length; i++)
        {
            Console.SetCursorPosition(i, 1);
            if (incorrectArray[i] != ' ')
            {
                Console.Write($"{incorrectArray[i]}".Pastel(ConsoleColor.Red));
            }
        }

    
        char userLetter = Console.ReadKey().KeyChar;
        if (userLetter.Equals(partedWord[counter]))
        {
            if(userLetter.Equals(space) && userLetter.Equals(partedWord[counter]))
            {
                rightArray[counter] = '_';
            }
            else
            {
                rightArray[counter] = userLetter;       
            }
        }
        else if (userLetter.Equals(space) && !userLetter.Equals(partedWord[counter]))
        {
            incorrectArray[counter] = '_';
        }
        else
        {
            if(userLetter.Equals(space) && userLetter.Equals(partedWord[counter]))
            {
                incorrectArray[counter] = '_';
            }
            else if (userLetter.Equals(enter) || userLetter.Equals(backspace))
            {
                incorrectArray[counter] = '_';
            }
            else
            {
                incorrectArray[counter] = userLetter;   
            }
        }
        counter++;
    }
    timer.Stop();
    Console.WriteLine("\n----------------------------------");
    Console.WriteLine($"You finished in {timer.Elapsed.Seconds} seconds!");
    Console.Write("Do you want to try one more time? \n YES/NO --> ");
    string userAnswer = Console.ReadLine()!.ToLower();
    if(userAnswer.Equals("no"))
    {
        Console.WriteLine("Press any key to exit".Pastel(ConsoleColor.Red));
        Console.ReadKey();
        break;
    }
}