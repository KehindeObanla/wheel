using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelTest
{
    // wheel of fourtune 
    // this is done
    //does this work
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        public static string Wheel(char c, string result,char[] userIn)
        {
            string WordTobeGuessed = "meet";
            char[] array = WordTobeGuessed.ToCharArray();
            int length = WordTobeGuessed.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != c )
                    {
                        if (Char.IsLetter(userIn[i]) == false)
                        {
                            userIn[i] = '-';
                        }
                    }
                    else
                    {
                        userIn[i] = c;

                    }
                }
            result = new string (userIn);
            Console.Write(result);
            Console.ReadLine();
            return result;
        }
        public static string Wheel(string s,string result)
        {

            return s;
        }
        public static void menu()
        {
            int option;
            string result = "";
            string WordTobeGuessed = "meet";
            char[] userIn = new char[WordTobeGuessed.Length];
            StringBuilder userInput = new StringBuilder(WordTobeGuessed.Length);
            do
            {
                Console.WriteLine("wheel of foutune");
                Console.WriteLine("Do you want to guess a letter or do you want to write the whole letter");
                Console.WriteLine("[1] press 1 to guess a letter");
                Console.WriteLine("[2] press 2 to guess the whole word");
                Console.WriteLine("[0] press 0 to Quit the  game");
                Console.WriteLine("-------------------------------------");
                Console.Write("Enter an option:");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine(" enter a character:  ");
                            Char c = char.Parse(Console.ReadLine());
                            result = Wheel(c, result,userIn);
                        } while (result.Equals(WordTobeGuessed) == false);
                        break;
                    case 2:
                        Console.WriteLine("Enter a Word:   ");
                        string s = Console.ReadLine();
                        Wheel(s,result);
                        break;
                    default:
                        break;
                }
                Console.Clear();

            } while (option != 0);
        }
   
    }
}
