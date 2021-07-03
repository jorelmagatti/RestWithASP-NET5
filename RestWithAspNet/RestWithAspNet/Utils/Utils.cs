using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNet
{
    public static class Utils
    {
        #region Utils Methods
        /// <summary>
        /// Verifica se a string contem um valor Numerico
        /// </summary>
        /// <param name="strNumber">string com valor a ser verificado</param>
        /// <returns>retorna um boolean de acorod com a validação se o valor é um numerico</returns>
        public static bool IsNumeric(string strNumber)
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

        /// <summary>
        /// Converte uma string com valor numero em Decimal
        /// </summary>
        /// <param name="strNumber">string com valor a ser convertido</param>
        /// <returns>retornar um valor double apos conversão</returns>
        public static decimal ConvertToDecimal(string strNumber)
        {
            try
            {
                decimal decimalValue;
                if (decimal.TryParse(strNumber, out decimalValue))
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
