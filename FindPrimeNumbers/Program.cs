using FindPrimeNumbers;

bool KeepGoing = false;
Console.WriteLine("Let's locate some primes!");
Console.WriteLine("This application will find you any prime, in order, from first prime number on.");

while (!KeepGoing)
{
    Console.Write("Which prime number are you looking for? (1 - 25): ");
    string entrystring = Console.ReadLine();
    int entry = 0;

    bool isValidNum = int.TryParse(entrystring, out entry);
    if (!isValidNum)
    {
        Console.WriteLine("This isn't a number.");
    }
    else if(entry < 1 || entry > 25)
    {
        Console.WriteLine("Sorry! Only numbers 1- 25");
    }
    else if (entry >= 1 || entry <= 25)
    {
        int result = Prime.GetPrime(entry);
        Console.WriteLine($"The number {entry} prime is {result}.");
    }


    Console.Write("Would you like to go again? y/n ");
    string choice = Console.ReadLine().ToLower();
    if (choice == "yes" || choice == "y")
    {
        KeepGoing = false;
    }
    else if (choice == "no" || choice == "n")
    {
        Console.WriteLine("Bye!");
        KeepGoing = true;
    }

}