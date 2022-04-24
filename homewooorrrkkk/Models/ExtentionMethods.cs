using System;
using System.Collections.Generic;
using System.Text;

namespace homewooorrrkkk.Models
{
    static class ExtentionMethods
    {
        public  static bool IsEven(this int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsOdd(this int a)
        {
            if (a%1==0)
            {
                return true;
            }
            return false;
        }
        public static bool ISDigit(string check)
        {
            bool checker = false;
            foreach (var item in check)
            {
                if (char.IsDigit(item))
                {
                    checker = true;
                    return checker;
                }
            }
            return checker;
        }
        public static int[] GetValueIndexes(this int [] array,int b)
        {
            int[] arr = { };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==b)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }

        public static int [] GetValueIndexes1(this string a,char b)
        {
            int[] arr = { };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]==b)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }
    }
}
