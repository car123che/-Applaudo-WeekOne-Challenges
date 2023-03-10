namespace RomanNumeralRep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TESTS
            Console.WriteLine("--- Test One --- ");
            int inputNumberOne = 0;
            string resultOne = RomanNumeralRep(inputNumberOne);
            Console.WriteLine("Input: {0}.  Output: {1}", inputNumberOne, resultOne);

            Console.WriteLine("\n--- Test Two --- ");
            int inputNumberTwo = 1998;
            string resultTwo = RomanNumeralRep(inputNumberTwo);
            Console.WriteLine("Input: {0}.  Output: {1}", inputNumberTwo, resultTwo);

            Console.WriteLine("\n--- Test Three --- ");
            int inputNumberThree = 166;
            string resultThree = RomanNumeralRep(inputNumberThree);
            Console.WriteLine("Input: {0}.  Output: {1}", inputNumberThree, resultThree);

            Console.WriteLine("\n--- Test Four --- ");
            int inputNumberFour = 3999;
            string resulFour = RomanNumeralRep(inputNumberFour);
            Console.WriteLine("Input: {0}.  Output: {1}", inputNumberFour, resulFour);

            Console.WriteLine("\n--- Test Five --- ");
            int inputNumberFive = 4000;
            string resultFive = RomanNumeralRep(inputNumberFive);
            Console.WriteLine("Input: {0}.  Output: {1}", inputNumberFive, resultFive);
        }

        static string RomanNumeralRep(int inputNumber)
        {
            string result = "";

            if(inputNumber > 0 && inputNumber < 4000)
            {
                int[] valuesArray = new int[13] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                string[] symbolsArray = new string[13] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
                int i = 0;

                while( inputNumber > 0) 
                {
                    if( inputNumber - valuesArray[i] >= 0 )
                    {
                        inputNumber = inputNumber - valuesArray[i];
                        result += symbolsArray[i];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else
            {
                result = "Input must be greater than 0 and lower than 4000";
            }

            return result;
        }
    }
}