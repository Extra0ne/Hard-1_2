using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Сортировка пузырьком");
            //Console.Write("Введите элементы массива: ");
            //var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            //var array = new int[parts.Length];
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(parts[i]);
            //}

            //Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", Bubble_sort.BubbleSort(array)));

            //Console.ReadLine();

            Console.WriteLine("Шейкерная сортировка");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }

            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", Shaker_sort.ShakerSort(array)));



            Console.ReadLine();
        }
    }
}
