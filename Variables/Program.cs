// Creating and Using variables in C#
/*
string username;
string favoriteColor;
Console.WriteLine("What is your name? ");
username = Console.ReadLine();
Console.WriteLine("What is your favorite color? ");
favoriteColor = Console.ReadLine();
Console.WriteLine($"Hello my name is {username} and my favorite color is {favoriteColor}");
*/

//INTEGERS
/*
int firstNumber;
int secondNumber;
Console.WriteLine("First number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The addition is: " + (firstNumber + secondNumber));
Console.WriteLine("The subtraction  is: " + (firstNumber - secondNumber));
Console.WriteLine("The multiplication is: " + (firstNumber * secondNumber));
Console.WriteLine("The division is: " + (firstNumber / secondNumber));
Console.WriteLine("The modulo division is: " + (firstNumber % secondNumber));
*/
//variables names: the language has a few rules
/*
 1. Variable names must start with a letter or the underscore character (_).
 
 */
//taco and _taco are legitimate variable names, but 1taco and *taco are not.
//2. After the start, you can also use numeric digits (0 through 9).
//3. taco-poptart is not allow because the - character is used for subtraction.
//Most symbols and whitespace characters are banned.
//4. you cannot name a variable the same thing as a keyword. For example, you cannot call a variable int or string 
//as those are reserved, special words in the language.


//Declaring and Using variables with integer types
/*
byte aSingleByte = 34;
aSingleByte = 100;
Console.WriteLine(aSingleByte);

short aNumber = 5039;
aNumber = -4354;
Console.WriteLine(aNumber);

ulong aVeryBigNumber = 395904282569;
aVeryBigNumber = 1300000000000000000U;
Console.WriteLine(aVeryBigNumber);
*/


//The digit separator
/*
int bigNumber = 1_000_000_000;
Console.WriteLine(bigNumber);

int a, b, c;
a = 123_456_789;
b = 12_34_56_78_9;
c = 1_2__3___4____5;
Console.WriteLine(a + "\n" + b + "\n" + c);
*/

//Binary and Hexadecimal Literals
/*
//base 2 (binary literal)
int thirteen = 0b0001101;
Console.WriteLine(thirteen);
//base 16 (hexadecimal digits)
int theColorMagenta = 0xFF00FF;
Console.WriteLine(theColorMagenta);
*/

//Characters and Strings (Text)
/*
char aLetter = '\u0061'; // An 'a'
Console.WriteLine(aLetter);
char baseball = '⚾';
Console.WriteLine(baseball);

string message = "Hello World";
Console.WriteLine(message);
*/


//floating-point types
/*
double number1 = 3.5623;
float number2 = 3.5623F;
decimal number3 = 3.5623M;
double avogadrosNumber = 6.022e23;

Console.WriteLine(number1 + "\n" + number2 + "\n" + number3 + "\n" + avogadrosNumber);
*/

//The bool type
/*
bool itWorked = true;
itWorked= false;

Console.WriteLine(itWorked);
*/
/*
int age = 10;
string name = "Tony";
bool itOlder = true;
byte aSingleByte = 34;
short aNumber = 5039;
ulong aVeryBigNumber = 395904282569;
char aLetter = '\u0061';
double number1 = 3.5623;
float number2 = 3.5623F;
decimal number3 = 3.5623M;
ushort number4 = 50;
uint number5= 47979;
sbyte number6 = -15;
long number7 = 79797;


Console.WriteLine();

*/


/* The variable shop returns */
/* Type inference */
/*
var variableShop = 1;
variableShop = -15;
variableShop = 34;
var variableShop1 = 3.5636F;
var message = "Hello World";

var input = Console.ReadLine();
Console.WriteLine(input);

var something = "Hello";
something = 3;
*/

/* The convert class and the parse methods */
/*
Console.WriteLine("What is your favorite number? ");
string favoriteNumberText = Console.ReadLine();
int favoriteNumber = Convert.ToInt32(favoriteNumberText);
Console.WriteLine(favoriteNumber + " is a great number!");

Console.WriteLine("What is your age? ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("My age is: " + age);

*/
