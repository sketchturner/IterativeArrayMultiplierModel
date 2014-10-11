using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    static class NumUtils
    {
        public static string DecToBin(string dec)
        {
            long val;
            if (!long.TryParse(dec, out val)) return String.Empty;
            return Convert.ToString(val, 2);
        }

        internal static int[] DecToBinArray(long A)
        {
            string tmp = Convert.ToString(A, 2);
            char[] arr = tmp.Reverse().ToArray();
            return Array.ConvertAll(arr, n => (int)Char.GetNumericValue(n));
        }

        internal static ulong BinArrayToDec(int[] arr)
        {
            ulong res;
            res = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                res = (res << 1) + (ulong)arr[i];
            }
            return res;
        }
    }
}
