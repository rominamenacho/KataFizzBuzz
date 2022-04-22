using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata_Equipo9
{
   public abstract class Handler
    {
        protected Handler next;

        public void SetNext(Handler handler)
        {
            next = handler;
        }

        public abstract Object ProcessNumber(int number);

    }
}
