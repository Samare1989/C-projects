using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingproject
{
    class Account

    {
        private static int nextId;
        private int Id { get; set; }
        private string Description { get; set; }
        private double Balance { get; set; }

        public void TransferTo( double Amount,Account Acct)
        {
            var BalanceBeForeWithdraw = GetBalance();
            Withdraw(Amount);
            var balanceafterwithdraw = GetBalance();
            if (BalanceBeForeWithdraw == balanceafterwithdraw)
            {
                Console.WriteLine("insufficent Funds");
                return;
            }
            Acct.Deposit(Amount);
        }
        public int GetID()
        {
            return Id;
        }

        public string GetDescription()

        {
            return Description;
        }
        public void SetDescription(string NewDescription)
        {
            Description = NewDescription;
        }


        public double GetBalance()
        {

            return Balance;
        }
        public void Deposit(double Amount)
        {
            if (Amount <= 0)
                Console.WriteLine("Amount must be Positive.");
            else
                Balance += Amount;
        }

        public void Withdraw(double Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Amount must be Positive.");
                return;
            }



            if (Amount > Balance)
            {
                Console.WriteLine(" insufficent amount!");
                return;

            }
            Balance -= Amount;
        }


        public virtual string Print()
        {
            return $"Id = {Id},Description ={Description},Banalce ={Balance}";
        }


        public Account(string NewDescription)
        {
            Id = nextId++;
            if (NewDescription == null)
            {
                Description = "*New Account*";
            }
            else
            {
                Description = NewDescription;

            }


            Balance = 0;
        }

        // this constructor calls the other constructor and passes in a null value for NewDescription 

        public Account() : this(null) { }
    }
}                
                    

                

                