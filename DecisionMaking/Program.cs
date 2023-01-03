/*
        If statements work just like they do in c++ and java
    
        if(condition)
        {
            statement;
            statement;
            statement;
            
        }
        else if(condition)
        {
            statement;
            statement;
            statement;
            
        }
        else
        {
            statement;
            statement;
        }


        Likewise, the ==, !=, <, >, <=, >= operators also work like in many other languages, 
        checking if two things are equal, not equal, less than, greater than, less than or equal to, 
        and greater than or equal to.

        The ! operator negates boolean types.
        
        The && (and operator) and || (or operator) allow you to compare multiple things at one time, 
        and work identical to the way they work in C++ and Java.
        
        if statements can be nested
 
 */



using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;
/*
Console.WriteLine("Take a number?");
int score1 = Convert.ToInt32(Console.ReadLine());
int pointsNeededToPass = 100;

bool levelComplete = (score1 >= pointsNeededToPass);

//if the points granted are 100 the condition is true
//and if the points granted is less than 100 the condition is false

if (levelComplete) //is false

{
    Console.WriteLine("You've beaten the level!");
}
else //then is true
{
    Console.WriteLine("The level was is not completed, Try again!");
}
*/
/*
Console.WriteLine("What is percent of shield?");
int shield = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is percent of armor?");
int armor = Convert.ToInt32(Console.ReadLine());

//Nesting if statments inside another if statement
if(shield <= 0)
{
    if(armor <= 0)
    {
        Console.WriteLine("Your shields and armor are both zero! You're dead!");
    }
    else
    {
        Console.WriteLine("Your shields are gone, but you still have armor left.  You're lucky to be alive!");
    }
}
else
{
    Console.WriteLine("You still have shields left.  The world is safe.");
}
*/

/*
if (shield <= 0 & armor <= 0)
{
    Console.WriteLine("Game over!");
}

bool stillHasShields = shield > 0;
bool stillHasArmors = armor > 0;

if (stillHasShields || stillHasArmors)
{
    Console.WriteLine("You're still alive! Keep going!");
}

*/



/*
//Take a number as input from the console 
Console.WriteLine("Take a number?");
int score2 = Convert.ToInt32(Console.ReadLine());

if(score2 % 2 == 0)
{
    Console.WriteLine("Tick");
}else
{
    Console.WriteLine("Tock");
}

*/


/*

if (score1 == 2 || score1 == 4 || score1 == 6 || score1 == 8)
{
    Console.WriteLine("Tick");
}
else if(score1 == 1 || score1 == 3 || score1 == 5 || score1 == 7)
{
    Console.WriteLine("Tock");
}
*/



/*
int pointsNeededToPass = 100;

bool levelComplete = (score1 >= pointsNeededToPass);

if (levelComplete)
{
    Console.WriteLine("You've beaten the level!");
}
else
{
    Console.WriteLine("The level is not completed, Try again!");
}

*/


/*
if (score1 == 100)
{
    Console.WriteLine("Perfect Score!");
}
if(score1 >= 90)
{
    Console.WriteLine("A!");
}
else if (score1 >= 80)
{
    Console.WriteLine("B!");
}
else if (score1 >= 70)
{

    Console.WriteLine("C!");
}
else if (score1 >= 60)
{

    Console.WriteLine("D!");
}
else
{
    Console.WriteLine("F!");
}
*/

/*
char grade = '?';

if (score1 == 100)
{
    //this case, if the score1 is 100!
    grade = 'A';
    Console.WriteLine("Perfect score! You Win!");
}
else if(score1 == 99)
{
    grade = 'B';
    Console.WriteLine("Missed it by THAT much!");
}
else if (score1 == 0)
{
    Console.WriteLine("Seriously, dude, you had to have been TRYING to get that bad of a score.");
}
else
{
    Console.WriteLine("Ah, come on!  That's just boring.");
    Console.WriteLine("Seriously.  Next time, pick a more interesting number.");
    Console.WriteLine("OK, basically, I'm only doing this to make sure you ");
    Console.WriteLine("know that as many lines of code as you want can go in here.");
}
*/


//Conditional Operator (Ternary operation) is another way that works like an if statements
/*syntax
            condition expression ? expression if true : expression if false
            
 */
/*
int score = 90;
string textToDisplay = score > 75 ? "You passed!" : "You failed";
Console.WriteLine($"The result is: {textToDisplay}");
*/




/// <summary>
/// Calculator app with use if-elseif-else statements
/// </summary>
/*
Console.WriteLine("Calculator");
Console.WriteLine("----------------------------");
Console.WriteLine("1.Add");
Console.WriteLine("2.Substract");
Console.WriteLine("3.Multiply");
Console.WriteLine("4.Divide");
Console.WriteLine("Enter choice(1-4): ");
int choice = Convert.ToInt32(Console.ReadLine());

if(choice == 1)
{
    Console.WriteLine("Typing first number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Typing second number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int result = number1 + number2;
    Console.WriteLine($"The result of the addition is: {result}");
}
else if (choice == 2)
{
    Console.WriteLine("Typing first number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Typing second number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int result = number1 - number2;
    Console.WriteLine($"The result of the subtraction is: {result}");
}
else if (choice == 3)
{
    Console.WriteLine("Typing first number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Typing second number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int result = number1 * number2;
    Console.WriteLine($"The result of the multiplication is: {result}");
}
else if (choice == 4)
{
    Console.WriteLine("Typing first number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Typing second number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int result = number1 / number2;
    Console.WriteLine($"The result of the division is: {result}");
}
else
{
    Console.WriteLine("Invalid choice");
}
*/

Console.WriteLine("Watchower");
Console.WriteLine("--------------------");

Console.WriteLine("Typing X coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Typing Y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());



if (x < 0 && y > 0)
{

    Console.WriteLine("The enemy is to the Northwest");
}
if (x == 0 && y > 0)
{
    Console.WriteLine("The enemy is to the North");
}
if (x > 0 && y > 0)
{
    Console.WriteLine("The enemy is to the NorthWest");
}
   

if (x < 0 && y == 0)
{

    Console.WriteLine("The enemy is to the West");
}

if (x == 0 && y == 0)
{
    Console.WriteLine("The enemy is here!");
}
if (x > 0 && y == 0)
{
    Console.WriteLine("The enemy is to the East");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("The enemy is to the Southwest");    
}
if (x== 0 && y < 0)
{
    Console.WriteLine("The enemy is to the South!");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("The enemy is to the Southeast");
}


Console.ReadKey();
///<summary>
///
/// This is another posible solution the problem Watchower 
/// 
/// </summary>
/*
int xC = Convert.ToInt32(Console.ReadLine());
int yC = Convert.ToInt32(Console.ReadLine());

if (x < 0 && y > 0) Console.WriteLine("The enemy is to the north west!");
if (x == 0 && y > 0) Console.WriteLine("The enemy is to the north!");
if (x > 0 && y > 0) Console.WriteLine("The enemy is to the north east!");

if (x < 0 && y == 0) Console.WriteLine("The enemy is to the west!");
if (x == 0 && y == 0) Console.WriteLine("The enemy is here!");
if (x > 0 && y == 0) Console.WriteLine("The enemy is to the east!");

if (x < 0 && y < 0) Console.WriteLine("The enemy is to the south west!");
if (x == 0 && y < 0) Console.WriteLine("The enemy is to the south!");
if (x > 0 && y < 0) Console.WriteLine("The enemy is to the south east!");
*/


