using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    public class Multiplier
    {
        private long A, B;
        private int width, truncated;

        int[] arrA, arrB, arrS, arrC, arrV;

        public Multiplier(long A, long B, int width)
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

        public Multiplier(long A, long B, int width, int truncated)
            : this(A, B, width)
        {
            this.truncated = truncated;
        }

        public ulong Multiply()
        {
            Adder adder;
            ClearArrays();
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

        private void ClearArrays()
        {
            arrA.Initialize();
            arrB.Initialize();
            arrS.Initialize();
            arrC.Initialize();
            arrV.Initialize();
        }

        public ulong ShortMultiply()
        {
            Adder adder;
            ClearArrays();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width - 1; j++)
                {
                    if (i == 0)
                    {
                        if (j >= truncated)
                            adder = new HalfAdder(arrA[j + 1] & arrB[0], arrA[j] & arrB[1]);
                        else adder = null;
                    }
                    else if (i < truncated)
                    {
                        if (j >= truncated - i)
                        {
                            if (j == truncated - i)
                                adder = new HalfAdder(arrS[(i - 1) * (width - 1) + j + 1], arrA[j] & arrB[i + 1]);
                            else if (j < width - 2)
                                adder = new FullAdder(arrS[(i - 1) * (width - 1) + j + 1], arrC[(i - 1) * (width - 1) + j], arrA[j] & arrB[i + 1]);
                            else
                                adder = new FullAdder(arrA[j + 1] & arrB[i], arrC[i * (width - 1) - 1], arrA[j] & arrB[i + 1]);
                        }
                        else adder = null;
                    }
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
                            adder = new FullAdder(arrC[i * (width - 2)], arrS[i * (width - 2) + 1], arrS[i * (width - 2)]);     //last parameter added to perform rounding
                        else if (j < width - 2)
                            adder = new FullAdder(arrS[i * (width - 2) + j + 1], arrC[i * (width - 2) + j], arrC[i * (width - 1) + j - 1]);
                        else
                            adder = new FullAdder(arrA[j + 1] & arrB[i], arrC[i * (width - 1) - 1], arrC[i * (width - 1) + j - 1]);
                    }
                    if (adder != null)
                    {
                        arrS[i * (width - 1) + j] = adder.getS();
                        arrC[i * (width - 1) + j] = adder.getC();
                    }
                }
            }
            for (int k = 0; k < width - 1; k++)
            {
                arrV[k] = arrS[(width - 1) * (width - 1) + k];
            }
            arrV[width - 1] = arrC[width * (width - 1) - 1];
            return NumUtils.BinArrayToDec(arrV);// << width;
        }
    }
}
