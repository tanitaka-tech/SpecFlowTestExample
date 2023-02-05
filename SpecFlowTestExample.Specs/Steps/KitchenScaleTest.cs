using Xunit;

namespace SpecFlowTestExample.Specs.Steps;

[Binding]
public class KitchenScaleTest
{
    [Given(@"重さが(.*)")]
    public void Given重さが(int p0)
    {
        ScenarioContext.StepIsPending();
    }
    
    [Then(@"変換後の文字列は""(.*)""")]
    public void Then変換後の文字列は(string expected)
    {
        ScenarioContext.StepIsPending();
    }
}