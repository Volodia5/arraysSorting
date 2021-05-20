using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int [0];
            Console.Write("Введите кол-во элементов в массиве : ");
            int countElements = int.Parse(Console.ReadLine());
            int[] tempArray = new int [countElements];
            arr = tempArray;
            for (int i = 0 ; i < arr.Length ; i++)
            {
                arr[i] = random.Next(0 , 100 + 1);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0 ; i < arr.Length ; i++)
            {
                for (int j = i; j < arr.Length ; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                        Console.Write(arr[i] + " ");
                    } 
                }
            }
                Console.ReadKey();
        }
    }
}
