using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelWork
{
    
    class Program
    {
        public const string WordTobeGuessed = "meet";
       public static char[] userIn = new char[WordTobeGuessed.Length];
       public static char[] userInputFromFill = new char[WordTobeGuessed.Length];
        static void Main(string[] args)
        {
            menu();
        }
        public static string WheelForWords(string s, char[] userIn)
        {
            string result = new string (userIn);
            return s;
        }
        public static string WheelForChar(char c, string result, char[] userIn)
        {
            if (result.Equals(WordTobeGuessed) == true)
            {
                Console.WriteLine(" Game Over");
                Console.ReadLine();
                menu();
            }
            char[] WordToGuess = WordTobeGuessed.ToCharArray();
            for (int i = 0; i < WordToGuess.Length; i++)
            {
                if (WordToGuess[i]!=c)
                {
                    if (Char.IsLetter(userIn[i]) == false)
                    {
                        userIn[i] = '-';
                    }
                }
                else if (c == userIn[i])
                {
                    Console.WriteLine("letter already guessed");
                    menu();
                }
               
               else
               {
                   userIn[i] = c;
               }
            }
            result = new string(userIn);
            Console.Write(result);
            Console.ReadLine();
            menu();
            return result;

        }
        //public static char[] FillUserInput(char[] userInput)
        //{
        //    for(int i=0; i<userInput.Length; i++)
        //    {
        //        userInput[i] = '-';
        //    }
        //    return userInput;
        //}
        public static void menu()
        {
            int option;
            string result = "";
            result = result.ToLower();
            Console.WriteLine("wheel of foutune");
            do
            {
                Console.WriteLine("[1] press 1 to guess a letter");
                Console.WriteLine("[2] press 2 to guess the whole word");
                Console.WriteLine("[0] press 0 to Quit the  game");
                Console.WriteLine("-------------------------------------");
                Console.Write("Enter an option:");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                            Console.WriteLine();
                             do
                             {
                                 Console.WriteLine("Enter a character:  ");
                                 Char c = char.Parse(Console.ReadLine());
                                 result = WheelForChar(c, result, userInputFromFill);
                             } while (result.Equals(WordTobeGuessed) == false);
                               break;
                    case 2:
                            Console.WriteLine();
                            Console.WriteLine("Enter a Word:   ");
                            string s = Console.ReadLine();
                            WheelForWords(s, userInputFromFill);
                            break;
                    default:
                        break;
                }
                Console.Clear();

            } while (option != 0);
        }
    }
}
