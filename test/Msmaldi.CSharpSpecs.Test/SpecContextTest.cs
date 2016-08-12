using Xunit;

namespace Msmaldi.CSharpSpecs.Test
{
  // see example explanation on xUnit.net website:
  // https://xunit.github.io/docs/getting-started-dotnet-core.html
  public class SpecContextTest : SpecContext
  {
    [Fact]
    public void PassingTest()
    {
      describe["when use SpecContext class"] = () =>
      {
        context["with other internal context"] = () =>
        {
          it["it is work very well"] = () => Assert.True(true);
          it["it is work very well"] = () => Assert.True(true);
          it["it is work very well"] = () => Assert.True(true);
        };

        context["with second internal context"] = () =>
        {
          it["it is work very well too!!!"] = () => Assert.True(true);
        };

        context["Great!!!"] = () => Assert.True(true);
      };
    }

    //[Fact]
    public void FailingTest()
    {
      describe["when use SpecContext class for failing"] = () =>
      {
        context["with other internal context for failing"] = () =>
        {
          it["it is not work very well"] = () => Assert.True(false);
          it["it is work work very well"] = () => Assert.True(true);
          it["it is not very well"] = () => Assert.True(false);
        };

        context["with second internal context"] = () =>
        {
          it["it is work very well too!!!"] = () => Assert.True(true);
        };

        context["Great!!!"] = () => Assert.True(true);
      };
    }
  }
}
