namespace Palindrome
{
  public class PalindromeChecker
  {
    public bool IsPalindrome(string word)
    {
      for (int i = 0; i < (word.Length / 2); i++)
      {
        char charFromStart = word[i];
        char charFromEnd = word[word.Length -1 -i];
        if (charFromStart != charFromEnd)
        {
          return false;
        }
      }
      return true;
    }
  }
}