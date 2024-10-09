using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._6Static
{
    internal static class TextAmomator
    {
        public static void Animate(string text, int delay)  
        {
            foreach (var item in text)
            {
                Console.Write(item);
                Thread.Sleep(delay);
            }
            Console.Write('\n');
        }
    }
}
