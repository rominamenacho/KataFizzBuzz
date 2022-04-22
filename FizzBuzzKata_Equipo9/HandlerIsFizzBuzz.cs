using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata_Equipo9
{
    public class HandlerIsFizzBuzz : Handler
    {

        public override object ProcessNumber(int number)
        {
            Object result = number;

            if ((number % 3 == 0 ) && (number % 5 == 0))
            {
                result = "FizzBuzz";
            }
            else
            {
                result = next.ProcessNumber(number);
            }

            return result;
        }
    }
}
