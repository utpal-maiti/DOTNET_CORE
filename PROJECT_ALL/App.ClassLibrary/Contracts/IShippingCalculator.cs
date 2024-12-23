namespace App_ClassLibrary.Contracts
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
