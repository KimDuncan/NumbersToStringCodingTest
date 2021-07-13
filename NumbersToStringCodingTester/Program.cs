using System;

namespace NumbersToStringCodingTester
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("47.50");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(47.50));

      Console.WriteLine("5");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(5));

      Console.WriteLine("205.31");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(205.31));

      Console.WriteLine(" 4000.0");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(4000.0));

      Console.WriteLine("1.01");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(1.01));
    
      Console.WriteLine("999999.99");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(999999.99));


      Console.WriteLine("888888.88");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(888888.88));

      Console.WriteLine("1888888.88");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(1888888.88));

      Console.WriteLine("0");
      Console.WriteLine(NumbersToStringCodingTest.Logic.Converter.ConvertAmount(0));


      Console.ReadLine();

    }
  }
}
