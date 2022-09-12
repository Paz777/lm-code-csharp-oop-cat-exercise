using NUnit.Framework;
using FluentAssertions;

namespace OopCatExercise.Tests;

public class CatTests
{
    private DomesticCat domesticCat;
    private LionCat lionCat;
    private CheetahCat cheetahCat;

    [SetUp]
    public void SetUp()
    {
        domesticCat = new();
        lionCat = new();
        cheetahCat = new();
    }

    [Test]
    public void DomesticCat_Should_Be_Awake_By_Default()
    {
        domesticCat.IsAsleep.Should().Be(false);
    }
    
    [Test]
    public void DomesticCat_Should_Be_Asleep_When_GoToSleep_Is_Called()
    {
        domesticCat.GoToSleep();
        domesticCat.IsAsleep.Should().Be(true);
    }
    
    [Test]
    public void DomesticCat_Should_Be_Awake_When_WakeUp_Is_Called()
    {
        domesticCat.GoToSleep();
        domesticCat.WakeUp();
        domesticCat.IsAsleep.Should().Be(false);
    }
    
    [Test]
    public void DomesticCat_Setting_Should_Be_Domestic()
    {
        domesticCat.Setting.Should().Be("domestic");
    }
    
    [Test]
    public void DomesticCat_AverageHeight_Should_Be_Correct()
    {
        domesticCat.AverageHeight.Should().Be(23);
    }

    [Test]
    public void LionCat_Setting_Should_Be_Wild()
    {
        lionCat.Setting.Should().Be("wild");
    }

    [Test]
    public void LionCat_AverageHeight_Should_Be_Correct()
    {
        lionCat.AverageHeight.Should().Be(1100);
    }
    
    [Test]
    public void LionCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        lionCat.Eat().Should().Be("Roar!!!!");
    }

    [Test]
    public void CheetahCat_Setting_Should_Be_Wild()
    {
        cheetahCat.Setting.Should().Be("wild");
    }

    [Test]
    public void CheetahCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        cheetahCat.Eat().Should().Be("Zzzzzzz");
    }
    
    [Test]
    public void DomesticCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        domesticCat.Eat().Should().BeOneOf("Purrrrrrr", "Purrrrrrr It will do I suppose");
    }
}
