using System;
using System.Collections;
using System.IO;

namespace Hash_Table
{
    class Program
    {
        public static Hashtable myHash = new Hashtable();
        static void Main(string[] args)
        {
            try
            {
                int loopCount = 0;
                int Count = 0;
                string[] file = File.ReadAllLines(@"C:\Users\Hybr1\OneDrive\Desktop\Textfilesforassignmet\assignment 4\file1.txt");
                foreach (string line in file)
                {
                    loopCount++;
                    Count++; // Gives a uniqe key for each entry
                    myHash.Add(Count, line);
                }
                Console.WriteLine("O(n) completed in " + loopCount + " steps");
                dupValues();
            }
            catch 
            {
                Console.WriteLine("A error has occured");
            }
        }
        public static void dupValues()
        {
            int loopCount = 0;
            string j = "";
            int Count = 0;
            foreach (var values in myHash.Values)
            {
                loopCount++;
                string k = Convert.ToString(values);
                foreach (var valuess in myHash.Values)
                {
                    loopCount++;
                    string i = Convert.ToString(valuess);
                    loopCount++;
                    if (k == i)
                    {
                        loopCount++;
                        Count++;
                        j = (Convert.ToString(Count) + " " + valuess + "s");
                    }
                    break;
                }
            }
            Console.WriteLine(j);
            if (Count == 0)
            {
                Console.WriteLine("The text file is empty");
            }
            Console.WriteLine("O(2^n) completed in " + loopCount + " steps"); // Exponential
            // Time is increased for ammount of records
        }
    }
}
