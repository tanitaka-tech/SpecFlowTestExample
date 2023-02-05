using Xunit;

namespace SpecFlowTestExample.Specs.Steps;

[Binding]
public class KitchenScaleTest
{
    KitchenScale _kitchenScale = null!;
    
    [Given(@"キッチンスケールで測った重さが(.*)g")]
    public void Givenキッチンスケールで測った重さが(int weight)
    {
        _kitchenScale = new KitchenScale(weight);
    }
    
    [Then(@"キッチンスケールで測った重さを変換後の文字列は""(.*)""")]
    public void Thenキッチンスケールで測った重さを変換後の文字列は(string expected)
    {
        Assert.Equal(expected, _kitchenScale.GetWeightString());
    }
}