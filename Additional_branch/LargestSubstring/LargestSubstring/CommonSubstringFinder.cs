using System.Collections;

namespace LargestSubstring
{
  class MatchFinderOfStrigs
  {
    /// <summary>
    /// This method findes common substrings of two strings and chooses largest substring.
    /// </summary>
    /// <param name="bigString"> big string for finder of substring </param>
    /// <param name="smallString"> small string for finder of substring </param>
    /// <returns> first common largest substring of two substrings </returns>
    public ArrayList FindCommonSubstring(string bigString, string smallString)
    {
      ArrayList largestSubstring = new ArrayList();
      ArrayList substring = new ArrayList();
      for (int i = 0; i < bigString.Length; i++)
      {
        for (int j = 0; j < smallString.Length; j++)
        {
          if (bigString[i] == smallString[j])
          {
            int k = i, l = j;
            while (bigString[k] == smallString[l])
            {
              if (l == smallString.Length - 1 || k == bigString.Length - 1)
              {
                substring.Add(bigString[k]);
                break;
              }
              substring.Add(bigString[k]);
              k++;
              l++;
            }
          }
          if (largestSubstring.Count < substring.Count)
          {
            largestSubstring.Clear();
            foreach (char el in substring)
            {
              largestSubstring.Add(el);
            }
          }
          substring.Clear();
        }
      }
      return largestSubstring;
    }
  }
}