using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1108
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat haha = new Cat();
            Cat kitty = new Cat("kitty", "하얀색");
            kitty.Meow();
        }
    }
}
