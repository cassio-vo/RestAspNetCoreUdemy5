using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{first}/{second}")]
        public IActionResult Get(string first, string second)
        {
            if (IsNumeric(first) && IsNumeric(second))
            {
                var sum = ConvertToDceimal(first) + ConvertToDceimal(second);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input");
        }

        private decimal ConvertToDceimal(string strNumber)
        {
            decimal number;
            if (decimal.TryParse(strNumber, out number))
                return number;

            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
    }
}
