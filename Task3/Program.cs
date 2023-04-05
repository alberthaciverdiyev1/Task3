using System.Threading.Channels;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4 };
            InsertArray(ref numbers1, 4, 5, 6, 7, 5);
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);
            }
        }

        public static void InsertArray(ref int[] numbers1, params int[] numbers2)
        {
            int[] array = new int[numbers1.Length + numbers2.Length];
            for (int i = 0; i < numbers1.Length; i++)
            {
                array[i] = numbers1[i];
            }
            for (int i = 0; i < numbers2.Length; i++)
            {
                array[numbers1.Length + i] = numbers2[i];
            }
            numbers1 = array;
        }
    }
}