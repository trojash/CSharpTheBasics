/*
Console.WriteLine("Are you okay? ");
string a = Console.ReadLine();
Console.WriteLine("Can you speak? ");
string b = Console.ReadLine();
Console.WriteLine("Hello, Everybody!");
Console.WriteLine("Everybody knows!");
Console.WriteLine("Good morning everyone, God bless you!");
*/
/*
//expressions
Console.WriteLine("Hi user");
Console.WriteLine("Hi" + "user");

//variables
//declaring 
int x;
int y;
//assignment
x = 10;
y = 20;
//use in expressions 
Console.WriteLine(x + y);

//Reading text from the console
string name;
Console.WriteLine("What is your name? ");
name = Console.ReadLine();
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("Hello my name is: " + name);
}

*/
/*
Console.WriteLine("Bread is ready.");
string nameF;
Console.WriteLine("Who is the bread for? ");
nameF = Console.ReadLine();
Console.WriteLine(nameF);
Console.WriteLine("Noted: " + nameF + " got bread");

//this is a comment where I can describe what happens next
//this is also a comment.
/*this is a comment that ends here... */
/*
 this is a multi-line comment.
It spans multiple lines.
isn't it neat?
 
 */





Console.WriteLine("What kind of thing are we talking about? ");
string a = Console.ReadLine(); /* A young man dropped him Thing Namer 3000 and broke it */
Console.WriteLine("How would you describe it? Big? Azure? Tattered? ");
string b = Console.ReadLine(); //describe the thing namber 3000
string c = "Doom"; //data store like a young man felt when broke it the thing namer
string d = "3000"; //data store the model of thing.
Console.WriteLine("The " + a + " " + d + " is " + b + " of " + c + "!"); 

// Answer this question: Aside from comments, what is one other thing you could do to make this code more understandable?
//   Better variable names is one possibility. I'd rename `a` to `type`, `b` to `description`, `c` to `doom`, and `d` to
//   `version` or something like that.