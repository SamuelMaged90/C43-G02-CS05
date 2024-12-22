using System.Xml;

namespace Demo
{
    //1- Class 
    //2- Struct 
    //3- interface 
    //4- Enum
    internal class Program
    {
        /// Note the default should be in the last in parameters
        public static void PrintShape(int count , string shape ="=) ")
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(shape);
            }
        }
        public static void Swap_By_Value(int x,int y)
        {
            int temp = x; 
            x = y; 
            y = temp;
        }
        public static void Swap_By_Ref(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static int Sum_Array_By_Value(int[] arr)
        {
            int sum = 0; 
            if (arr is not null)
            {
                arr[0] = 100;
                for(int i = 0;i < arr.Length;i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        public static int Sum_Array_By_Ref(ref int[] arr)
        {
            int sum = 0;
            if (arr is not null)
            {
                arr[0] = 100;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static void Sum_Out(int x ,int y,out int sum , out int sub )
        {
            sum = x +y;
            sub = x - y;
        }

        public static int SumOfArray(params int[] arr)
        {
            int sum = 0;
            if(arr is not null)
            {
                for(int i = 0;i<arr.Length ; i++)
                {
                    sum+= arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region Array Methods
            #region Class Member Methods
            //int[] numbers = { 2, 5, 6, 5, 1 };
            //Array.Sort(numbers);

            //Array.Reverse(numbers);

            //Array.Clear(numbers);

            //Array.Clear(numbers, 0, 2);

            //int index = Array.IndexOf(numbers, 5);
            //Console.WriteLine(index);

            //Console.WriteLine(Array.LastIndexOf(numbers,5));

            //Array.CreateInstance(typeof(int), 6); 

            //Console.WriteLine(numbers.GetHashCode());
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Array.Resize(ref numbers, 7);
            //Console.WriteLine(numbers.GetHashCode());
            //foreach(int i in numbers)   
            //    { 
            //    Console.WriteLine(i);
            //}   

            //int[] arr01 = new int[] { 1, 2, 3, 4, 5,6};
            //int[] arr02 = new int[7];

            //Array.Copy(arr01, arr02, 2);
            //foreach (int i in arr02)
            //{
            //    Console.WriteLine(i);
            //}
            //Array.Copy(arr01, 2, arr02, 2, 3);
            //foreach (int i in arr02)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion
            #region Object Member Methods
            //int[] arr = { 1, 2, 3, 4 };
            //Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.GetValue(1));
            //arr.SetValue(100,0);
            //Console.WriteLine(arr[0]);
            #endregion







            #endregion

            #region 2D Array Using 1 For Loop

            //int[,] arr = new int[2, 3];
            //for (int i = 0; i < arr.Length; )
            //{
            //    Console.WriteLine($"Row {i / arr.GetLength(1)} Column {i%arr.GetLength(1)}");
            //    bool parsed = int.TryParse( Console.ReadLine(), out arr[i / arr.GetLength(1), i % arr.GetLength(1)] );
            //    if (parsed)
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        i = i; 
            //    }
            //}
            //Console.Clear();

            //for (int i = 0;i < arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i / arr.GetLength(1), i % arr.GetLength(1)]);
            //}
            #endregion

            #region Fucntions

            #region ProtoType
            //PrintShape(10,"S");
            //PrintShape();
            //PrintShape(shape: "G");
            //PrintShape(5);

            //Console.WriteLine("/*\\");
            //Console.WriteLine("Hello\tWorld");
            //Console.WriteLine("Hello\rSaSa");
            //Console.WriteLine("Hello\bWorld");
            //Console.WriteLine("Hello 'World ");
            //Console.WriteLine("Hello \"World ");
            //Console.WriteLine(@"Sasa \ Maged \ Sasa");

            //int num = 123456;
            //Console.WriteLine($"My num is {{{num}}} ");


            #endregion

            #region Value Type Parameter [Passing By Value]
            //int a = 10;
            //int b = 20;
            //Console.WriteLine($"a = {a} b = {b}");
            //Swap_By_Value(a, b);
            //Console.WriteLine($"a = {a} b = {b}");

            #endregion
            #region Value Type Parameter [ Passing By Ref ]
            //int a = 10;
            //int b = 20;
            //Console.WriteLine($"a = {a} B = {b}");
            //Swap_By_Ref(ref a, ref b);
            //Console.WriteLine($"a = {a} B = {b}");

            #endregion

            #region Reference Type Parameter [Passing By Value]
            //int[] numbers = new int[3] {1,2,3};
            //Console.WriteLine(numbers[0]);
            //int result = Sum_Array_By_Value(numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion
            #region Reference Type Parameter [Passing By Value]
            //int[] numbers = new int[3] { 1, 2, 3 };
            //Console.WriteLine(numbers[0]);
            //int result = Sum_Array_By_Ref(ref numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion

            #region out parameter 
            //int x = 10 , 
            //    y = 10;

            //int sum ;
            //int sub ;
            //Sum_Out(x, y,out sum,out sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            #endregion

            #region Params
            //int x = 10;
            //int y = 10;
            //int z = 10;
            //int d = 10;

            //Console.WriteLine(SumOfArray(x,y,d,z));
            #endregion

            object x = 123456;
            Console.WriteLine(x);
            Console.WriteLine(x.GetHashCode());
            x = "Sasa";
            Console.WriteLine(x);
            Console.WriteLine(x.GetHashCode());
            x = 'A';
            Console.WriteLine(x);
            Console.WriteLine(x.GetHashCode());

            #endregion
        }
    }
}
