using System;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Security;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Task1();
          Task2();
          Task3();
          Task4();
        }
        public static void Task1()
        {
            Console.WriteLine("vvedi chislo operand1:");
            double operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("vvedi chislo operand2:");
            double operand2 = double.Parse(Console.ReadLine());
            Console.WriteLine("vvedi chislovuyu operaciu:");
            string signs = Console.ReadLine();
            char sign = Convert.ToChar(signs);
            switch (sign)
                {
                case '+':
                    {
                        Console.WriteLine("operand1+operand2=" + (operand1 + operand2));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("operand1-operand2=" + (operand1 - operand2));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("operand1*operand2=" + (operand1 * operand2));
                        break;
                    }
                case '/':
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("operand1/operand2=" + (operand1 / operand2));
                            break;
                        }
                    }
        
            }
        }
        public static void Task2()
        {
            Console.WriteLine("Vvedite chislo:");
            string numberSTR = Console.ReadLine();
            int number = int.Parse(numberSTR);
            if ((number > 0) && (number < 14))
            {
                Console.WriteLine("The number in 0-14");
            }
           else if ((number > 15) && (number < 35))
            {
                Console.WriteLine("The number in 15-35");
            }
            else if ((number > 36) && (number < 50))
            {
                Console.WriteLine("The number in 36-50");
            }
            else if ((number > 51) && (number < 100))
            {
                Console.WriteLine("The number in 51-100");
            }
            else
            {
                Console.WriteLine("The unknown number");
            }
        }

        public static void Task3()
        {
                 
            Console.WriteLine("Hello! I'm a weather translator! I known 10 words. Write me one of them:");
            string word = Console.ReadLine();
            if (word == "sun")
            {
                Console.WriteLine("sun translate as солнце");

            }
            else if (word == "rain")
            {
                Console.WriteLine("rain translate as дождь");
            }

            else if (word == "snow")
            {
                Console.WriteLine("snow translate as снег");

            }
            else if (word == "wind")
            {
                Console.WriteLine("wind translate as ветер");

            }
            else if (word == "cloud")
            {
                Console.WriteLine("cloud translate as тучи");
            }
            else if (word == "fog")
            {
                Console.WriteLine("fog translate as туман");
            }
            else if (word == "hail")
            {
                Console.WriteLine("hail translate as град");
            }
            else if (word == "sleet")
            {
                Console.WriteLine("sleet translate as слякоть");
            }
            else if (word == "mist")
            {
                Console.WriteLine("mist translate as туман");
            }
            else if (word == "damp")
            {
                Console.WriteLine("damp translate as сыро");
            }
            else { Console.WriteLine("Sorry. I don't know this word. I'm young and just learning."); }
        
        }
        public static void Task4()
        {
            Console.WriteLine("Vvedite chislo:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("chislo chetnoe");
            }
            else { Console.WriteLine("chislo ne chetnoe"); }
        }
    }

}