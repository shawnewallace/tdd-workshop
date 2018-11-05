using System;
using Xunit;

namespace fibonacci.tests
{
  public class FibonacciTests {
    private Fibonacci _f;

    public FibonacciTests() => _f = new Fibonacci();

    [Fact]
    public void TheZereothFibonacciNumberIs0() {
      Assert.Equal(0, _f.f(0));
    }

    [Fact]
    public void TheFirstFibonacciNumberIs1() {
      Assert.Equal(1, _f.f(1));
    }

    [Theory]
    [InlineData (2, 1)]
    [InlineData (3, 2)]
    [InlineData (4, 3)]
    [InlineData (5, 5)]
    [InlineData (17, 1597)]
    [InlineData (45, 1134903170)]
    [InlineData (83, 99194853094755497)]
    public void nthFibIs (int n, long expected) {
      Assert.Equal(expected, _f.f(n));
    }
  }
}