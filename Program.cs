using PostOfficeSimulationDojo.Service;
using PostOfficeSimulationDojo.UI;

namespace PostOfficeSimulationDojo;

public static class Program
{
    private static void Main()
    {
        var postOffice = new PostOffice();
        var postOfficeUi = new PostOfficeUi();

        try
        {
            postOfficeUi.CreateAndPostItems(postOffice);
            postOfficeUi.DisplayResults(postOffice);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine($"Error creating a box: {exception.Message}");
            throw;
        }
    }
}