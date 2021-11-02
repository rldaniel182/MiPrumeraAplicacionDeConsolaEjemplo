using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listatest = new List<string>();
            listatest.Add("1");
            listatest.Add("2");
            listatest.Add("3");
            listatest.Add("4");
            listatest.Add("6");
            listatest.Add("6");
            listatest.Add("7");

            // este es un comentario
            string combindedString = string.Join(",", listatest);
            Console.WriteLine(combindedString);
            Console.ReadLine();
        }
    }
}
