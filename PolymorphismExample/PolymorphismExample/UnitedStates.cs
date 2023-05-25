using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class UnitedStates : World
    {

        public override void TypeOfCurrency()
        {
            Console.WriteLine("The United States uses USD.");
        }

    }
}
