using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    internal class Task1
    {
        public virtual void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(value);
        }
    }
    internal class Task1Green : Task1
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }
    }
    internal class Task1Magenta : Task1
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(value);
        }

    }
}
