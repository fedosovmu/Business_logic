using System;
using System.Collections.Generic;
using System.Text;

namespace Business_logic
{
    class BunkAccount
    {
        static private int counter = 1;
        public String Number { get; private set; }
        public Money Money { get; private set; }
        public List<String> History { get; private set; }



        public BunkAccount ()
        {
            Number = String.Format("%4d", counter++);
            Money = new Money();
            History = new List<String>();
        }


        public void Enroll (Money money)
        {
            Money = Money + money;
            History.Add("Зачисление " + money);
        }

        
        public bool Expend (Money money)
        {
            if (Money >= money)
            {
                Money = Money - money;
                History.Add("Списание " + money);
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Transfer (BunkAccount destinationBunkAccount, Money money)
        {
            if (Expend(money))
            {
                destinationBunkAccount.Enroll(money);
                History.Add("Перевод " + money + " на счет " + destinationBunkAccount.Number);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
