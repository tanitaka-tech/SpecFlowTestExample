using Xunit;

namespace SpecFlowTestExample.Specs.Steps;

[Binding]
public class KitchenScaleTest
{
    KitchenScale _kitchenScale = null!;
    
    [Given(@"重さが(.*)g")]
    public void Given重さが(int weight)
    {
        _kitchenScale = new KitchenScale(weight);
    }
    
    [Then(@"重さを変換後の文字列は""(.*)""")]
    public void Then重さを変換後の文字列は(string expected)
    {
        Assert.Equal(expected, _kitchenScale.GetWeightString());
    }
}