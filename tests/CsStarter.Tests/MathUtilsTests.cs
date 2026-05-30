using CsStarter;
using Xunit;

namespace CsStarter.Tests;

public class MathUtilsTests
{
    [Fact]
    public void Add_ReturnsSum() => Assert.Equal(5, MathUtils.Add(2, 3));

    [Fact]
    public void Multiply_ReturnsProduct() => Assert.Equal(42, MathUtils.Multiply(6, 7));
}
