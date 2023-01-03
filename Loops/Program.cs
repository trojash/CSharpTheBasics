//Level 11: Looping
/*C# four types loop*/

/*
 * #1 A While loop: repeats code over and over for as long as some given condition evalutes to true
 * 
 * its structure closely resembles an if statement
 * 
 * while(condition)
 * {
 *      //This code is repeated as long as the condition is true.
 * }
 
 */
/*
int x = 1;

while (x <= 5)
{
    Console.WriteLine(x);
    x++;
}
*/
/*
int y = 1;

while (y <= 1000)
{
    //Odd number or even
    if (y % 2 == 1)
    {
        Console.WriteLine(y);
    }
    
    y++;
}
*/
/*
int playersNumber = -1;

while (playersNumber <0 || playersNumber > 10)
{
    Console.WriteLine("Enter a number between 0 and 10: ");
    string playerReponse = Console.ReadLine();
    playersNumber = Convert.ToInt32(playerReponse);
}
*/

/*
 * #2 A Do/While loop: A Do/While loop evaluates its condition at the end of the loop instead of the beginning
 * This ensures the loop runs at least once.
 * 
 * its structure of the loop (do/while)
 * 
 * do
 * {
 *      //This code is ensures the loop runs at least once.
 *      
 * }while(condition);
 
 */
/*
int playersNumber;

do
{
    Console.Write("Enter a number between 0 and 10: ");
    string playerResponse = Console.ReadLine();
    playersNumber = Convert.ToInt32(playerResponse);

} while (playersNumber < 0 || playersNumber > 10);
*/

/*
 * #3 A For loop: repeats code over and over for as long as some given condition evalutes to true
 * 
 * its structure closely resembles an while loop
 * 
 * for(initialization statement; condition to evaluate; updating action)
 * {
 *      //...
 * }
 
 */
/*
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/

/*The break and continue statements*/
/*
while (true)
{
    Console.WriteLine("Think of a number and type it here: ");
    string input = Console.ReadLine();

    if (input == "quit" || input == "exit")
    {
        break;
    }

    int number = Convert.ToInt32(input);

    if (number == 12)
    {
        Console.WriteLine("I don't like that number, Pick another one");
        continue;
    }
    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");

}
*/

/*Nesting Loops*/
//A basic multiplication table
/*
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"\n{i} * {j} = {i * j}");
    }
}
*/
/*
Console.WriteLine("Display the multiplication table:\n");
Console.WriteLine("-----------------------------------");
Console.WriteLine("Enter the number (Table to be Calculated): ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{n} * {i} = {n * i}");
}
*/

int totalRows = 5;
int totalCols = 10;

for (int currentRows = 1; currentRows <= totalRows; currentRows++)
{
    for (int currentCols = 1; currentCols <= totalCols; currentCols++)
    {
        Console.WriteLine("*");
    }
}


Console.ReadKey();
