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
            get { return accountNumber; }
            set { accountNumber = value; }
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
        public void Take(int someMoney)
        {
            if (someMoney > balance)
            {
                Console.WriteLine("Недостаточно средств на счёте");
            }
            else if (someMoney <= balance)
            {
                balance -= someMoney;
                Console.WriteLine($"Баланс: {balance}");
            }
        }
        public void Put(int someMoney)
        {
            balance += someMoney;
            Console.WriteLine($"Баланс: {balance}");
        }
        public void TransferToAnotherAccount(BancAccount Debit, int sum)
        {
            if (sum > Debit.balance)
            {
                Console.WriteLine("Перевод средств невозможен");
            }
            if (sum <= Debit.balance)
            {
                Debit.balance -= sum;
                this.balance += sum;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета
            //на другой. У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй 
            //параметр – сумма.
            BancAccount myAccount = new BancAccount();
            myAccount.AccountNumber = 104;
            myAccount.Balance = 4500;
            myAccount.Type = AccountType.Frozen_Account;

            BancAccount myAccount2 = new BancAccount();
            myAccount2.AccountNumber = 182;
            myAccount2.Balance = 8000;
            myAccount2.Type = AccountType.Frozen_Account;

            myAccount2.TransferToAnotherAccount(myAccount, 4500);

            Console.WriteLine(myAccount.Balance);
            Console.WriteLine(myAccount2.Balance);

            Console.ReadKey();
        }
    }
}
