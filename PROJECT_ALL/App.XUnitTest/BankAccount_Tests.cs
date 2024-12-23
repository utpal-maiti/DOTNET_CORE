using App_ClassLibrary;

namespace App_XUnitTest
{
    public class BankAccount_Tests
    {
        [Fact]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 16.54;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            //Assert.NotEqual(expected, actual);
            Assert.Equal(expected, actual);
        }
    }
}
