using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Person p = new Person("Oleg", "Olegov");
                Empl emp = new Empl("Ivan", "Yalynin", "Kupc");

                p.Display();
                emp.DisplayE();
                Console.ReadKey();
            }
        }
    }
}
