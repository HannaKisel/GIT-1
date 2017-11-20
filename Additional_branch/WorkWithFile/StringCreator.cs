using System;
using System.Collections;
using System.Text;

namespace WorkWithFile
{
  class StringCreator
  {
    /// <summary>
    /// This class contains a method that creates strings.
    /// </summary>
    const int STARTOFLOWERCASECHARACTERS = 97;
    const int ENDTOFLOWERCASECHARACTERS = 123;
    const int MINLENGTHOFLINE = 10;
    const int MAXLENGTHOFLINE = 15;

    Random rand = new Random();

    /// <summary>
    /// This method creates string with random length and random char elements. 
    /// </summary>
    /// <returns> string with char symbols </returns>
    public string CreateString()
    {
      int lenghtOfString = rand.Next(MINLENGTHOFLINE, MAXLENGTHOFLINE);
      ArrayList array = new ArrayList();
      for (int i = 0; i < lenghtOfString; i++)
      {
        array.Add((char)rand.Next(STARTOFLOWERCASECHARACTERS, ENDTOFLOWERCASECHARACTERS));
      }
      StringBuilder line = new StringBuilder();
      foreach (char el in array)
      {
        line.Append(el);
      }
      return line.ToString();
    }
  }
}