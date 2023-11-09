using PostOfficeSimulationDojo.Model;
using PostOfficeSimulationDojo.Service;

namespace PostOfficeSimulationDojo.UI;

public class PostOfficeUi
{
    public void CreateAndPostItems(PostOffice postOffice)
    {
        postOffice.PostItem(new Letter
        {
            Address = "1 Vaci ut",
            PostDate = DateTime.Today
        });
        
        postOffice.PostItem(new SmallBox
        {
            Address = "2 Vaci ut",
            PostDate = DateTime.Today,
            WeightInGrams = 500
        });
        
        postOffice.PostItem(new BigBox
        {
            Address = "3 Vaci ut",
            PostDate = DateTime.Today,
            WeightInGrams = 2000
        });
    }
    
    
    public void DisplayResults(PostOffice postOffice)
    {
        var todaysItems = postOffice.GetItemsPostedOn(DateTime.Today);

        var totalIncomeFromLetters = postOffice.CalculateTotalIncomeByType<Letter>();
        var totalIncomeFromSmallBoxes = postOffice.CalculateTotalIncomeByType<SmallBox>();
        var totalIncomeFromBigBoxes = postOffice.CalculateTotalIncomeByType<BigBox>();

        var totalIncome = totalIncomeFromLetters + totalIncomeFromSmallBoxes + totalIncomeFromBigBoxes;
        
        Console.WriteLine($"Posted items amount today: {todaysItems.Count()}");
        
        Console.WriteLine($"Total income from letters: {totalIncomeFromLetters} euros");
        Console.WriteLine($"Total income from small boxes: {totalIncomeFromSmallBoxes} euros");
        Console.WriteLine($"Total income from big boxes: {totalIncomeFromBigBoxes} euros");
        Console.WriteLine($"Total income: {totalIncome} euros");
    }
}