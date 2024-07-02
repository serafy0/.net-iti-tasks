using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class MyStack
    {
        int[] arr = new int[5];
        int tos;
        public MyStack()
        {
            tos = 0;
        }

        #region stack functions
        public void Push(int value)
        {
            if (tos != 5)
            {
                arr[tos] = value;
                tos++;
            }
            else
            {
                Console.WriteLine("FULL!!!!");
            }
        }
        public int Pop() 
        {
            int retVal = -1 ;
            if (tos != 0)
            {
                tos--;
                retVal = arr[tos];
                //return retVal;
            }
            else 
            {
                Console.WriteLine("EMPTY!!!!");
                //return -1; //not effective
                //throw runtime error
            }
            return retVal;
        }
        #endregion


    }
}
