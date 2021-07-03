
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        private CalculateMethods.Calculate calculate { get; set; } = new CalculateMethods.Calculate();
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
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";
            try
            {
                return Ok(calculate.sun(firstNumber, secondNumber));
            }
            catch (Exception ex)
            {
                return BadRequest($"Invalid input Call Method => {fullMethodName}; Exception Message => {ex.Message}");
            }
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult subtraction(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";
            try
            {
                return Ok(calculate.subtraction(firstNumber, secondNumber));
            }
            catch (Exception ex)
            {
                return BadRequest($"Invalid input Call Method => {fullMethodName}; Exception Message => {ex.Message}");
            }
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult multiplication(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";
            try
            {
                return Ok(calculate.multiplication(firstNumber, secondNumber));
            }
            catch (Exception ex)
            {
                return BadRequest($"Invalid input Call Method => {fullMethodName}; Exception Message => {ex.Message}");
            }
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult division(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";

            try
            {
                return Ok(calculate.division(firstNumber, secondNumber));
            }
            catch (Exception ex)
            {
                return BadRequest($"Invalid input Call Method => {fullMethodName}; Exception Message => {ex.Message}");
            }
        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult media(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";

            try
            {
                return Ok(calculate.media(firstNumber, secondNumber));
            }
            catch (Exception ex)
            {
                return BadRequest($"Invalid input Call Method => {fullMethodName}; Exception Message => {ex.Message}");
            }
        }

        [HttpGet("squareRoot/{firstNumber}")]
        public IActionResult squareRoot(string firstNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";

            try
            {
                return Ok(calculate.squareRoot(firstNumber));
            }
            catch (Exception ex)
            {
                return BadRequest($"Invalid input Call Method => {fullMethodName}; Exception Message => {ex.Message}");
            }
        }
        #endregion
    }
}
