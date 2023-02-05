// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class ForPetThermometer
{
    float Temperature { get; }  // 温度

    public ForPetThermometer(float temperature)
    {
        Temperature = temperature;
    }

    public string GetComfortLevelString()
    {
        if (Temperature < 24.0)
        {
            return "寒い";
        }
        else if (Temperature < 26.0)
        {
            return "快適";
        }
        return "暑い";
    }
}