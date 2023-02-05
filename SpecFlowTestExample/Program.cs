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

public class KitchenScale
{
    int Weight { get; }  // 重さ
    const string ErrorString = "EEEE";
    
    public KitchenScale(int weight)
    {
        Weight = weight;
    }

    public string GetWeightString()
    {
        if (Weight < 0)
        {
            return ErrorString;
        }
        else if (Weight > 2000)
        {
            return ErrorString;
        }
        return $"{Weight}g";
    }
}