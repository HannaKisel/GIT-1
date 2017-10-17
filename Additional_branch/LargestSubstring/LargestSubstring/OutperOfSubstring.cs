using System;
using System.Collections;

namespace LargestSubstring
{
  class OutperOfSubstring
  {
    /// <summary>
    /// This method prints on console string
    /// </summary>
    /// <param name="largestSubstring"> finded largest substring of two strings </param>
    public void OutputSubstring(ArrayList largestSubstring)
    {
      Console.WriteLine("Your substring is :");
      foreach (char element in largestSubstring)
      {
        Console.Write(element);
      }
    }
  }
}