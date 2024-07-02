using System;

namespace task2
{
    public class Complex
    {
        private int imaginaryNum;
        private int realNum;

        public Complex(int _realNum = 0, int _imaginaryNum = 0)
        {
            imaginaryNum = _imaginaryNum;
            realNum = _realNum;
        }

        public void setImaginaryNum(int _iNum)
        {
            imaginaryNum = _iNum;
        }

        public void setRealNumber(int _realNum)
        {
            realNum = _realNum;
        }

        public int getRealNumber()
        {
            return realNum;
        }

        public int getImaginaryNum()
        {
            return imaginaryNum;
        }

        public static Complex Add(Complex num1, Complex num2)
        {
            Complex result = new Complex();
            result.setRealNumber(num1.realNum + num2.realNum);
            result.setImaginaryNum(num1.imaginaryNum + num2.imaginaryNum);
            return result;
        }

        public string print()
        {
            string op = (imaginaryNum > 0 && imaginaryNum != 0 && realNum != 0) ? "+" : "";
            string rNum = $"{(realNum == 0 && imaginaryNum != 0 ? String.Empty : realNum)}";
            string iNum =
                $"{((imaginaryNum == 0 || Math.Abs(imaginaryNum) == 1) ? String.Empty : imaginaryNum)}";
            return $"{rNum}{op}{iNum}{(imaginaryNum == -1 ? '-' : String.Empty)}{(imaginaryNum != 0 ? 'i' : String.Empty)}";
        }
    }
}
