using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode2
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            //Basic input
            Console.Write("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            /*CHARS */
            //Char represents a character
            char chA1 = 'A';
            char chP1 = 'P';
            char chP2 = 'P';
            char chA2 = 'A';
            char chV = 'V';
            char chE = 'E';
            char chL = 'L';
            char chI = 'I';

            Console.WriteLine(Char.IsLower(chA1)); // False
            Console.WriteLine(Char.IsUpper(chA1)); // true

            //Covert char to string
            Char chX = 'X';
            String newX = chX.ToString();
            Console.WriteLine(newX);

            /*STRINGS*/
            // String represents a series of characters
            string hello = "Hello";
            string name = "Appaveli";
            Console.WriteLine(hello);
            Console.WriteLine(name);

            //Concatenate hello and name string
            Console.WriteLine(hello + name);

            //Concatenate hello and name string appending double quotes to create space between the two strings
            Console.WriteLine(hello + " " + name);

            //Escape swquences with tab(\t)
            Console.WriteLine(hello + "\t" + name);

            //Escape swquences with new line(\n)
            Console.WriteLine(hello + "\n" + name);

            String s1 = "1";
            String s2 = "2";
            String s3 = "3";
            String s4 = "4";
            String s5 = "5";
            String s6 = "6";

            String rowOne = s1 + "\t" + s2 + "\t" + s3;
            String rowTwo = s4 + "\t" + s5 + "\t" + s6;
            String rowsAndColumns = rowOne + "\n" + rowTwo;

            // 2x3 columns
            Console.WriteLine(rowsAndColumns);
        }
    }
}
