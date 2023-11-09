namespace PostOfficeSimulationDojo.Model;

public abstract class Box : PostedItem
{
    private int _weightInGrams;

    public int WeightInGrams
    {
        get => _weightInGrams;
        init
        {
            if (value < 0)
                throw new ArgumentException("Weight cannot be negative.");
            _weightInGrams = value;
        }
    }
}

// Similar to PostedItem class, but add weight
// Error handling - check for negative weight