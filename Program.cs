/********************************************************/
/*                                                      */
/* Written by Daniel Paul Seavers                       */
/* This is distributed under the MIT license            */
/* This program provides a variety of validation checks */
/*                                                      */
/********************************************************/
using System;

namespace Type_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose check");
            string check = Console.ReadLine();
            if (check == "presence")
            {
                presence();
            }
            else
            {
                if (check == "length")
                {
                    length();
                }
                else
                {
                    if (check == "range")
                    {
                        range();
                    }
                    else
                    {
                        if (check == "lookup")
                        {
                            lookup();
                        }
                    }
                }
            }
        }
        static void presence()
        {
            Console.WriteLine("Enter a string.");
            string word = Console.ReadLine();
            Console.WriteLine("Enter a character");
            string character = Console.ReadLine();
            char i;
            bool presence = false;
            while (presence == false)
            {
                if (char.TryParse(character, out i))
                {
                    if (word.Contains(character))
                    {
                        Console.WriteLine("Contains the character");
                        presence = true;
                    }
                    else
                    {
                        Console.WriteLine("Doesn't contain character");
                        presence = true;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a character");
                    character = Console.ReadLine();
                }
            }
        }
        static void length()
        {
            Console.WriteLine("Enter a string");
            string word = Console.ReadLine();
            Console.WriteLine("Enter the length");
            string l = Console.ReadLine();
            int i;
            bool length = false;
            while (length == false)
            {
                if(int.TryParse(l,out i))
                {
                    i = Convert.ToInt32(l);
                    if (word.Length == i)
                    {
                        Console.WriteLine("Is the correct length");
                        length = true;
                    }
                    else
                    {
                        Console.WriteLine("Is not the correct length");
                        length = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer for the length");
                    l = Console.ReadLine();
                }
            }
        }
        static void range()
        {
            Console.WriteLine("Enter the beginning of the range");
            string beginning = Console.ReadLine();
            Console.WriteLine("Enter the end of the range");
            string end = Console.ReadLine();
            Console.WriteLine("Enter the data");
            string data = Console.ReadLine();
            int i;
            bool range = false;
            while (range == false)
            {
                if (int.TryParse(beginning, out i))
                {
                    int B = Convert.ToInt32(beginning);
                    if (int.TryParse(end, out i))
                    {
                        int E = Convert.ToInt32(end);
                        if (int.TryParse(data, out i))
                        {
                            i = Convert.ToInt32(data);
                            if (B < i)
                            {
                                if (i < E)
                                {
                                    range = true;
                                    Console.WriteLine("The data is within the range");
                                }
                                else
                                {
                                    range = true;
                                    Console.WriteLine("The data is not within the range");
                                }
                            }
                            else
                            {
                                range = true;
                                Console.WriteLine("The data is not within the range");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter an integer for the data");
                            data = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer for the end of the data");
                        end = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer for the beginning of the data");
                    beginning = Console.ReadLine();
                }
            }
        }
        static void lookup()
        {
            Console.WriteLine("Enter the length of your data");
            string len = Console.ReadLine();
            int i;
            if (int.TryParse(len, out i))
            {
                i = Convert.ToInt32(len);
                for (int j; j <= i; j++)
                {
                    Console.WriteLine("Enter your data");

                }
            }
        }
    }
}
