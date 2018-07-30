using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                CommandProcessor.AnalysisCode.AnalysisOneCode(userInput);
            } while (userInput != "exit");
        }
    }
}


