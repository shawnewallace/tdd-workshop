using System.Collections.Generic;

namespace fibonacci.tests
{
  public class Fibonacci
  {
    Dictionary<int, long> _memo = new Dictionary<int, long>();

    public long f(int value)
    {
      if (value < 2) return value;

      if (_memo.ContainsKey(value)) return _memo[value];

      _memo[value] = f(value - 1) + f(value - 2);

      return _memo[value];
    }
  }
}