using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace NumbersToStringCodingTest.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class NumberToStringController : Controller
  {


    private readonly ILogger<NumberToStringController> _logger;

    public NumberToStringController(ILogger<NumberToStringController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public Models.NumberToStringModel Get(string number)
    {
      double amount;

      if (Double.TryParse(number, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture,  out amount))
      {
        var numberToStringModel = new Models.NumberToStringModel();
        numberToStringModel.Number = amount;
        numberToStringModel.Text = Logic.Converter.ConvertAmount(amount);
        return numberToStringModel;
      }
      return null;
    
    }
  }
}
