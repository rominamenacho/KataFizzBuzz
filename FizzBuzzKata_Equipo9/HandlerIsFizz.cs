using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata_Equipo9
{
    public class HandlerIsFizz : Handler
    {
        public override Object ProcessNumber(int number)
        {
            Object result= number;

            if (number % 3 == 0)
            {
                  result = "Fizz";
               
            }
            else
            {
               result =  next.ProcessNumber(number);
            }

          return result;
        }
    }
}
