using System;

namespace StringReplacement
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
      char[] array = new char[rand.Next(MINLENGTHOFLINE, MAXLENGTHOFLINE)];
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = (char)rand.Next(STARTOFLOWERCASECHARACTERS, ENDTOFLOWERCASECHARACTERS);
      }
      return new string(array);
    }
  }
}