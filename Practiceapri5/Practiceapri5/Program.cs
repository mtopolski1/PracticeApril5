using System;

namespace Practiceapri5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age? ");
            string age = Console.ReadLine();
            int ageF = int.Parse(age);
            Console.WriteLine("What is your favorite color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Hello, " + name + " and you are " + ageF + " years old and your favorite color is " + color + ".");

            Console.ReadLine();

        }
    }
}

//NOTES FROM FIRST DAY
// This is an example of a comment - Gets user input and adds 5
/* This is a block comment, can be used to block out long messages and or copyright or old code*/

//const int fee = 10; //this is an example of a constant unchangeable variable
//string input = Console.ReadLine();
//int result = int.Parse(input);

//Console.WriteLine(result + fee);

//Practice from Slides

/*Console.WriteLine("Enter the radius: ");
string entry = Console.ReadLine();
double value = double.Parse(entry);
double area = Math.PI * value * value;  // Use Math. for more accured math equations!
Console.WriteLine(area);
Console.ReadLine();*/