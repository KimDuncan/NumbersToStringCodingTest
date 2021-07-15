using Microsoft.Extensions.Logging;
using NumbersToStringCodingTest.Controllers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NumbersToStringCodingTestXUnit
{
  public class UnitTest
  {
    private readonly ILogger<NumberToStringController> _logger;

    [Fact]
    public void Get_NumberToTextTest_Success()
    {
      string number = "12.66";

      double amount;

      Double.TryParse(number, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out amount);

      var numberToStringController = new NumberToStringController(_logger);

      var actionResult = numberToStringController.Get(number);
      Assert.NotNull(actionResult);

      var viewResult = Assert.IsType<NumbersToStringCodingTest.Models.NumberToStringModel>(actionResult);

      Assert.NotNull(viewResult);
      Assert.Equal(amount, viewResult.Number);
    }

    [Fact]
    public void Get_NumberToTextTest_Fail_text()
    {
      var number = "dddd";

      double amount;

      Double.TryParse(number, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out amount);

      var numberToStringController = new NumberToStringController(_logger);

      var actionResult = numberToStringController.Get(number);
      Assert.Null(actionResult);
    }

    [Fact]
    public void Get_NumberToTextTest_Fail_ToBigNumber()
    {
      var number = "9999999.99";
      double amount;

      Double.TryParse(number, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out amount);

      var numberToStringController = new NumberToStringController(_logger);

      var actionResult = numberToStringController.Get(number);
      Assert.NotNull(actionResult);

      var viewResult = Assert.IsType<NumbersToStringCodingTest.Models.NumberToStringModel>(actionResult);

      Assert.NotNull(viewResult);
      Assert.Equal(amount, viewResult.Number);

      Assert.Equal("Number bigger than the max number 999999.99", viewResult.Text);
    }
  }
}
