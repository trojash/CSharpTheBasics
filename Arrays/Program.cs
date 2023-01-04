﻿//Level 12: Arrays

//Declare an array of int's
/*
int[] scores = new int[10];

scores[0] = 99;
scores[1] = 25;
scores[2] = 58;
scores[3] = 41;
scores[4] = 96;
scores[5] = 798;
scores[6] = 8;
scores[7] = 9;
scores[8] = 990;
scores[9] = 564;
//scores[10] = 0;

Console.WriteLine(scores.Length);

/*Use of loop foreach
foreach (int item in scores)
{
    Console.WriteLine(item);
}
*/

//Create an array always ask the user for a length
/*
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

for (int index = 0; index < array.Length; index++)
{
    array[index] = 1;
    Console.WriteLine(index);
}
*/
/*Indexing from the end and range*/
/*
int[] scores = new int[10];
int lastScore = scores[^1];
int[] theMiddle = scores[0..3];

scores[0] = 99;
scores[1] = 25;
scores[2] = 58;
scores[3] = 41;
scores[4] = 96;
scores[5] = 798;
scores[6] = 8;
scores[7] = 9;
scores[8] = 990;
scores[9] = 564;
Console.WriteLine(lastScore);
*/

/*Other ways to create arrays*/
/*
int[] scores1 = new int[10]; //simple way to create arrays
int[] scores2 = new int[10] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 }; //Collection initializer syntax
int[] scores3 = new int[] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 }; //Skip stating the length if you list all of the items
/*
 * if the type of values listed is clear enough for the compiler to infer the type.
 * You don't even need to specify the type 

int[] scores4 = new[] { 1, 2, 3, 4, 5, 5, 6 }; 
*/

/*some examples with arrays*/

//Calculate the minimum value an array
/*
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue; // Start higher than anything in the array.

for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
    {
        currentSmallest = array[index];
    }
}
Console.WriteLine(currentSmallest);
*/

/*Calculates the average value of the numbers in an array*/

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int totalItems = 0; 

for (int index = 0; index < array.Length; index++)
    totalItems += array[index];
float average = (float)totalItems / array.Length;
Console.WriteLine(average);