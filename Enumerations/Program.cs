//Level 13: Enums

/*
    Enumerations are a way of defining your own type of variable so that it has specific values.
    Enumerations are defined like this: public enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    Enumerations should be defined outside of any classes that you have.
    The fact that an enumeration can only take on the values that you chose, means that you can't possibly end up with bad data that is meaningless.
    You can assign your own numeric values to the items in an enumeration: 
    public enum DayOfWeek { Sunday = 5, Monday = 6, Tuesday = 7, Wednesday = 8, Thursday = 9, Friday = 10, Saturday = 11 }; 

    Enumerations (or enumeration types, or enums for short) are a cool way to define your own type of variable 
    (the first of many ways we'll see to create your own).

    The word enumeration comes from the word enumerate, which means "to count off, one after the other",
    which is basically what we're going to be doing. We're going to start off with the basics of using enumerations,
 */

//The Basics of Enumerations: the days in the week

//int dayOfWeek = 3;
/*
if(dayOfWeek== 3)
{
    //Do something here because it is Tuesday.
}
*/
//string[] daysOfWeek = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
/*
int sunday = 1;
int monday = 2;
int tuesday = 3;
int wednesday = 4;
int thursday = 5;
int friday = 6;
int saturday = 7;

int dayOfWeek = tuesday;

if (dayOfWeek == tuesday)
{
    // Do something here because it is Tuesday.
}
*/

//Console.WriteLine("Hello, World!");
//public enum DayOfWeek { Sunday, Monday, Tuesday,Wednesday,Thursday,Friday,Saturday};
/*
DayOfWeek today = DayOfWeek.Tuesday;

if(today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
{
    Console.WriteLine("It's the weekend");
}
else if(today == DayOfWeek.Wednesday)
{
    Console.WriteLine("It's Wednesday, my dudes");
}
else if (today == DayOfWeek.Monday)
{
    Console.WriteLine("Just another manic Monday");
}
else
{
    Console.WriteLine("Just a regular " + today);
}
public enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
*/

//Enumerations and Switches
/*
DayOfWeek today = DayOfWeek.Monday;

switch (today)
{
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("It's the weekend!");
        break;
    case DayOfWeek.Monday:
        Console.WriteLine("Just another manic Monday");
        break;
    case DayOfWeek.Tuesday:
        break;
    case DayOfWeek.Wednesday:
        Console.WriteLine("It's Wednesday, my dudes");
        break;
    case DayOfWeek.Thursday:
        break;
    case DayOfWeek.Friday:
        break;
    default:
        Console.WriteLine("Just a regular " + today);
        break;
}
*/
//if you want to ask the user
/*
Console.WriteLine("Type a day of the week: ");
string typedDay = Console.ReadLine();

DayOfWeek today1 = typedDay switch
{
    "Sunday" => DayOfWeek.Sunday,
    "Monday" => DayOfWeek.Monday,
    "Tuesday" => DayOfWeek.Tuesday,
    "Wednesday" => DayOfWeek.Wednesday,
    "Thursday" => DayOfWeek.Thursday,
    "Friday" => DayOfWeek.Friday,
    "Saturday" => DayOfWeek.Saturday,
    _ => throw new NotImplementedException()
};
*/

//Cast Enumerations
int dayAsInt = (int)DayOfWeek.Saturday;
DayOfWeek today = (DayOfWeek)dayAsInt;
DayOfWeek tomorrow = (DayOfWeek)(dayAsInt + 1);

public enum DayOfWeek { Sunday = 5, Monday = 6, Tuesday = 7, Wednesday = 8, Thursday = 9, Friday = 10, Saturday = 11 };

/*
 Enumerations are only the first of many ways that we'll see to make your own type of variables. 
There are lots of cool ways you can use enumerations, like the type of terrain you are using for a tile in your game 
(public enum TerrainType { Mountain, Water, Desert, Grassland, Forest };) 
or the suits of a deck of playing cards (public enum Suit { Clubs, Diamonds, Spades, Hearts };).
 
 
 
 */