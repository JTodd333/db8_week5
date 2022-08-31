using CalcApp;

Console.WriteLine("Welcome to the calulator");
Console.WriteLine("1. Factorial");
Console.WriteLine("2. Factors");
Console.Write("Which would you like to do? ");
string choice = Console.ReadLine();

Console.Write("Great! What number? ");
string entry = Console.ReadLine();
int number = int.Parse(entry);

Calculator calc = new Calculator(number);

if(choice == "1")
{
    int factorial = calc.FindFactorial();
    Console.WriteLine($"The factorial of {number} is {factorial}.");
}
else if (choice == "2")
{
    Console.WriteLine("Under construction. Coming Soon!");
}