using System;
using System.Collections.Generic;
using System.Text;

namespace Schet
{
    class Account
    {
        /*Создать базовый класс Счет, котороый содержит информацию - сумма, номер счета, дата открытия, а также методы Выдача 
         * суммы и Выдача даты открытия счета. С помошью механизма наследования создать класс "Счет физического лица" и "Счет
         * юридического лица.*/
        private static decimal sum;
        private int accNo;
        private DateTime date;
        public Account()
        {            
        }
        public decimal Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public int AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public void IssSum()
        {
            Console.WriteLine($"на вашем балансе {sum} рублей");
        }
        public void IssDate()
        {
            Console.WriteLine($"сечт №{accNo} был создан{date}");
        }

    }
}
