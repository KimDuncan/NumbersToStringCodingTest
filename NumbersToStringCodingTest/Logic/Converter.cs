using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersToStringCodingTest.Logic
{
  public class Converter
  {
      private static String[] units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
    private static String[] tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    public static String ConvertAmount(double amount)
    {
      try
      {
        Int64 amount_int = (Int64)amount;
        Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);

        if (amount_int > 999999)
        {
          return "Number bigger than the max number 999999.99";
        }

        if (amount_dec == 0)
        {
          return Convert(amount_int) + " Dollars";
        }
        else
        {
          return Convert(amount_int) + " Dollars and " + Convert(amount_dec) + " Cents";
        }
      }
      catch (Exception e)
      {
        throw new InvalidCastException("Amount cant be converted", 40);
      }
    }

    public static String Convert(Int64 i)
    {
      if (i < 20)
      {
        return units[i];
      }
      if (i < 100)
      {
        return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");
      }
      if (i < 1000)
      {
        return units[i / 100] + " Hundred"
                + ((i % 100 > 0) ? " And " + Convert(i % 100) : "");
      }
      if (i < 100000)
      {
        return Convert(i / 1000) + " thousand"
        + ((i % 1000 > 0) ? " " + Convert(i % 1000) : "");
      }
      if (i < 1000000)
      {
        return Convert(i / 100000) + " Hundred"
                + ((i % 100000 > 0) ? " " + Convert(i % 100000) : "");
      }
      return "";
    }
  }
}
