namespace PostOfficeSimulationDojo.Model;

public class BigBox : Box
{
    public override decimal Price => 10.29m + 0.29m * WeightInGrams;
}

// Inherit from Box class, calculate price