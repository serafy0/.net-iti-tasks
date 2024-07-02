using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Utility
    {
        public void MultiplyArrayByTen(int[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                param[i] *= 10;
            }
        }

        public void MultiplyArrayByTenV2(ref int[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                param[i] *= 10;
            }
        }
    }
}
