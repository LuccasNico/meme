using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Classe
    {
        int x;
        int y;

        public Classe(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void algo()
        {
            Console.WriteLine(x + "\n " + y);
        }
    }
}
