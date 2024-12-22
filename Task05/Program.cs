namespace Task05
{
    internal class Program
    {

        static void PassByValue(int x)
        {
            x++; 
        }
        static void PassByRef(ref int x)
        {
            x++;
        }
        static void RefPassByValue(int[] arr)
        {
            if (arr is not null)
            {
                arr[0] = 50;
            }
        }
        static void RefPassByRef(ref int[] arr)
        {
            if (arr is not null)
            {
                arr[0] = 50;
            }
        }
        static void Sum_Sub(int x,int y ,out int sum , out int sub )
        {
            sum = x + y;
            sub = x - y;
        }
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            // 0 and 1 are not prime numbers -  Even numbers greater than 2 are not prime
            if (number <= 1 || number % 2 == 0) 
                return false; 
            if (number == 2) 
                return true; // 2 is a prime number
           
            for (int i = 3; i <= Math.Sqrt(number); i += 2) // Check odd divisors up to the square root
            {
                if (number % i == 0)
                    return false; 
            }

            return true; 
        }
        static void MinMaxArray(ref int[] arr, ref int min , ref int max)
        {
            if (arr is not null)
            {
                min = arr[0];
                max = arr[0];
                for(int i = 1; i < arr.Length; i++)
                {
                    if(arr[i] < min)
                    {
                        min = arr[i];
                    }
                    if(arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
            }
        }
        static long Factorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
        static string ChangeChar(string input, int position, char newChar)
        {
            if (input is not null && input.Length > position)
            {
                char[] charArray = input.ToCharArray();

                charArray[position] = newChar;

                string output = new string(charArray);

                return output;
            }
            else
            {
                string output = "Not Valid";
                return output;
            }
        }
        static void Main(string[] args)
        {
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example 
            /*
             * Passing by Value :
             * When a value type parameter is passed by value, a copy of the variable's value is made and used inside the method. Modifications to the parameter inside the method do not affect the original variable.
             * Passing by Reference : 
             * When a value type parameter is passed by reference, the method works with the actual variable rather than a copy. Any changes made to the parameter inside the method will directly affect the original variable.
             */
            //int b = 5;
            //Console.WriteLine(b);
            //PassByValue(b);
            //Console.WriteLine(b);
            //PassByRef(ref b);
            //Console.WriteLine(b);
            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*
             * Passing Reference Type Parameters by Value : 
             * When a reference type parameter is passed by value, a copy of the reference to the object is passed. While the reference itself cannot be changed, 
             * the underlying object it refers to can be modified. Changes made to the object's properties or fields inside the method will affect the original object.
             * Passing Reference Type Parameters by Reference : 
             * When a reference type parameter is passed by reference (using the ref keyword), the actual reference itself is passed. This allows the method to reassign the reference to point to a different object, 
             * in addition to modifying the original object's properties or fields.
             */
            //int[] arr = { 100, 50};
            //Console.WriteLine(arr[0]);
            //RefPassByValue(arr);
            //Console.WriteLine(arr[0]);
            //RefPassByRef(ref arr);
            //Console.WriteLine(arr[0]);

            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.WriteLine("Enter num 1");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.WriteLine("Enter num 2");
            //int.TryParse(Console.ReadLine(), out int num2);

            //int sum , sub;
            //Sum_Sub(num1, num2, out sum,out sub);
            //Console.WriteLine($"Sum is { sum}");
            //Console.WriteLine($"Sub is {sub}");

            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.WriteLine(SumOfDigits(220));
            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine(IsPrime(8));
            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = new int []{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int min =0, max =0;
            //MinMaxArray(ref arr, ref min ,ref max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            #endregion

            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine(Factorial(7));
            #endregion

            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            
            Console.WriteLine(ChangeChar("sasa", 4, 's'));
            #endregion
        }
    }
}
