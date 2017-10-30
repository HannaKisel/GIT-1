using System;
using System.Text;

namespace StringReplacement
{
  class StringReplacer
  {
    private Random random = new Random();

    /// <summary>
    /// This method cuts substring from line
    /// </summary>
    /// <param name="line"> transfered string </param>
    /// <returns> cutted substring </returns>
    public string CutSubstring(string line)
    {
      int startPositionForCut = random.Next(line.Length - 1);
      int substringLength = random.Next(1, line.Length - startPositionForCut);
      return line.Substring(startPositionForCut, substringLength);
    }

    /// <summary>
    /// This method chooses start position for replacement, chooses length for replacement, 
    /// and creates result string after replacement 
    /// </summary>
    /// <param name="stringA"> first inputted string </param>
    /// <param name="stringB"> second inputted string </param>
    /// <returns> string after replacement </returns>
    public StringBuilder ExchangeSubsrings(string stringA, string stringB)
    {
      StringBuilder newString = new StringBuilder();
      string substringForReplaceFromStringA = CutSubstring(stringA);
      int startPositionForReplaceInStringB = random.Next(stringB.Length - 1);
      int replaceLengthInStringB = random.Next(1, stringB.Length - startPositionForReplaceInStringB);
      for (int i = 0; i < startPositionForReplaceInStringB; i++)
      {
        newString.Append(stringB[i]);
      }
      newString.Append(substringForReplaceFromStringA);
      for (int i = startPositionForReplaceInStringB + replaceLengthInStringB; i < stringB.Length; i++)
      {
        newString.Append(stringB[i]);
      }
      return newString;
    }
  }
}