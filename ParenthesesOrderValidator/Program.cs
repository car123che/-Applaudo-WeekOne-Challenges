using System.Reflection.Metadata.Ecma335;

namespace ParenthesesOrderValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests
            Console.WriteLine("--- Test One ---");
            string inputOne = ""; //false
            bool testOne = ParenthesesOrderValidator(inputOne);
            Console.WriteLine("Result: {0}", testOne);

            Console.WriteLine("\n--- Test Two ---");
            string inputTwo = "asdfas"; //false
            bool testTwo = ParenthesesOrderValidator(inputTwo);
            Console.WriteLine("Result: {0}", testTwo);

            Console.WriteLine("\n--- Test  Three---");
            string inputThree = "()"; //true
            bool testThree = ParenthesesOrderValidator(inputThree);
            Console.WriteLine("Result: {0}", testThree);

            Console.WriteLine("\n--- Test Four ---");
            string inputFour = "((()))(a(fdsafas)fsdf)"; //true
            bool testFour = ParenthesesOrderValidator(inputFour);
            Console.WriteLine("Result: {0}", testFour);

            Console.WriteLine("\n--- Test Five ---");
            string inputFive = "))()"; //false
            bool testFive = ParenthesesOrderValidator(inputFive);
            Console.WriteLine("Result: {0}", testFive);

            Console.WriteLine("\n--- Test Six ---");
            string inputSix = ")"; //false
            bool testSix = ParenthesesOrderValidator(inputSix);
            Console.WriteLine("Result: {0}", testSix);

            Console.WriteLine("\n--- Test Seven ---");
            string inputSeven = "(() asdf ))"; //false
            bool testSeven = ParenthesesOrderValidator(inputSeven);
            Console.WriteLine("Result: {0}", testSeven);
        }

        static bool ParenthesesOrderValidator(string input)
        {
            int inputLength = input.Length;
            //Validate Input Lenght
            if(inputLength >= 0 && inputLength <= 100) 
            {
                //Validate if the input contains '(' or ')'
                if (input.Contains('(')  || input.Contains(')'))
                {
                    return ParenthesesOrder(input);
                }
                else
                {
                    Console.WriteLine("Input: '{0}'. Input does not contain parentheses", input);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Input Length: {0}. Input length must be greater or equal than 0 and lower or equal than 100", inputLength);
                return false;
            }
        }

        private static bool ParenthesesOrder(string input)
        {
            List<char> parentheses = new List<char>();
            //Read Input character by character
            foreach (var character in input)
            {
                if(character == '(')
                {
                    parentheses.Add(character);
                }
                else if(character == ')')
                {
                    int listLength = parentheses.Count;
                    if(listLength>0)
                    {
                        parentheses.Remove('(');
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            //Validate that there are no '(' missing
            if (parentheses.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}