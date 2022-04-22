using FizzBuzzKata_Equipo9;
using NUnit.Framework;
using System.Collections.Generic;



namespace TestFizzBuzzKata
{
    public class Tests
    {
        FizzBuzz fb = new FizzBuzz();
        List<object> numbers = new List<object>();

        Handler handlerFizzBuzz = new HandlerIsFizzBuzz();
        Handler handlerFizz = new HandlerIsFizz();
        Handler handlerBuzz = new HandlerIsBuzz();


        [Test]
        public void Test_get_1_when_value_is_1()
        {
            handlerFizzBuzz.SetNext(handlerFizz);
            handlerFizz.SetNext(handlerBuzz);
          

            numbers = fb.getList(handlerFizzBuzz);
            Assert.AreEqual(1, numbers[0]);
        }

        [Test]
        public void Test_get_Fizz_when_value_is_3()
        {
            handlerFizzBuzz.SetNext(handlerFizz);
            handlerFizz.SetNext(handlerBuzz);
          

            numbers = fb.getList(handlerFizzBuzz);
            Assert.AreEqual("Fizz", numbers[2]);
        }

        [Test]
        public void Test_get_Buzz_when_value_is_5()
        {
            handlerFizzBuzz.SetNext(handlerFizz);
            handlerFizz.SetNext(handlerBuzz);
            


            numbers = fb.getList(handlerFizzBuzz);
            Assert.AreEqual("Buzz", numbers[4]);
        }
        [Test]
        public void Test_get_FizzBuzz_when_value_are_3_and_5()
        {
            handlerFizzBuzz.SetNext(handlerFizz);
            handlerFizz.SetNext(handlerBuzz);
        


            numbers = fb.getList(handlerFizzBuzz);
            Assert.AreEqual("FizzBuzz", numbers[14]);
        }


        [Test]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(4, ExpectedResult = 4)]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(6, ExpectedResult = "Fizz")]
        [TestCase(7, ExpectedResult = 7)]
        [TestCase(8, ExpectedResult = 8)]
        [TestCase(9, ExpectedResult = "Fizz")]
        [TestCase(10, ExpectedResult = "Buzz")]
        [TestCase(11, ExpectedResult = 11)]
        [TestCase(12, ExpectedResult = "Fizz")]
        [TestCase(13, ExpectedResult = 13)]
        [TestCase(14, ExpectedResult = 14)]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(16, ExpectedResult = 16)]
        [TestCase(17, ExpectedResult = 17)]
        [TestCase(18, ExpectedResult = "Fizz")]
        [TestCase(19, ExpectedResult = 19)]
        [TestCase(20, ExpectedResult = "Buzz")]
        public object Test_correct_values_for_20_numbers(int n)
        {
            handlerFizzBuzz.SetNext(handlerFizz);
            handlerFizz.SetNext(handlerBuzz);
            numbers = fb.getList(handlerFizzBuzz);
            

            return numbers[n-1];
        }
    }
}