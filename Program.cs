using PostOfficeSimulationDojo.Model;
using PostOfficeSimulationDojo.Service;
using PostOfficeSimulationDojo.UI;

namespace PostOfficeSimulationDojo;

public static class Program
{
    private static void Main()
    {
        var postOffice = new PostOffice();
        var postOfficeUI = new PostOfficeUi();

        postOfficeUI.CreateAndPostItems(postOffice);
        postOfficeUI.DisplayResults(postOffice);
    }
}