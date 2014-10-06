using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    interface Adder
    {
        int getS();

        int getC();
    }

    class FullAdder: Adder
    {
        int inA, inB, inC;
        int outS, outC;

        public FullAdder(int A, int B, int C)
        {
            inA = A;
            inB = B;
            inC = C;
            outS = A ^ B ^ C;
            outC = (A & B) | ((A ^ B) & C);
        }

        public int getS()
        {
            return outS;
        }

        public int getC()
        {
            return outC;
        }
    }
}
