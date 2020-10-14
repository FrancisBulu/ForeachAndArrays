using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Robben", "Timothy", "Mohamed", "Franck", "Emre", "Khadija" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[5]);
            //Console.WriteLine(names[6]);

            foreach (string name in names) // names is de 'collection' en name is de 'item'
            {
                Console.WriteLine(name);
            }


        }
    }
}
