## Intro

This is a sample project in .NET(C#) and Java to facilitate practicing refactoring patterns. Please feel free to make the code as crappy as possible without breaking the tests. The examples listed here are heavily borrowed from the [Extreme Programming Explored book](http://www.amazon.com/exec/obidos/ASIN/0201733978/xp123com) by William C. Wake.

### Process

Here is a sample process to go through that shows both how difficult bugs are to find in this code and how well refactored and tested code can be easy to maintain.

1. I would tweak 1 thing to cause the substitution test to fail before introducing to students and first ask them to fix the bug. Give them maybe 2 minutes.
2. Undo the tweak above to get tests green.
3. Start progressively refactoring anywhere in the code whenever you are green.
4. Add tests as appropriate.
5. Go back and make the same change. See how long it takes the class to fix the same bug.

### Refactoring Opportunities

- Magic Numbers
- Long Methods
- Long Class
- Poor Naming
- Empty Catches
- Similar Code
- Unclear Tests
- Large Tests

