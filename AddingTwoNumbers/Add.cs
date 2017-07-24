using System;
using System.Collections.Generic;
using System.Text;

namespace AddingTwoNumbers
{
   public class Add: IAdd
    {
        private int Number1 { get; set; }
        private int Number2 { get; set; }

        public Add(int _number1,int _number2)
        {
            Number1 = _number1;
            Number2 = _number2;
        }

        public int AddTwoNumbers()
        {
            int sum =  0;
            sum += Number1 + Number2;
            return sum;
        }
    }
}
