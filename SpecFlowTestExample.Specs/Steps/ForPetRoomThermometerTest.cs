using Xunit;

namespace SpecFlowTestExample.Specs;

[Binding]
public class ForPetRoomThermometerTest
{
    ForPetThermometer _forPetThermometer = null!;

    [Given(@"温度が(.*)度")]
    public void Given温度が(float p0)
    {
        _forPetThermometer = new ForPetThermometer(p0);
    }

    [Then(@"温度を変換後の文字列は""(.*)""")]
    public void Then温度を変換後の文字列は(string expected)
    {
        Assert.Equal(expected ,_forPetThermometer.GetComfortLevelString());
    }
}