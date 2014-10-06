using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    class Multiplier
    {
        private int A, B, width;

        int[] arrA, arrB, arrS, arrC, arrV;

        public Multiplier(int A, int B, int width)
        {
            this.A = A;
            this.B = B;
            this.width = width;
            arrA = new int[width];
            arrB = new int[width];
            arrS = new int[width * (width - 1)];
            arrC = new int[width * (width - 1)];
            arrV = new int[width << 1];
            NumUtils.DecToBinArray(A).CopyTo(arrA, 0);
            NumUtils.DecToBinArray(B).CopyTo(arrB, 0);
        }

        internal int Multiply()
        {
            Adder adder;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width - 1; j++)
                {
                    if (i == 0)
                        adder = new HalfAdder(arrA[j + 1] & arrB[0], arrA[j] & arrB[1]);
                    else if (i < width - 1)
                    {
                        if (j < width - 2)
                            adder = new FullAdder(arrS[(i - 1) * (width - 1) + j + 1], arrC[(i - 1) * (width - 1) + j], arrA[j] & arrB[i + 1]);
                        else
                            adder = new FullAdder(arrA[j + 1] & arrB[i], arrC[i * (width - 1) - 1], arrA[j] & arrB[i + 1]);
                    }
                    else
                    {
                        if (j == 0)
                            adder = new HalfAdder(arrC[i * (width - 2)], arrS[i * (width - 2) + 1]);
                        else if (j < width - 2)
                            adder = new FullAdder(arrS[i * (width - 2) + j + 1], arrC[i * (width - 2) + j], arrC[i * (width - 1) + j - 1]);
                        else
                            adder = new FullAdder(arrA[j + 1] & arrB[i], arrC[i * (width - 1) - 1], arrC[i * (width - 1) + j - 1]);
                    }
                    arrS[i * (width - 1) + j] = adder.getS();
                    arrC[i * (width - 1) + j] = adder.getC();
                }
            }
            arrV[0] = arrA[0] & arrB[0];
            for (int k = 1; k < width * 2; k++)
            {
                if (k < width + 1)
                    arrV[k] = arrS[(k - 1) * (width - 1)];
                else if (k == width * 2 - 1)
                    arrV[k] = arrC[width * (width - 1) - 1];
                else
                    arrV[k] = arrS[(width - 1) * (width - 1) + k - width];
            }
            return NumUtils.BinArrayToDec(arrV);
        }
    }
}
