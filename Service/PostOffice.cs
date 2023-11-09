using PostOfficeSimulationDojo.Model;

namespace PostOfficeSimulationDojo.Service;

public class PostOffice
{
    private List<PostedItem> _postedItems = new List<PostedItem>();

    public void PostItem(PostedItem item) => _postedItems.Add(item);

    public IEnumerable<PostedItem> GetItemsPostedOn(DateTime date)
        => _postedItems.Where(item => item.PostDate.Date == date.Date);

    public decimal CalculateTotalIncomeByType<T>() where T : PostedItem
        => _postedItems.OfType<T>().Sum(item => item.Price);
}