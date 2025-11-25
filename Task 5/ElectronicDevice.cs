namespace Task_5;

public abstract class ElectronicDevice
{
    private string brand;
    private double price;

    public string Brand
    {
        get => brand;
        set => brand = value;
    }

    public double Price
    {
        get => price;
        set
        {
            if (value <= 0)
                throw new System.ArgumentException("Price must be positive");
            price = value;
        }
    }

    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    public abstract void ShowInfo();
}