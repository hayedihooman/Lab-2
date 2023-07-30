
using NUnit.Framework;

public class BankTests
{
    [Method 1]
    public void TestServiceFee_NoBalance_WithLessThan20Checks()
    {
        // Arrange
        Bank bank = new Bank();

        // Act
        decimal result = bank.serviceFee(10, false);

        // Assert
        Assert.AreEqual(11m, result);
    }

    [Method 2]
    public void TestServiceFee_40Checks()
    {
        
        Bank bank = new Bank();

        decimal result = bank.serviceFee(40, true);
       
        Assert.AreEqual(20.5m, result);
    }

    [Method 3]
    public void TestServiceFee_60Checks()
    {
        
        Bank bank = new Bank();

        decimal result = bank.serviceFee(60, false);

        Assert.AreEqual(17.7m, result);
    }



    [Method 4]
    public void TestCalc_Btn_Click_CalculateTotal()
    {
        
        Bank bank = new Bank();
        bank.NumOfCk_TxtBox.Text = "25";
        bank.Yes_Btn.IsChecked = true;

       
        bank.Calc_Btn_Click(null, null);

       
        Assert.AreEqual("$23.5", bank.Total_Lbl.Content);
    }


    [Test 5]
    public void TestReturn_Btn_Click_ReturnToMainWindow()
    {
      
        Bank bank = new Bank();

      
        bank.return_Btn_Click(null, null);

       
        Assert.IsTrue(bank.IsClosed); 
        Assert.IsTrue(Application.Current.MainWindow is MainWindow); 
    }
}




