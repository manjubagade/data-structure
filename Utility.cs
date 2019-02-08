//-----------------------------------------------------------------------
// <copyright file=" Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections;
    using System.IO;

    /// <summary>
    /// this class is used to run all the programs
    /// </summary>

    public class Utility
    {
        /// <summary>
        /// the queue object is created
        /// </summary>
        public Queue queue = new Queue();

        /// <summary>
        /// Files for taking input of unordered list.
        /// </summary>
        /// <returns>the path of a folder</returns>
        public string FileForUnoderedList()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\underredList.txt";
            return path;
        }

        public string ResultForUnderedlist()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\ResultList.txt";
            return path;
        }

        public string FileForOrderedList()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\DataStructure\DataStrucure\orderedList.txt";
            return path;
        }

        public string ResultForlist()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\ResultListOrder.txt";
            return path;
        }

        public int GetInt()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        public double GetDouble()
        {
            double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }

        public int DayOfWeek(int year, int month)
        {
            string[] week = { "Sunday", "monday", "tuesday", "wednesday", "thrusday", "friday", "saturday" };
            int y = year;
            int m = month;
            int d = 1;
            int y0 = y - ((14 - m) / 12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + (12 * ((14 - m) / 12)) - 2;
            int d0 = (d + x + (31 * m0 / 12)) % 7;
            return d0;

        }
             public ArrayList PrimeNum()
        {
            //// creating the arraylist objects
            ArrayList spn = new ArrayList();
            ////looping the start from 1 to 1000
            for (int i = 1; i <= 1000; i++)
            {
                int count = 0;
                ////looping from 1 to 1000
                for (int j = 1; j <= 1000; j++)
                {
                    ////condition check i and j 
                    if ((i % j) == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    spn.Add(i);
                }
            }
            return spn;
        }
        public static void WriteToFile(string s, string path)
        {
            StreamWriter sw = new StreamWriter(@path, append: true);
            sw.WriteLine(s);
            sw.Close();
        }
        public static string ReadfromFile(string path)
        {
            StreamReader sr = new StreamReader(@path);
            string read = sr.ReadLine();
            sr.Close();
            return read;
        }
        public static void WriteToFile1(string s, string path)
        {
            StreamWriter sw = new StreamWriter(@path, append: true);
            sw.WriteLine(s);
            sw.Close();
        }
        public static void ClearFile(string path)
        {
            File.WriteAllText(path, "");
        }

        public static int[] StringToIntArray(string read)
        {
            int count = 0, temp = 0, i = 0;
            foreach (char c in read)
            {
                if (c == ' ') count++;
            }

            int[] filetointarray = new int[count + 1];

            foreach (char c in read)
            {
                if (c != ' ')
                {
                    temp = temp * 10 + Convert.ToInt32(c.ToString());
                    //  Console.Write("temp is " + temp);
                }
                else
                {
                    filetointarray[i++] = temp;
                    temp = 0;
                }
            }
            filetointarray[i] = temp;
            Console.WriteLine();
            return filetointarray;
        }

        public static string IsExpression(string expression)
        {
            string word = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'$#@!~`:;?";
            bool flag = false;
            while (flag == false)
            {
                if (expression.Contains(" "))
                {
                    Console.WriteLine("Expression should not contain space please try again");
                    expression = Console.ReadLine();
                }

                foreach (char c in word)
                {
                    ////if (expression.Contains(c))
                    {
                        Console.WriteLine("Expression should not contain alphabets or special characters please try again");
                        expression = Console.ReadLine();
                        break;
                    }
                }

                flag = true;
            }

            return expression;
        }
        public static bool IsPrime(int number)
        {
            int counter;
            bool flag = true;

            switch (number)
            {
                case 0:
                    return false;
                case 1:
                    return false;
                case 2:
                    return true;
            }

            for (counter = 2; counter <= number / 2; counter++)
            {
                //// if counter is  not prime
                if (number % counter == 0)
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
        public static bool Anagram(string string1, string string2)
        {
            int i, flag = 0;
            //// single digit elements are mot anagrams
            if (string1.Length == 1 || string2.Length == 1)
            {
                return false;
            }

            if (string1.Length != string2.Length)
            {
                ////System.out.println("Strings are not anagrams");
                return false;
            }

            char[] aS1 = new char[string1.Length];
            char[] aS2 = new char[string2.Length];

            for (i = 0; i < string1.Length; i++)
            {
                aS1[i] = string1[i];
            }

            for (i = 0; i < string2.Length; i++)
            {
                aS2[i] = string2[i];
            }
            //// sorting each string and will compare each element at the same index
            //aS1 = SortChar(aS1);
            //aS2 = SortChar(aS2);
            Array.Sort(aS1);
            Array.Sort(aS2);
            for (i = 0; i < string1.Length; i++)
            {
                if (aS1[i] != aS2[i])
                {
                    //// if not same
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int IsInteger(string input)
        {
            //// testting data sructures
            if (int.TryParse(input, out int num))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                while (int.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered an integer number please try again");
                    input = Console.ReadLine();
                }

                return Convert.ToInt32(input);
            }
        }
        public static string HashingFunctionFile()
        {
            string path = "C:\\Users\\Admin\\Desktop\\manjupgm\\DataStructure\\DataStrucure\\Hashmap.txt";
            return path;
        }
    }
}
