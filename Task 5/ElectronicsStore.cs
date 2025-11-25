namespace Task_5;

public class ElectronicsStore
{
    private System.Collections.Generic.List<ElectronicDevice> devices = new System.Collections.Generic.List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
    }

    public void ShowAllDeviceDetails()
    {
        foreach (ElectronicDevice device in devices)
        {
            device.ShowInfo();

            // Downcast to call child-specific methods
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            System.Console.WriteLine(); // empty line for readability
        }
    }
}