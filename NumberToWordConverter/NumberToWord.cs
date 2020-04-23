using System;

namespace NumberToWordConverter
{
    public static class NumberToWord
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">Value to be converterd e.g 5023</param>
        /// <param name="currency">Currency extensions of your choice e.g Dollar </param>
        /// <param name="unit"> currency extension e.g kobo or cent </param>
        /// <returns></returns>
        public static string CurrencyFormat(double doubleinput, string currency = "Naira", string unit = "Kobo")
        {
            return WordConverter.ConverterToCurrency(doubleinput, currency, unit);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">Value to be converterd e.g 5023</param>
        /// <param name="currency">Currency extensions of your choice e.g Dollar </param>
        /// <param name="unit"> currency extension e.g kobo or cent </param>
        /// <returns></returns>
        public static string CurrencyFormat(decimal decimalinput, string currency = "Naira", string unit = "Kobo")
        {
            return WordConverter.ConverterToCurrency(decimalinput, currency, unit);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">Value to be converterd e.g 5023</param>
        /// <param name="currency">Currency extensions of your choice e.g Dollar </param>
        /// <param name="unit"> currency extension e.g kobo or cent </param>
        /// <returns></returns>
        public static string CurrencyFormat(string input, string currency = "Naira", string unit = "Kobo")
        {
            return WordConverter.ConverterToCurrency(input, currency, unit);
        }

        /// <summary>
        /// This method expose the use of the class.
        /// Supply the number  to be converted and the currency extension of your choice
        /// </summary>
        /// <param name="input">Value to be converterd e.g 5023</param>
        /// <param name="separator">Currency extensions of your choice e.g Dollar </param>
        /// <returns></returns>
        public static string Convert(string input, string separator = "point")
        {
            return WordConverter.GetNumberConverter(input, separator);
        }

        /// <summary>
        /// This method expose the use of the class.
        /// Supply the number  to be converted and the currency extension of your choice
        /// </summary>
        /// <param name="input">Value to be converterd e.g 5023</param>
        /// <param name="separator">Currency extensions of your choice e.g Dollar </param>
        /// <returns></returns>
        public static string Convert(double input, string separator = "point")
        {
            return WordConverter.GetNumberConverter(input.ToString(), separator);
        }

        /// <summary>
        /// This method expose the use of the class.
        /// Supply the number  to be converted and the currency extension of your choice
        /// </summary>
        /// <param name="input">Value to be converterd e.g 5023</param>
        /// <param name="separator">Currency extensions of your choice e.g Dollar </param>
        /// <returns></returns>
        public static string Convert(decimal input, string separator = "point")
        {
            return WordConverter.GetNumberConverter(input.ToString(), separator);
        }

    }
}
