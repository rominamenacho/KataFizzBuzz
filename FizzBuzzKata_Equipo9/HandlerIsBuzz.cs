using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata_Equipo9
{
    public class HandlerIsBuzz : Handler
    {
        public override object ProcessNumber(int number)
        {


            if ( number % 5 == 0)
            {
                return "Buzz";
            }


                return number;

        }
    }
}
