namespace StoreCore;

public class ShippingCalculator
{
    // A Constant for the base shipping cost per kilogram
    
    private const decimal BaseCost = 5.0m;

    // A method to calculate the shipping cost based on weight

    public decimal CalculateShippingCost(decimal weight)
    {
        // Validate the weight parameter
        if (weight <= 0)
        {
            throw new ArgumentException("Weight must be positive.");
        }

        // Calculate the shipping cost as the base cost times the weight
        decimal shippingCost = BaseCost * weight;

        // Return the shipping cost
        return shippingCost;
    }

}
