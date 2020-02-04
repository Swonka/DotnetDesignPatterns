using System;

namespace DesignPatternsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            //Factory Method example
            /*
            FactoryMethod fm = new FactoryMethod();
            fm.start();
            */

            //
            CommandPattern cp = new CommandPattern();
            cp.start();

        }
    }
}
