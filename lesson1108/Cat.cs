using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1108
{
    class Cat
    {
       string Name = " ";
        string Color =" ";
        public Cat(string _Name, string _Color) { Name = _Name; Color = _Color; }
        ~Cat()
        {
            Console.WriteLine();
        }
    }
}
