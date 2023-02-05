using Xunit;

namespace SpecFlowTestExample.Specs;

[Binding]
public class ForPetRoomThermometerStep
{
    ForPetThermometer _forPetThermometer;

    [Given(@"温度が(.*)")]
    public void Given温度が(float p0)
    {
        _forPetThermometer = new ForPetThermometer(p0);
    }

    [Then(@"変換後の文字列は""(.*)""")]
    public void Then変換後の文字列は(string expected)
    {
        Assert.Equal(expected ,_forPetThermometer.GetComfortLevelString());
    }
}