namespace PostOfficeSimulationDojo.Model;

public abstract class Box : PostedItem
{
    public int WeightInGrams { get; set; }
}

// Similar to PostedItem class, but add weight