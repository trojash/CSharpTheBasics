//if statement based-version might look like this
/*
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("Hello");
}
else if (choice == 2)
{
    Console.WriteLine("Nice too meet you");
}
else if(choice == 3)
{
    Console.WriteLine("What is your name?");
}
else if(choice== 4)
{
    Console.WriteLine("And where are you from? ");
}
else
{
    Console.WriteLine("Without answer :(");
}
*/

//switch statement
/*
Console.WriteLine("Calculator");
Console.WriteLine("---------------------------------");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("Enter your choice (1-4): ");
int choice = Convert.ToInt32(Console.ReadLine());
int a, b, c;

switch (choice)
{
    case 1:
        Console.WriteLine("First numbeR: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a + b;
        Console.WriteLine($"The result of Addition is: {c}");
        break; 
    case 2:
        Console.WriteLine("First number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a - b;
        Console.WriteLine($"The result of Subtraction is: {c}");
        break;
    case 3:
        Console.WriteLine("First number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a * b;
        Console.WriteLine($"The result of Multiplication is: {c}");
        break;
    case 4:
        Console.WriteLine("First number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a / b;
        Console.WriteLine($"The result of Division is: {c}");
        break;
    default:
        if (choice >= 5)
        {
            Console.WriteLine("The choice enter is incorrect!, try again");
        }
        break;
}
*/

/*
Console.WriteLine("Buying Inventory: The following items are available: ");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("1. Rope");
Console.WriteLine("2. Torches");
Console.WriteLine("3. Climbing Equipment");
Console.WriteLine("4. Clean Water");
Console.WriteLine("5. Machete");
Console.WriteLine("6. Canoe");
Console.WriteLine("7. Food Supplies");
Console.WriteLine("What number do you want to see the price of?: ");
int choice = Convert.ToInt32(Console.ReadLine());


switch (choice)
{
    case 1:
        Console.WriteLine("The Rope cost 10 gold");
        break;
    case 2:
        Console.WriteLine("The Torches cost 15 gold");
        break;
    case 3:
        Console.WriteLine("The Climbing Equipment cost 25 gold");
        break;
    case 4:
        Console.WriteLine("The Clean Water cost 1 gold");
        break;
    case 5:
        Console.WriteLine("The Machete cost 20 gold");
        break;
    case 6:
        Console.WriteLine("The Canoe cost 200 gold");
        break;
    case 7:
        Console.WriteLine("The Food Supplies cost 1 gold");
        break;
    default:
            Console.WriteLine("The choice enter is incorrect!, try again");
        break;
}
*/
/*
Console.WriteLine("Buying Inventory: The following items are available: ");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("1. Rope");
Console.WriteLine("2. Torches");
Console.WriteLine("3. Climbing Equipment");
Console.WriteLine("4. Clean Water");
Console.WriteLine("5. Machete");
Console.WriteLine("6. Canoe");
Console.WriteLine("7. Food Supplies");
Console.WriteLine("What number do you want to see the price of?: ");
int choice = Convert.ToInt32(Console.ReadLine());

string item = choice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1
};

Console.WriteLine("What is your name? ");
string name = Console.ReadLine();
if(name == "Tony")
{
    price /= 2;
}
Console.WriteLine($"{item} costs {price} gold.");
*/