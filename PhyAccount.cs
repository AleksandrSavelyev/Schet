using System;
using System.Collections.Generic;
using System.Text;

namespace Schet
{
    class PhyAccount:Account
    {
        PhyAccount[] data;
        public static int count = 1;
        private string accType;
        private decimal whitc;
        public PhyAccount ()
            :base()
        {
            data = new PhyAccount[count];
        }
        public string AccType
        {
            get { return accType; }
            set { accType = value; }
        }
        public decimal Whitc
        {
            get { return whitc; }
            set { whitc = value; }
        }
        public PhyAccount this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public void WhitcAcc()
        {
            Sum = Sum - whitc;
            Console.WriteLine(Sum);
        }
    }
}
