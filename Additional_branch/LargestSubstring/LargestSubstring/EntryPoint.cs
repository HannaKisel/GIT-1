using System;
using System.Collections;

namespace LargestSubstring
{
  /// <summary>
  /// Entrypoint to program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// This method creates two strings for finder of largest substring,
    /// detects big and small strings, transfers them to the method, 
    /// that finds largest common substring.
    /// </summary>
    static public void Main()
    {
      StringInputer inputerOfString = new StringInputer();
      string firstString = inputerOfString.InputString();
      string secondString = inputerOfString.InputString();      
      MatchFinderOfStrigs matchFinderOfStrigs = new MatchFinderOfStrigs();
      ArrayList largestSubstring = new ArrayList();
      if (firstString.Length < secondString.Length || firstString.Length == secondString.Length)
      {
        largestSubstring = matchFinderOfStrigs.FindCommonSubstring(secondString, firstString);
      }
      else
      {
        largestSubstring = matchFinderOfStrigs.FindCommonSubstring(firstString, secondString);
      }
      OutperOfSubstring outperOfSubstring = new OutperOfSubstring();
      outperOfSubstring.OutputSubstring(largestSubstring);
      Console.ReadKey();
    }
  }
}