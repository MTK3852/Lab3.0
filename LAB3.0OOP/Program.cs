using System;

namespace LAB3._0OOP
{
    public class Program
    {
       public static void Main(string[] args)
        {
           
                Console.WriteLine("Enter Line:");
                string line = Console.ReadLine();
                string reverseline = ReverseString(line);
                char[] amount = line.ToCharArray();
                int number = Number(amount);
                
                Console.WriteLine("ReversedLine: "+reverseline);
                Console.WriteLine("Amount of digits in line: "+number);

                Console.ReadKey();
            
           

        }
        public static string ReverseString(string line)
        {
            string reverseline="";
            for(int i=line.Length-1; i>=0;i--)
            {
                reverseline += line[i];
            }
            return reverseline;
        }
        public static int Number(char[]array)
        {
            int number=0;
           
            for(int i=0; i<array.Length;i++)
            {
                if(char.IsDigit(array[i]))
                {
                    number++;
                }
            }

            return number;
        }
    }
}
