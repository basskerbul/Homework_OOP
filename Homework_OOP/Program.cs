using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP
{
    public enum AccountType
    {
        Budget_Account,
        Currency_Account,
        Frozen_Account,
        Insured_Account,
        Current_Account,
        Correspondent_Account,
        Savings_Account,
    }
    public class BancAccount
    {
        private int accountNumber;
        private int balance;
        private AccountType _type;

        public int AccountNumber
        {
            get
            {
                Random random = new Random();
                return accountNumber = random.Next();
            }
            //set { accountNumber = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public AccountType Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //В классе все методы для заполнения и получения значений полей заменить на свойства.
            //Написать тестовый пример.
            BancAccount bancAccount = new BancAccount();
            bancAccount.Balance = 2000;
            bancAccount.Type = AccountType.Budget_Account;
            Console.WriteLine($"Balance: {bancAccount.Balance}\nType: {bancAccount.Type}\nAccount: {bancAccount.AccountNumber}");
            Console.ReadKey();
        }
    }
}
