using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment2Part2NumberApp
{
    internal class MainMenu
    {
        Functions fun = new Functions();

        public void Menu()
        {
            Intro();
            AskingForInput();
            UsingNumbers();
        }
        public void Intro()
        {
            WriteLine("Welcome to Program");
            WriteLine("This program will Add, Subtract, Multiply, and Divide two number you pick\n");
        }

        public void AskingForInput()
        {
            fun.AssignNumber();
            WriteLine( "The numebers you have picked are " + fun.NumInput1 + " " + fun.NumInput2 + "\n");
        }

        public void UsingNumbers()
        {
            fun.AddNumber();
            fun.SubtractNumber();
            fun.MultiplyNumber();
            fun.DivideNumber();
        }
    }
}
