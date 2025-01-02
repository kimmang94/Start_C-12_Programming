using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] products = new int[5];

            string[] names = new string[1000];

            products[0] = 100;
            products[1] = 200;

            int book = products[0];
            int sum = products[0] + products[1];

            string text = "Hello World";
            char ch1 = text[0];
            char ch2 = text[1];

            Console.WriteLine(ch1);
            Console.WriteLine(ch2);

            // 다차원 배열

            int[,] arr2 = new int[10, 5]; // 2차원 배열
            short[,,] arr3 = new short[8, 3, 10]; // 3차원 배열

            int[,] arr4 = new int[2, 3]
            { 
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,,] arr5 = new int[2, 3, 4]
            {
                {
                    {1,2,3,4 },
                    {5,6,7,8 },
                    {9,10,11,12 },
                },

                {
                {13,14,15,16 },
                {17,18,19,20 },
                {21,22,23,24 },
                }
            };
        
            
        }
    }
}
