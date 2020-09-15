using System;

namespace Schet
{
    class Program
    {
        static void Main(string[] args)
        {
            LawAccount law = new LawAccount();
            int lawCount = 0;
            PhyAccount phy = new PhyAccount();
            int phyCount = 0;
            for (; ; )
            {
                Console.WriteLine("нажмите 1 чтобы добавить счёт юридического лица");
                Console.WriteLine("нажмите 2 чтобы добавить счёт физического лица");
                Console.WriteLine("нажмите 3 чтобы узнать информацию о юридических счетах");
                Console.WriteLine("нажмите 4 чтобы узнать информацию о физических счетах");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddLaw(law, lawCount);
                        lawCount++;
                        break;
                    case "2":AddPhy(phy, phyCount);
                        phyCount++;
                        break;
                    case "3":
                        PrintInfoLaw(law);
                        break;
                    default:
                        break;
                }
            }
        }
        static LawAccount AddLaw(LawAccount law,int i)
        {
            
                law[i] = new LawAccount();
                law[i].AccNo = AccNo();
                Console.Write("какую сумму желаете внести на счёт?\t");
                law[i].Sum = AddSum();
                law[i].Date = DateTime.Now;
                LawAccount.count += 1;
                Console.WriteLine("чтобы добавить счёт нажмите 1");
                Console.WriteLine("чтобы выйти нажмите любую клавишу");
                switch(Console.ReadLine())
                
                {
                    case "1":return AddLaw(law, i+1);                            
                    default:return law;                        
                }
            
        }
        static int AccNo()
        {
            Random ran = new Random();
            int value = ran.Next(100000000, 999999999);
            return value;
        }
        static decimal AddSum()
        {
            for(; ; )
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal a))
                    return a;
                else
                    Console.Write("не коректные данные введите заново:\t");
            }
        }
        static void PrintInfoLaw(LawAccount law)
        {
            Console.Write("введите номер аккаунта чтобы узнать информацию:\t");
            int i = ChekNum();
            law[i].IssDate();
            law[i].IssSum();
            law[i].AddSum();
        }
        static int ChekNum()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int a))
                    return a;
                else
                    Console.Write("не коректные данные поваторите ввод:\t");
            }  
        }
        static PhyAccount AddPhy(PhyAccount phy,int i)
        {
            phy[i] = new PhyAccount();
            phy[i]=
        }
        /*static int ChecAccNo()
        {
            for(; ; )
            {
                int checAccNo = ChekNum();
                if (checAccNo < 100000000 && checAccNo > 999999999)
                    return checAccNo;
                else
                    Console.Write("номер слишком короткий повторите ввод:\t");
            }
        }*/
    }
}
