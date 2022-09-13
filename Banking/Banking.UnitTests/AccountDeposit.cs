using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{

    public class AccountDeposit
    {
        [Fact]
        public void MakingADepositIncreasesTheBalance()
        {
            // Given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 10.15M;// 'M' = make it a decimal
            
            // When 
            account.Deposit(amountToDeposit);
            
            // Then
            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
        }
    }
}
