Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

const double initialMoney = 100.00;
double playerMoney = initialMoney;

Console.WriteLine("Hello, what your name ?");
string playerName = Console.ReadLine();
if (playerName == "")
{
    playerName = "unknown user";
}
Console.WriteLine($"Welcome {playerName}");

Console.WriteLine("  .-----------.");
Console.WriteLine(" /-----------/|");
Console.WriteLine("/.----------/||");
Console.WriteLine("|           |||");
Console.WriteLine("| BlackJack |||");
Console.WriteLine("|           |||");
Console.WriteLine("|           |||");
Console.WriteLine("|           |||");
Console.WriteLine("| The Game  |||");
Console.WriteLine("|           ||/");
Console.WriteLine("\\----------./ ");
Console.ResetColor();
Console.WriteLine("1. new game");
Console.WriteLine("2. Reset stats");
Console.WriteLine("3. Exit");

Console.WriteLine("\nPlease type in menu option number and press <Enter>");
string selectedMenuOption = Console.ReadLine();

switch (selectedMenuOption)
{
    case "1":
        Console.WriteLine("Shuffling the deck..");
        Console.WriteLine("Done shuffling the deck.");
        Console.WriteLine("Serving the cards");

        var randomGenerator = new Random();
        var firstCardScore = randomGenerator.Next(1, 10);
        var secondCardScore = randomGenerator.Next(1, 10);
        var thirdCardScore = 0;

        Console.WriteLine($"Your first card score is: {firstCardScore}");
        Console.WriteLine($"Your second card score is: {secondCardScore}");
        Console.WriteLine($"Would like to get served another card? Yes or No");
        var shouldDeal = Console.ReadLine();

        if (shouldDeal.ToUpperInvariant() is "Y" or "YES")
        {
            thirdCardScore = randomGenerator.Next(1, 10);
            Console.WriteLine($"Your third card score is: {thirdCardScore}");
        }

        var totalCardScore = firstCardScore + secondCardScore + thirdCardScore;

        Console.WriteLine($"Total card score: {totalCardScore}");

        if (totalCardScore > 21)
        {
            Console.WriteLine("Game over..Press any key to quit");
            Console.ReadKey();
            return;
        }

        var dealerHand = randomGenerator.Next(10, 21);

        Console.WriteLine($"Your dealer total card score: {dealerHand}");

        if (totalCardScore <= dealerHand)
        {
            Console.WriteLine("Dealer won! Game over..Press any key to quit");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Congratulations!! You won!! Press any key to quit");
        Console.ReadKey();
        return;
    case "2":
        Console.WriteLine("Are you sure you want to reset your stat? Yes or No");
        string promptAnswer = Console.ReadLine();
        if (promptAnswer.ToUpperInvariant() is "Y" or "YES")
        {
            playerMoney = initialMoney;

            Console.WriteLine("Stats were reset");
        }
        break;
    case "3":
        Console.WriteLine("Exiting Blackjack");
        return;
}

Console.ReadKey();