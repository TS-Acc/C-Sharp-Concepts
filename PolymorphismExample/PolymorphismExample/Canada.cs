using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Canada : World
    {

        public override void TypeOfCurrency()
        {
            Console.WriteLine("Canada uses CAD.");
        }

    }
}
