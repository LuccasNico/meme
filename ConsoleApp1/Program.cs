using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.IO;    


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World! \nIn a file Uwu.";
            if (File.Exists("Texto.txt")){
                File.WriteAllText("Texto.txt", writeText);
                File.ReadAllText("Texto.txt");
            }
            else {
                File.Create("Texto.txt");
                File.WriteAllText("Texto.txt", writeText);
                File.ReadAllText("Texto.txt");
            }
            


                Console.ReadKey();
        }
    }
}