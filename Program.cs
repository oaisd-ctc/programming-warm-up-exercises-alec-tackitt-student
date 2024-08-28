using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =  {2,4,6,7,11,2,4};
        //     System.Console.WriteLine(Add(5,7));
        //     System.Console.WriteLine(IsEven(711));
        //    System.Console.WriteLine(MaxOfThree(10,6,9));
        //   System.Console.WriteLine(StringLength("tree"));
        //    System.Console.WriteLine(StartsHello("Hello World"));
        //    System.Console.WriteLine(ReverseString("Hello World"));
        //    System.Console.WriteLine(Factorial(7));
        //    System.Console.WriteLine(IsPrime(7));
        //    System.Console.WriteLine(Fibonacci(12));
        //    System.Console.WriteLine(LargestInArray(array));
        //    System.Console.WriteLine(IsPalindrome("Racecar"));
        //    System.Console.WriteLine(ArraySum(array));
        //    System.Console.WriteLine(CharCount("racecar", 'c'));
        //    System.Console.WriteLine(ConcatenateStrings("hello", "World"));
        //    System.Console.WriteLine(SwapEnds("Hello"));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
          
            int num = a + b;
            return num;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
           
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
          
            int num = Math.Max(a,Math.Max(b,c));
            return num;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
           
            int num = s.Length;
            return num;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
        
            bool starts = s.StartsWith("Hello");
            return starts;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
           string outputString = "";
           // starting at end of given string and assinging those chars at the begining of reversed string
            for(int i = charArray.Length - 1; i >= 0; i--){
                outputString += charArray[i];
            }
            return outputString;
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            // start at one below given number and multiply by that number, repeat to 1
            for (int i = n -1; i > 0; i--){
                n *= i;
            }

            return n;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {

            if (number <= 1) return false;
            //start at 1 below given int, if no remaider from divison, return false (not prime), if gets down to 1, return true
            for(int i = number -1; i >= 0; i--){
                if(number % i == 0) { return false;}
                else {return true;}
                
            }
           
            return false;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            int current = 0;
            int previousNum = 1;
            int TwoPrevious = 0;
            // adding two prevoius numbers up to given int
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
            return numbers.Max();
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            //creating reversed string
            s = s.ToLower();
            string c = ReverseString(s);
            //checking on if strings are equal
            if (c == s){ 
                return true;
            }
            else {
                return false;
            }
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            // add each number in array to total
            foreach (int num in numbers){
                sum += num;
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            // loop through the string and if char = given char, add to count
            foreach(char l in s){
                if (l == c){
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            string newString = str1 + " " + str2;
            // TODO: Concatenate the two strings with a space in between.
            return newString;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            //get first and last char
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            //make a changable array
            char[] charArray = s.ToCharArray();
            //assign new array values
            charArray[0] = lastChar;
            charArray[charArray.Length -1] = firstChar;
            return new string(charArray);
        }
    }
}
