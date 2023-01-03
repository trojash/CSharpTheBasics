

Console.WriteLine("Calculadora Simple");
    Console.WriteLine("----------------------------");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Raíz Cuadrada");
    Console.WriteLine("6. Exponente");
    Console.Write("Seleccionar una opcion(1-6): ");

    //Global Variables
    int x, y, z;
    int options = Convert.ToInt32(Console.ReadLine());


    switch (options)
    {
	    case 1:
            Console.WriteLine("Escribe un número: ");
            x = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Escribe un segundo número: ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.WriteLine("Suma = {0}",z);
            break;
        case 2:
            Console.WriteLine("Escribe un número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro número: ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x - y;
            Console.WriteLine("Restar = {0}", z);
            break;
        case 3:
            Console.WriteLine("Escribe un número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro número: ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x * y;
            Console.WriteLine("Multiplicar = {0}", z);
            break;
        case 4:
            Console.WriteLine("Escribe un número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro número: ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x / y;
            Console.WriteLine("Division = {0}", z);
            break;
        case 5:
            Console.WriteLine("Escribe un número: ");
            double number = Convert.ToDouble(Console.ReadLine());
        
            if (number > 0)
            {
                double sqrt = Math.Sqrt(number);
                Console.WriteLine("Raíz Cuadrada: {0}", sqrt);
            }
            else
            {
                Console.WriteLine(double.NaN);
            }
        
            break;
        case 6:
            Console.WriteLine("Escribe un número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el Exponente: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultEx = Math.Pow(num1, num2);

            try
            {
                Console.WriteLine("El exponente es: {0}", resultEx);
            }
            catch (Exception)
            {

                Console.WriteLine(double.NaN);
            }

            break;
    default:
		    break;
    }




    /*
    Console.WriteLine("Escribe un número: ");
    int i = Convert.ToInt32(Console.ReadLine());

        if (i < 2)
        {
            Console.WriteLine("Punch");
        }
        else
        {
            Console.WriteLine("Error");
        }
    */

/*

    //the confirmation of a table reservation at restaurant...
    using System.Globalization;

    CultureInfo cultureInfo = new CultureInfo("es-ES");

    Console.WriteLine("The table number is: ");
    string tableNumber = Console.ReadLine();

    Console.WriteLine("The number of people: ");
    int peopleCount = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("The reservation Date and time: ");
    string dateTimeString = Console.ReadLine();

    if(!DateTime.TryParseExact(dateTimeString,
    "M/d/yyyy HH:mm",
    cultureInfo,
    DateTimeStyles.None,
    out DateTime dateTime))
    {
        dateTime = DateTime.Now;
    }    


    Console.WriteLine("Table {0} " +
        "has been booked for {1} people on {2} at {3}", tableNumber, peopleCount, dateTime.ToString("M/d/yyyy", cultureInfo),
    dateTime.ToString("HH:mm", cultureInfo));
*/