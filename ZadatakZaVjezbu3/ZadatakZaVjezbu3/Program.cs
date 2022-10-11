using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaVjezbu3
{
    internal class Program
    {

        class Sort
        {
            public void QuickSort(int[] array, int left, int right)
            {
                int temp;
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    for (int i = 0; i <= array.Length - 2; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            temp = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = temp;
                        }
                    }
                }
                array[0] = left;
                array[array.Length - 1] = right;
                return;

            }
        }

        static void Main(string[] args)
        {

             int left, right;
            Sort sort = new Sort();
            int[] array = { 2, 4, 3, 7, 6, 6, 8, 1, 9 };
            left = array[0];
            right=array[array.Length - 1];
            sort.QuickSort(array,left,right);
           
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();

        }
    }
}
