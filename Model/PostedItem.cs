namespace PostOfficeSimulationDojo.Model;

public abstract class PostedItem
{
    public string Address { get; set; }
    public DateTime PostDate { get; set; }
    
    public abstract decimal Price { get; }
}

// Abstract class not instantiated on its own, other classes inherit from this one
// Avoids code duplication compared to using an interface