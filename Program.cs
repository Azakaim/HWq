using System;

namespace Home_Test
{
    class Program
    {
        /// <summary>
        /// Метод разделения строки на слова 
        /// </summary>
        /// <param name="Arr">строка ввода через пробел</param>
        /// <returns></returns>
        static string[] SplitMethod(string Arr)
        {
            string [] arr_1 ;
            arr_1 = Arr.Split(' ');
            return arr_1;
            
        }
        /// <summary>
        /// Метод меняющий слова в обратной последовательности
        /// </summary>
        /// <param name="Arr">строковый массив</param>
        /// <returns></returns>
        static string[] ReverseMethod(string[] Arr) 
        {
            string[] arr2 = new string[Arr.Length];
            for (int i = Arr.Length - 1, j = 0 ; i >= 0;j++,i--)
            {
                arr2[j] = Arr[i];
            }
            
            return arr2;
        }
        static void Main(string[] args)
        {
            string Arr = Console.ReadLine();

            foreach (var item in ReverseMethod(SplitMethod(Arr)))
            {
                Console.Write(item + " ");
            } 
        }
    }
}
