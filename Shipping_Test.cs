using NUnit.Framework;

public class ShippingTests
{
    [Method 1]
    public void TestShippingFee_LessThan2Kg()
    {
        // Arrange
        Shipping shipping = new Shipping();

        // Act
        decimal result = shipping.shippingFee(1.5);

        // Assert
        Assert.AreEqual(1.1m, result);
    }

    [Method 2]
    public void TestShippingFee_Between2And6Kg()
    {
       
        Shipping shipping = new Shipping();

      
        decimal result = shipping.shippingFee(4.5);

        
        Assert.AreEqual(2.2m, result);
    }

    [Method 3]
    public void TestShippingFee_MoreThan10Kg()
    {
        
        Shipping shipping = new Shipping();

       
        decimal result = shipping.shippingFee(15);

        
        Assert.AreEqual(4.8m, result);
    }

    [Method 4]
    public void TestFeeCalc_Btn_Click_CalculateTotalFee()
    {
    
        Shipping shipping = new Shipping();
        shipping.ShippingFee_TxtBox.Text = "5";

       
        shipping.FeeCalc_Btn_Click(null, null);

        
        Assert.AreEqual("$2.2", shipping.TotalFee_TxtBox.Text);
    }




    [Method 5]
    public void TestReturn_Btn_Click_ReturnToMainWindow()
    {
        
        Shipping shipping = new Shipping();

      
        shipping.return_Btn_Click(null, null);

        
        Assert.IsTrue(shipping.IsClosed); 
        Assert.IsTrue(Application.Current.MainWindow is MainWindow); 
    }


}


