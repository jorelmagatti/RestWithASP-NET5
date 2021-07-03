
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        #region private parameters
        private readonly ILogger<CalculatorController> _logger;
        #endregion

        #region Constructor
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }
        #endregion

        #region Get Actions
        [HttpGet("sun/{firstNumber}/{secondNumber}")]
        public IActionResult sun(string firstNumber, string secondNumber)
        {
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                    return Ok(sum.ToString()); ;
                }
                else
                {
                    return BadRequest("Invalid input");
                }
            }
            catch (Exception)
            {
                return BadRequest("Invalid input");
            }
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult subtraction(string firstNumber, string secondNumber)
        {
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                    return Ok(sum.ToString()); ;
                }
                else
                {
                    return BadRequest("Invalid input");
                }
            }
            catch (Exception)
            {
                return BadRequest("Invalid input");
            }
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult multiplication(string firstNumber, string secondNumber)
        {
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                    return Ok(sum.ToString()); ;
                }
                else
                {
                    return BadRequest("Invalid input");
                }
            }
            catch (Exception)
            {
                return BadRequest("Invalid input");
            }
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult division(string firstNumber, string secondNumber)
        {
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                    return Ok(sum.ToString()); ;
                }
                else
                {
                    return BadRequest("Invalid input");
                }
            }
            catch (Exception)
            {
                return BadRequest("Invalid input");
            }
        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult media(string firstNumber, string secondNumber)
        {
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var sum = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                    return Ok(sum.ToString()); ;
                }
                else
                {
                    return BadRequest("Invalid input");
                }
            }
            catch (Exception)
            {
                return BadRequest("Invalid input");
            }
        }

        [HttpGet("squareRoot/{firstNumber}")]
        public IActionResult squareRoot(string firstNumber)
        {
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");


                if (IsNumeric(firstNumber))
                {
                    var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(firstNumber);
                    return Ok(sum.ToString()); ;
                }
                else
                {
                    return BadRequest("Invalid input");
                }
            }
            catch (Exception)
            {
                return BadRequest("Invalid input");
            }
        }
        #endregion

        #region Utils Methods
        private bool IsNumeric(string strNumber)
        {
            try
            {
                double number;
                bool isNumber = double.TryParse(strNumber, 
                                                System.Globalization.NumberStyles.Any,
                                                 System.Globalization.NumberFormatInfo.InvariantInfo, out number);

                return isNumber;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            try
            {
                decimal decimalValue;
                if(decimal.TryParse(strNumber, out decimalValue))
                    return decimalValue;
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion
    }
}
