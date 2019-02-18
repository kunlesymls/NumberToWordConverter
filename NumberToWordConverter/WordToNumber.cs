using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberToWordConverter
{
    public static class WordToNumber
    {
        /// <summary>
        /// This method expose the use of the class.
        /// Supply the number  to be converted and the currency extension of your choice
        /// </summary>
        /// <param name="input">Value to be converterd e.g 5023</param>
        /// <returns></returns>
        public static string GetWordConverter(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                input = input.Trim().ToLower();
                var stringArray = input.Split(' ', ',').ToList();

                var numberSb = new StringBuilder();
                numberSb.Append(CheckForNegativity(stringArray[0].ToLower()));
                var newInput = RemoveNegativity(stringArray);

                bool isTen = false;
                bool isHundred = false;
                int count = 0;

                foreach (var number in stringArray)
                {
                    if (number == "hundred")
                    {
                        isHundred = true;
                        numberSb.Append("00");
                    }
                    else
                    {
                        if (isHundred)
                        {
                            numberSb.Replace("00", "");
                            var hundredString = CheckForSingleValue(number);
                            if (hundredString == "")
                                numberSb.Append(ConvertTwoDigit(number));                         

                            isHundred = false;
                        }
                        else
                        {
                            isTen = CheckForTens(number);
                            if (count != stringArray.Count - 1)
                            {
                                if (isTen)
                                {
                                    var newString = ConvertTwoDigit(number);
                                    newString = newString.Remove(newString.Length - 1);
                                    numberSb.Append(newString);
                                }
                                else
                                {
                                    numberSb.Append(ConvertTwoDigit(number));
                                }
                            }
                            else
                            {
                                numberSb.Append(ConvertTwoDigit(number));
                            }
                        }
                    }
                    count += 1;
                }
                return numberSb.ToString();

            }
            return "Please type in a value";

        }

        private static string CheckForNegativity(string input)
        {
            if (input.StartsWith("minus", System.StringComparison.InvariantCultureIgnoreCase))
            {
                return "-";
            }
            return "";
        }

        private static List<string> RemoveNegativity(List<string> input)
        {
            if (input.First().Equals("minus"))
            {
                input.RemoveAt(0);
            }
            return input;
        }


        private static string RemoveZeroFromTheBegining(string input) => input.Remove(0, 1);

        private static string ConvertTwoDigit(string num)
        {
            switch (num)
            {
                case "zero":
                    return "0";

                case "one":
                    return "1";

                case "two":
                    return "2";

                case "three":
                    return "3";

                case "four":
                    return "4";

                case "five":
                    return "5";

                case "six":
                    return "6";

                case "seven":
                    return "7";

                case "eight":
                    return "8";

                case "nine":
                    return "9";

                case "ten":
                    return "10";

                case "eleven":
                    return "11";

                case "twelve":
                    return "12";

                case "thirteen":
                    return "13";

                case "fourteen":
                    return "14";

                case "fifteen":
                    return "15";

                case "sixteen":
                    return "16";

                case "seventeen":
                    return "17";

                case "eighteen":
                    return "18";

                case "nineteen":
                    return "19";

                case "twenty":
                    return "20";

                case "thirty":
                    return "30";

                case "Forty":
                    return "40";

                case "fifty":
                    return "50";

                case "sixty":
                    return "60";

                case "seventy":
                    return "70";

                case "eighty":
                    return "80";

                case "ninety":
                    return "90";
                case "and":
                    return "";

                case "dot":
                case "point":
                    return ".";

                default:
                    return $"The spelling of {num} is wrong";
            }
        }

        private static bool CheckForTens(string num)
        {
            switch (num)
            {
                case "twenty":
                case "thirty":
                case "Forty":
                case "fifty":
                case "sixty":
                case "seventy":
                case "eighty":
                case "ninety":
                    return true;

                default:
                    return false;
            }
        }

        private static string CheckForSingleValue(string num)
        {
            switch (num)
            {

                case "one":
                    return "01";

                case "two":
                    return "02";

                case "three":
                    return "03";

                case "four":
                    return "04";

                case "five":
                    return "05";

                case "six":
                    return "06";

                case "seven":
                    return "07";

                case "eight":
                    return "08";

                case "nine":
                    return "09";
                case "ten":
                    return "10";

                case "eleven":
                    return "11";

                case "twelve":
                    return "12";

                case "thirteen":
                    return "13";

                case "fourteen":
                    return "14";

                case "fifteen":
                    return "15";

                case "sixteen":
                    return "16";

                case "seventeen":
                    return "17";

                case "eighteen":
                    return "18";

                case "nineteen":
                    return "19";

                case "twenty":
                    return "20";

                case "thirty":
                    return "30";

                case "Forty":
                    return "40";

                case "fifty":
                    return "50";

                case "sixty":
                    return "60";

                case "seventy":
                    return "70";

                case "eighty":
                    return "80";

                case "ninety":
                    return "90";

                case "and":
                    return "";

                default:
                    return "";
            }
        }
    }
}

