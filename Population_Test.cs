using NUnit.Framework;

public class PopulationTests
{
    [Method 1]
    public void TestCalculatePopulation()
    {
        // Arrange
        Population population = new Population();

        // Act
        List<Population.PopulationDay> result = population.CalculatePopulation(1000, 2, 5);

        // Assert
        Assert.AreEqual(5, result.Count);
        Assert.AreEqual(1000, result[0].Population);
        Assert.AreEqual(1020, result[1].Population);
        Assert.AreEqual(1040.4, result[2].Population, 0.1);
        Assert.AreEqual(1061.208, result[3].Population, 0.1);
        Assert.AreEqual(1082.432, result[4].Population, 0.1);
    }
    [Method 2]
    public void TestCalc_Btn_Click_PopulationDataDisplayed()
    {
       // Arrange
        Population population = new Population();
        population.ppt_TxtBox.Text = "1000";
        population.AvgTxt_Box.Text = "2";
        population.NumOfDays_TxtBox.Text = "5";

       
        population.Calc_Btn_Click(null, null);

        Assert.IsNotNull(population.dataGrid.ItemsSource);
        Assert.IsInstanceOfType(population.dataGrid.ItemsSource, typeof(List<Population.PopulationDay>));
        Assert.AreEqual(5, ((List<Population.PopulationDay>)population.dataGrid.ItemsSource).Count);
    }
    [Method 3]
    public void TestCalc_Btn_Click_InvalidInput()
    {
        
        Population population = new Population();
        population.ppt_TxtBox.Text = "0";
        population.AvgTxt_Box.Text = "-5";
        population.NumOfDays_TxtBox.Text = "0";
 
        population.Calc_Btn_Click(null, null);

        Assert.IsNull(population.dataGrid.ItemsSource);
        Assert.IsTrue(population.MessageBoxShown("population must be greater than 1"));
        Assert.IsTrue(population.MessageBoxShown("Average must be greater that 0"));
        Assert.IsTrue(population.MessageBoxShown("days must be greater than 1"));
    }
}




