﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingproject
{
    class Savings : Account
    {
        private double IntRate { get; set; } = 0.01;

        public override string Print()
        {
            return base.Print() + $" IntRate={IntRate}";
        }
        public double GetIntRate()
        {
            return IntRate;
        }
        public void SetIntRate(double NewIntRate)
        {
            IntRate = NewIntRate;
        }

        public void PayInterest()
        {
            var IntToBePaid = GetBalance() * GetIntRate();
            Deposit(IntToBePaid);

        }

        public Savings(string NewDescription) : base(NewDescription)
        {
            SetIntRate(0.01);
        }





        public Savings() : this(null)
        {


        }


    }
}








