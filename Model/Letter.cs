namespace PostOfficeSimulationDojo.Model;

public class Letter : PostedItem
{
    public override decimal Price => 1.99m;
}

// Use address and date from PostedItem class
// Set fixed price of 1.99 euros, use decimal to minimize rounding errors