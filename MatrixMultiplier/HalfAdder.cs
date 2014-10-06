using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    class HalfAdder: Adder
    {
        int inA, inB;
        int outS, outC;

        public HalfAdder(int A, int B)
        {
            inA = A;
            inB = B;
            outS = A ^ B;
            outC = A & B;
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
