using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment2Part2NumberApp
{
    internal class Functions
    {
        public double NumInput1 { get; set; }
        public double NumInput2 { get; set; }
        public double NumAnswer { get; set; }

        public void AssignNumber()
        {
        string FirstNumber = "1";
        string SecondNumber = "1";
            WriteLine("Pick First Number");
            FirstNumber = ReadLine();
            WriteLine("Pick Second Number");
            SecondNumber = ReadLine();
            this.NumInput1 = Convert.ToDouble(FirstNumber);
            this.NumInput2 = Convert.ToDouble(SecondNumber);
        }

        public void AddNumber()
        {
            NumAnswer = NumInput1 +NumInput2;
            ForegroundColor= ConsoleColor.Green;
            WriteLine("The answer if Added is ");
            WriteLine(NumAnswer + "\n");

        }

        public void SubtractNumber()
        {
            NumAnswer= NumInput1 - NumInput2;
            ForegroundColor= ConsoleColor.Red;
            WriteLine("The answer if Subtractred ");
            WriteLine(NumAnswer + "\n");
        }

        public void MultiplyNumber()
        {
            NumAnswer = NumInput1 * NumInput2;
            ForegroundColor= ConsoleColor.Blue;
            WriteLine("The answer if Multiplied ");
            WriteLine(NumAnswer + "\n");
        }
        public void DivideNumber()
        {
            NumAnswer= NumInput1 / NumInput2;
            ForegroundColor= ConsoleColor.Yellow;
            WriteLine("The answer if Divided ");
            WriteLine(NumAnswer + "\n");
        }
    }
}
