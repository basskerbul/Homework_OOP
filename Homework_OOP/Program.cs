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
        private static int accountNumber;
        private int balance;
        private AccountType _type;

        //Конструктор баланс
        public BancAccount(int b)
        {
            balance = b;
            accountNumber = RandomAcNum();
        }
        //Конструктор тип
        public BancAccount( AccountType t)
        {
            _type = t;
            accountNumber = RandomAcNum();
        }
        //Конструктор тип и баланс
        public BancAccount(AccountType t, int b) 
        {
            _type = t;
            balance = b;
            accountNumber = RandomAcNum();
        }

        private static int RandomAcNum()
        {
            Random random = new Random();
            string value = $"{random.Next()}";
            accountNumber = int.Parse(value);
            return accountNumber;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать 
            //конструкторы.Переопределить конструктор по умолчанию, создать конструктор для заполнения 
            //поля баланс, конструктор для заполнения поля тип банковского счета, конструктор для 
            //заполнения баланса и типа банковского счета. Каждый конструктор должен вызывать метод, 
            //генерирующий номер счета.

            BancAccount bancAccount = new BancAccount(AccountType.Budget_Account, 1500);
        }
    }
}
