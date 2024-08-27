using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(Add(5,7));
            // System.Console.WriteLine(IsEven(711));
           //System.Console.WriteLine(MaxOfThree(10,6,9));
          // System.Console.WriteLine(StringLength("tree"));
           // System.Console.WriteLine(StartsHello("Hello World"));
           // System.Console.WriteLine(ReverseString("Hello World"));
           //System.Console.WriteLine(Factorial(7));
           //System.Console.WriteLine(IsPrime(7));
           System.Console.WriteLine(Fibonacci(7));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            // TODO: Implement this method.
            int num = a + b;
            return num;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            // TODO: Implement this method.
            int num = number % 2;
            if (num == 0){
                return true;
            }
            else{
                return false;
            }
            
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.
            int num = Math.Max(a,Math.Max(b,c));
            return num;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            // TODO: Implement this method.
            int num = s.Length;
            return num;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            // TODO: Implement this method.
            bool starts = s.StartsWith("Hello");
            return starts;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            // TODO: Reverse the charArray.
           string outputString = "";
            for(int i = charArray.Length - 1; i >= 0; i--){
                outputString += charArray[i];
            }
            return outputString;
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            // TODO: Calculate the factorial.
            for (int i = n -1; i > 0; i--){
                n *= i;
            }

            return n;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for(int i = number -1; i >= 0; i--){
                if(number % i == 0) { return false;}
                else {return true;}
                
            }
            // TODO: Return the correct boolean value.
            return false;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            int current = 0;
            int previousNum = 1;
            int TwoPrevious = 0;
            // TODO: Calculate the nth Fibonacci number.
            for(int i = 2; i <= n; i++){
                current = previousNum +TwoPrevious;
                TwoPrevious = previousNum;
                previousNum = current;
            }
            return current;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                // TODO: Find the largest number in the array.
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            // TODO: Determine if the string is a palindrome.
            return false;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            // TODO: Calculate the sum of the array's elements.
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            // TODO: Count how many times character c appears in string s.
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            // TODO: Concatenate the two strings with a space in between.
            return "";
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            // TODO: Swap the first and last characters and return the modified string.
            return "";
        }
    }
}
