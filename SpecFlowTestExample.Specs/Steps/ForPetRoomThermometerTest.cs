using Xunit;

namespace SpecFlowTestExample.Specs;

[Binding]
public class ForPetRoomThermometerTest
{
    ForPetThermometer _forPetThermometer = null!;

    [Given(@"ペット用室温計で測った温度が(.*)度")]
    public void Givenペット用室温計で測った温度が(float p0)
    {
        _forPetThermometer = new ForPetThermometer(p0);
    }

    [Then(@"ペット用室温計で測った温度を変換後の文字列は""(.*)""")]
    public void Thenペット用室温計で測った温度を変換後の文字列は(string expected)
    {
        Assert.Equal(expected ,_forPetThermometer.GetComfortLevelString());
    }
}