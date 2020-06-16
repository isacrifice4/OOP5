using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{

        class Empl : Person
        {
            private string company;

            public Empl(string name, string surname, string comp)
                : base(name, surname)
            {
                company = comp;
            }

            public string Company
            {
                get { return company; }
                set { company = value; }
            }
            public void DisplayE()
            {
                Console.WriteLine(Name + "  " + Surname + "  " + Company);
            }
        }
    }

