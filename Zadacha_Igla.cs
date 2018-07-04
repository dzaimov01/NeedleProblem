using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadacha_Igla
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split(new char[]{}).Select(int.Parse).ToArray();
            int C = firstLine[0];
            int N = firstLine[1];
            int[] Line1;
            
            do
                Line1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (Line1.Length != C);
            int[] Line2;
            do
            {
                Line2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            } while (Line2.Length!=N);
            
            List<int> list = new List<int>();
            foreach (var item in Line2)
            {
                list.Add(Search(Line1, item));
            }
            Console.WriteLine(string.Join(" ",list));
        }

        private static int Search(int[] Line1, int item)
        {
            for (int i = 0; i < Line1.Length; i++)
            {
                if (item <= Line1[i])
                {
                    int c = i - 1;
                    int br = 0;
                    for (int b = 0; b < i; b++)
                    {
                        if (Line1[c] == 0)
                        {
                            c--;
                            br++;
                        }
                        else
                            break;
                    }
                    return i - br;
                }
            }
            int k = 0;
            for (int b = Line1.Length-1; b >= 0; b--)
            {
                if (Line1[b] == 0)
                {
                    k++;
                }
                else
                    break;
            }
            return Line1.Length - k;
        }
    }
}