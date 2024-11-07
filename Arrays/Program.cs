using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {
//        It is collection of similar data elements / objects
//        Array index starts from zero
//        We need to set or assign size of an array at compile time
//        We can have 1D array, 2D array , Jagged array in C#

        static void Main(string[] args)
        {
            //int[] arr = new int[5];
            //arr1[0] =1;

            int[] arr1 = {1,2,3,4,5};
            double[] arr2 = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            float[] arr3 = { 1.344f, 5.555f,3.4444f};

            string[] str1 = { "Pratik", "Rupesh", "Avadhut", "Sanjyot", "Yash" };

            // print all the elements
            //1. using for loop    2. using foreach loop

            Console.WriteLine("-----------------Using for loop----------------");
            //arr1
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr1[i]}");
            }
            Console.WriteLine("---------------------------------------");
            //arr2

            for (int i=0;i<arr2.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr2[i]}");
            }
            Console.WriteLine("---------------------------------------");
            //arr3
            for (int i=0; i<arr3.Length ; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr3[i]}");
            }
            Console.WriteLine("---------------------------------------");
            //str1 array
            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {str1[i]}");
            }

            Console.WriteLine("---------------------------------------");
            // using foreach loop

            Console.WriteLine("--------- Using foreach loop --------------------");
            foreach (int i in arr1)
            { 
              Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------------------");
            foreach (double  d in arr2)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("---------------------------------------");
            foreach (float f in arr3)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("---------------------------------------");
            foreach (string s in str1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------------------------------");

        }
    }
}
