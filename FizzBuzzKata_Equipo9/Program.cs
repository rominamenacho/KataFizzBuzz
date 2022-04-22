using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata_Equipo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handlerFizzBuzz = new HandlerIsFizzBuzz();
            Handler handlerFizz = new HandlerIsFizz();
            Handler handlerBuzz = new HandlerIsBuzz();
        
            handlerFizzBuzz.SetNext(handlerFizz);
            handlerFizz.SetNext(handlerBuzz);
         


            FizzBuzz _fizzBuzzCalculator = new FizzBuzz();
            _fizzBuzzCalculator.getList(handlerFizzBuzz);

        }
    }
}
