using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeCheckerTests
  {
    [TestMethod]
    public void IsPalindrome_IsThisWordAPalindrome_True()
    {
      PalindromeChecker testWord = new PalindromeChecker();
      Assert.AreEqual(true, testWord.IsPalindrome("racecar"));
    }

  }
}