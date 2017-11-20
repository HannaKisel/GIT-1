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
    public ArrayList FindCommonSubstring(string stringA, string stringB)
    {
      ArrayList largestSubstring = new ArrayList();
      ArrayList substring = new ArrayList();
      for (int i = 0; i < stringA.Length; i++)
      {
        for (int j = 0; j < stringB.Length; j++)
        {
          if (stringA[i] == stringB[j])
          {
            int k = i, l = j;
            while (stringA[k] == stringB[l])
            {
              if (l == stringB.Length - 1 || k == stringA.Length - 1)
              {
                substring.Add(stringA[k]);
                break;
              }
              substring.Add(stringA[k]);
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