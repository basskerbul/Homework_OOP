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
            if(someMoney > balance)
            {
                Console.WriteLine("Недостаточно средств на счёте");
            }
            else if(someMoney <= balance)
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Добавить в класс счет в банке два метода: снять со счета и положить на счет.
            //Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае 
            //положительного результата изменяет баланс.
            BancAccount myAccount = new BancAccount();
            myAccount.Balance = 8000;
            myAccount.Type = AccountType.Savings_Account;
            
        }
    }
}
