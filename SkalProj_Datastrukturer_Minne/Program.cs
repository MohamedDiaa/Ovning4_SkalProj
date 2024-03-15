using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {

            //1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir genomförbar.
            // Gjort

            //2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
            // när listelement antalet matchar Kapacitet.

            //3. Med hur mycket ökar kapaciteten?
            // den ökar med kapacitet antalet som vi sätt i konstrukotret i det här fallet 4
            // så 4 ,8, 16 ...

            //4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
            // det ökar bara när det behovs och det finns inge ledgia plats på listan

            //5.Minskar kapaciteten när element tas bort ur listan?
            // nej, det gör inte.

            //6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
            //när vi vet i förväg hur mycket element ska vi lägga in

            //switch(nav){...}
            Console.WriteLine(
"Please add + or remove from the list" +
" 0 to get back to Main menu. " +
"1 to print the array" +
"c to print the array count" +
"\nexample:");
            Console.WriteLine("+Adam and Adam would be added");
            Console.WriteLine("-Adam and Adam would be removed");

            List<string> theList = new List<string>(capacity: 4);
            do
            {

                string input = Console.ReadLine();
                try
                {
                    char nav = input[0];

                    switch (nav)
                    {

                        case '0':
                            return;
                        case '1':
                            foreach (string element in theList)
                            {
                                Console.Write(element + ", ");
                            }
                            Console.WriteLine();

                            break;
                        case 'c':
                            Console.WriteLine($"List Count {theList.Count}");
                            Console.WriteLine($"List Capacity {theList.Capacity}");
                            break;
                        case '+':
                            string value = input.Substring(1);
                            theList.Add(value);
                            break;
                        case '-':
                            string value2 = input.Substring(1);
                            theList.RemoveAll(element => element == value2);
                            break;
                        default:
                            Console.WriteLine("input of + and - is missing");
                            break;
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine("value is missing");
                }
            }
            while (true);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

