using NUnit.Framework;
using System;
using UnitTesting_Exercisev2;
namespace Bank.Tests
{
    public class Tests
    {
        private BankAccount bankAccount;
        private string firstName = "Kris";
        private string lastName = "Hristov";
        private double balance = 2500;

        [SetUp]
        public void Setup()
        {
            bankAccount = new BankAccount(firstName, lastName, balance);
        }

        [Test]
        public void Test_First_Name()
        {
            Assert.AreEqual("Kris", bankAccount.FirstName, "Test the name. It should work fine.");
        }
        [Test]
        public void Test_First_Name_Throws_Exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                BankAccount bankAccount = new BankAccount("A", "Ivanov", 2102);
            }, "Name has less than 4 characters.");
        }

        [Test]
        public void Test_Last_Name()
        {
            Assert.AreEqual("Hristov", bankAccount.LastName, "Test the last name. It should work fine.");
        }

        [Test]
        public void Test_Last_Name_Throws_Exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                BankAccount bankAccount = new BankAccount("Kris", "Hr", 2012);
            }, "Last name has less than 4 characters.");
        }

        [Test]
        [TestCase(2000)]
        [TestCase(3000)]
        [TestCase(5000)]
        public void Test_Adding_Balance(int amount)
        {
            bankAccount.AddBalance(amount);
            Assert.IsTrue(bankAccount.Balance <= 10_000);
        }

        [Test]
        [TestCase(20000)]
        [TestCase(7501)]
        [TestCase(10000)]
        [TestCase(8614)]
        public void Test_Adding_More_Than_Possible_To_The_Balance(int amount)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                bankAccount.AddBalance(amount);
            });
        }

        [Test]
        public void Test_Withdraw_From_Balance()
        {
            bankAccount.Withdraw(1000);
            Assert.AreEqual(1500, bankAccount.Balance);

            BankAccount anotherBankAccount = new BankAccount("John", "Ivan", 2012);
            anotherBankAccount.Withdraw(2012);
            Assert.That(anotherBankAccount.Balance == 0);
        }

        [Test]
        [TestCase(10_005)]
        [TestCase(20_000)]
        public void Test_Withdraw_More_Than_Possible(double value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                bankAccount.Withdraw(value);
            });
        }

        [Test]
        [TestCase(10_000)]
        [TestCase(9000)]
        [TestCase(2501)]
        public void Test_Withdraw_Below_Zero_Balance(double value)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                bankAccount.Withdraw(value);
            });
        }
    }
}