using Xunit;
using MauiClimaDemo.Core;

namespace MauiClimaDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void Sumar_debe_dar_4()
    {
        var r = MathUtil.Sumar(2, 2);
        Assert.Equal(4, r);
    }
}
