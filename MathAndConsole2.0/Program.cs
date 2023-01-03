/*
//This code computes the area of a trapezoid:
// Some code for the area of a trapezoid (http://en.wikipedia.org/wiki/Trapezoid)
double side1 = 4.5;
double side2 = 3.5;
double height = 1.5;
double areaOfTrapezoid = (side1 + side2) / 2.0 * height;
Console.WriteLine($"Hello, result is: {areaOfTrapezoid}!");


Console.WriteLine("Basic Calcultator");
int a = 2 + 5 * 2;
int b = (2 + 5) * 2;
int c = 2 + 5;
int d = c * 2;
Console.WriteLine($"Hello, result is: {a}!");
Console.WriteLine($"Hello, result is: {b}!");
Console.WriteLine($"Hello, result is: {d}!");
*/

/*
//The triangle area
//1. write a program that lets you input the triangle's base size and height.
//2. compute the area of a triangle by turning the above equation into code.
//3. write the result of the computation

//separate function
static double findArea(double b, double h)
{
    return (b * h) / 2;
}

Console.WriteLine("A Triangle Area Calculation: ");
Console.WriteLine("What is the base of a triangle? ");
double baseT = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the height of a triangle? ");
double heightT = Convert.ToDouble(Console.ReadLine());

//double areaT = (baseT * heightT) / 2;//equation

Console.WriteLine($"The area of a triangle is: {findArea(baseT,heightT)}!");
*/


/*
double notAnyRealNumber = double.NaN;
Console.WriteLine(notAnyRealNumber);

int a = 5;
int b = 2;
int result = a / b;
int remainder = 23 % 3;
int result1 = remainder;

int c = 0;
int modulus = c % 2;

Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(c);

*/



/*The defense of consolas*/
/*
Console.Title = "Defense of consolas";

Console.Write("Target Row?: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column?: ");
int column = Convert.ToInt32(Console.ReadLine());


Console.ForegroundColor = ConsoleColor.Yellow; /*Display the deployment instructions in a different color of your choosing*/
/*
Console.WriteLine($"{row}, {column - 1}");
Console.WriteLine($"{row - 1}, {column}");
Console.WriteLine($"{row}, {column + 1}");
Console.WriteLine($"{row + 1}, {column}");

Console.Beep();
*/