﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingproject
{
    class Program
    {
        static void TestMethos()
        {

        }
        static void Main(string[] args)
            
            
       {
            var chk1 = new checking("My First Checking Acct");
             Console.WriteLine (chk1.Print());
            var chk2 = new checking();
            chk2.Deposit(500);
            Console.WriteLine(chk2.Print());
            var sav1 = new Savings();
            sav1.Print();
            sav1.SetDescription("Savings");
            sav1. Deposit(1500);
            sav1.Print();
            sav1.Withdraw(500);
            Console.WriteLine (sav1.Print());

            var sav2 = new Savings("From Savings Account");
            sav2.SetDescription("From Saving Account");
            sav2.Deposit(1000);
            sav2.Print();
            var sav3 = new Savings();
            sav3.SetDescription(" To Savings Account");
            sav3.Deposit(100);
            Console.WriteLine (sav3.Print());

            List<Account> accounts = new List<Account>();
            accounts.Add(chk1);
            accounts.Add(chk2);
            accounts.Add(sav1);
            accounts.Add(sav2);
            accounts.Add(sav3);

            foreach(var account in accounts)
            {
                Console.WriteLine(account.Print());
            }

            //sav2.TransferTo(200, sav3);
            //sav2.Print();
            //sav3.Print();
            //sav3.TransferTo(500, sav2);
            //Console.WriteLine (sav2.Print());
            
            //var acct1 = new Account("Test Checking");
            //acct1.Print();
            //acct1.Deposit(1000.00);
            //acct1.Print();
            //acct1.Withdraw(60.00);
            //Console.WriteLine (acct1.Print());
            //var acct2 = new Account("Testc Savings");
            //acct2.Print();
            //acct2.Deposit(-100);
            //acct2.Print();
            //acct2.Withdraw(-200);
            //acct2.Print();
            //acct2.Withdraw(100);
            //Console.WriteLine(acct2.Print());
            //var acct3 = new Account();
            //Console.WriteLine(acct3.Print());
                
                
        }
    }
}
