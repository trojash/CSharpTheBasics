//Level 14: Methods

/*
    * Methods are a way of taking a chunk of code that does a specific task and putting it together in a way that is reusable.
    
    * Stuff can be returned from a method by specifying the return type in the method definition and then using the return keyword 
    inside of the method anywhere you want to return a value, 
    very similar to C, C++, and Java.

    * Parameters can be passed into a method, also in a way that is very similar to C, C++, and Java.
    
    * Multiple methods with the same name can be made (called method overloading) as long as their method signatures are different.
    
    * Recursion is where you call a method from inside itself and requires a base case to prevent the flow of execution from digging 
    deeper and deeper into more method calls, eventually killing itself in a StackOverflowException.

    C# provides us with a feature that allows us to break down our program into more manageable pieces. This feature is called a method. 
    Methods are sometimes called functions or procedures in other programming languages. 
    You can take a piece of your code, place it inside of a method, and then access it whenever you want. 
    We can more easily locate a bug or problem in a program because we can pinpoint it to a very specific method. 
    In addition, we can reuse a method as often as we want, so we don't have to reinvent the wheel and save ourselves tons of time.
 
 
 */

//Defining a method: how to make a method
/*
using System.ComponentModel;

Console.WriteLine("Hello, World");

void CountToTen()
{
    for (int current = 0; current <= 10; current++)
    {
        Console.WriteLine(current);
    }
}

//Calling a method: How to use a method
CountToTen();

*/

//Methods get their own variables
/*
int current = Convert.ToInt32(Console.ReadLine());

//Blocks of code or scope
void CountToTen()
{
    for (int current = 0; current <= 10; current++)
    {
        Console.WriteLine(current);
    }
}

void CountToTwenty()
{
    for (int current = 0; current <= 20; current++)
    {
        Console.WriteLine(current);
    }
}

CountToTen();
CountToTwenty();
*/

//Placement of methods
/*
DisplayAMonth();
DisplayAnotherMonth();

static void DisplayAMonth()
{
Console.WriteLine(Month.January);
}

static void DisplayAnotherMonth()
{
Console.WriteLine(Month.July);
}

enum Month { January, February, March, April, May, June, July, August, September, October, November, December }
*/


//Adding Parameters: passing data to a method
/*
static void CountTo(int number)
{
    for (int index = 0; index <= number; index++)
    {
        Console.WriteLine(index);
    }
}

CountTo(10);
*/

/*
    This, by the way, is exactly how Console's WriteLine method works. 
    It has a parameter for what text to display, and 
    we just call it with different text in different circumstances.

 */

//Returning stuff from a method
//If we want to return something, we start by swapping out void for the type we want to return.
/*
static int GetNumber()
{
    return 10;
}

int number = GetNumber();
Console.WriteLine("The number you got was " + number + ".");
*/

//This code return a number chosen by the user
/*
static int GetNumber()
{
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int parsedNumber = Convert.ToInt32(input);
    return parsedNumber;
}

int number = GetNumber();
Console.WriteLine("The number you got was "+ number + ".");
*/


/*
    This represents a very meaningful chunk of code that can easily be reused multiple times to get numbers. 
    Though we could make it a bit more flexible by allowing the calling method to specify the text to use to prompt the user:

 */

/*
static int AskForNumber(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();
    int parsedNumber = Convert.ToInt32(input);
    return parsedNumber;
}

int x = AskForNumber("Enter the row number: ");
int y = AskForNumber("Enter the column number: ");
Console.WriteLine("You've chosen the coordinate (" + x + ", " + y + ")");

*/

/*
    Returning Early
    
    While return statements often land on the final line of a method, 
    they don't need to always be the last statement. 
    This is especially true if you have if statements and loops.
 
 
 */

/*
    Returning Early from a void Method
    
    A void method will naturally end when the flow of execution hits the end of the method. 
    But you have an option to end a void method before the bottom of the method by using a plain return;
 
 */
/*
static void MaybeReturnEarly(bool returnEarly)
{
    if(returnEarly) { return ; }

    Console.WriteLine("Did not return early!");
}

MaybeReturnEarly(true);
*/

//Multiple Parameters

/*
void CountBetween(int start, int end)
{
    for (int current = start; current <= end; current++)
    {
        Console.WriteLine(current);
    }
}

CountBetween(10, 30);
*/

/*
static int GetNumberBetween(string prompt, int min, int max)
{
    int parsedNumber;
    do
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        parsedNumber= Convert.ToInt32(input);

    } while (parsedNumber < min || parsedNumber > max);

    return parsedNumber;
}
*/

//returning a value from a method
//string input = Console.ReadLine();
//int number = Convert.ToInt32(input);


/*
Console.Write("How high should I count?");
int chosenNumber = ReadNumber();
Count(chosenNumber);
void Count(int numberToCountTo)
{
    for (int current = 1; current <= numberToCountTo; current++)
        Console.WriteLine(current);
}

int ReadNumber()
{
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    return number;
}
*/

//Returning early
/*
string GetUserName()
{
    while (true)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        if (name != "") // Empty string
            return name;
        Console.WriteLine("Let's try that again.");
    }

}

GetUserName();
*/
/*
void Count(int numberToCountTo)
{
    if (numberToCountTo < 1)
    {
        return;
    }

    for (int index = 1; index <= numberToCountTo; index++)
        Console.WriteLine(index);
}

Count(0);
*/

//Method Overloading
int DoubleAndAddOne(int value) => value * 2 + 1;
DoubleAndAddOne(3);

//Recursive Method
static void BrokenRecursiveMethod()
{
    BrokenRecursiveMethod(); // BROKEN!
}

//XML Documentation Code
/// <summary>
/// Counts to the given number, starting at 1 and including the number provided.
/// </summary>
void Count(int numberToCountTo)
{
    for (int index = 1; index <= numberToCountTo; index++)
        Console.WriteLine(index);
}
Count(1);

//Factorial method
int Factorial(int number)
{
    if (number == 1) return 1;
    return number * Factorial(number - 1);
}
/*
static int Factorial(int number)
{
    if (number == 1) { return 1; }

    return number * Factorial(number - 1);
}
*/