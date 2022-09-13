using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class AccountWithdrawals
    {
        [Fact]
        public void WithdrawingMoneyDecreasesBalance()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = 10M;
            account.Withdraw(amountToWithdraw);

            Assert.Equal(openingBalance -amountToWithdraw, account.GetBalance());
        }
    }
}
