using System;
using System.Collections.Generic;
using System.Text;

namespace Schet
{
    class LawAccount:Account
    {
        public static int count = 1;
        LawAccount[] data;
        public LawAccount()
            :base()
        {
            data= new LawAccount[count];
        }
        public LawAccount this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public void AddSum()
        {
            Console.WriteLine($"после начисления процентов у вас будет {Sum+(Sum / 100 * 10)}");            
        }
    }
}
