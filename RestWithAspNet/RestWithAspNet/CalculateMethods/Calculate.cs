using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithAspNet.CalculateMethods
{
    public class Calculate
    {
        #region Calculate Methods
        public decimal sun(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (Utils.IsNumeric(firstNumber) && Utils.IsNumeric(secondNumber))
                    return Utils.ConvertToDecimal(firstNumber) + Utils.ConvertToDecimal(secondNumber);
                else
                    return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public decimal subtraction(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (Utils.IsNumeric(firstNumber) && Utils.IsNumeric(secondNumber))
                    return Utils.ConvertToDecimal(firstNumber) - Utils.ConvertToDecimal(secondNumber);
                else
                    return 0;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public decimal multiplication(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";
            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (Utils.IsNumeric(firstNumber) && Utils.IsNumeric(secondNumber))
                    return Utils.ConvertToDecimal(firstNumber) * Utils.ConvertToDecimal(secondNumber);
                else
                    return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public decimal division(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";

            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (Utils.IsNumeric(firstNumber) && Utils.IsNumeric(secondNumber))
                {
                    if (firstNumber == "0")
                        throw new Exception($"invalid input param => {firstNumber}");
                    if (secondNumber == "0")
                        throw new Exception($"invalid input param => {secondNumber}");
                    else
                        return Utils.ConvertToDecimal(firstNumber) / Utils.ConvertToDecimal(secondNumber);
                }
                else
                    throw new Exception($"invalid input");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public decimal media(string firstNumber, string secondNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";

            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (secondNumber.Contains("."))
                    secondNumber = secondNumber.Replace(".", ",");

                if (Utils.IsNumeric(firstNumber) && Utils.IsNumeric(secondNumber))
                    return (Utils.ConvertToDecimal(firstNumber) + Utils.ConvertToDecimal(secondNumber)) / 2;
                else
                    throw new Exception($"invalid input");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double squareRoot(string firstNumber)
        {
            string fullMethodName = $"{MethodBase.GetCurrentMethod().ReflectedType.FullName}.{MethodBase.GetCurrentMethod().Name}";

            try
            {
                if (firstNumber.Contains("."))
                    firstNumber = firstNumber.Replace(".", ",");

                if (Utils.IsNumeric(firstNumber))
                    return Math.Sqrt((double)Utils.ConvertToDecimal(firstNumber));
                else
                    throw new Exception($"invalid input");

            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
