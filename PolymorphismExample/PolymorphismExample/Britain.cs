using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Britain : World
    {

        public override void TypeOfCurrency()
        {
            Console.WriteLine("Britain uses the British Pound.");
        }

    }
}
