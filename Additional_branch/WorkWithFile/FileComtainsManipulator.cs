using System;
using System.IO;
using System.Text;

namespace WorkWithFile
{
  /// <summary>
  /// This class works with file constants 
  /// </summary>
  class FileComtainsManipulator
  {
    private const char FIRST_SYMBOL_OF_END_STRING = '\r';
    private const char SECOND_SYMBOL_OF_END_STRING = '\n';
    Random random = new Random();
    public int LastStringPosition { get; set; }

    public string FilePath { get; set; }

    public FileComtainsManipulator(string filePath)
    {
      FilePath = filePath;
    }

    /// <summary>
    /// This method swaps the lines(in the file), if certain conditions are satisfied
    /// </summary>
    public void WriteToFile()
    {
      int numberOfLines = random.Next(2, 10);
      StringCreator stringCreator = new StringCreator();
      StringBuilder line = new StringBuilder();
      for (int i = 0; i < numberOfLines; i++)
      {
        line.Append((stringCreator.CreateString())).Append("\r").Append("\n");
      }
      string newText = line.ToString();
      using (FileStream fstream = new FileStream(FilePath, FileMode.OpenOrCreate))
      {
        byte[] array = Encoding.Default.GetBytes(newText);
        fstream.Write(array, 0, array.Length);
        Console.WriteLine("Text:\n" + newText + "was writen");
      }
    }

    /// <summary>
    /// This method reads one string from file
    /// </summary>
    /// <param name="fstream">stream for writing and reading a file</param>
    /// <returns>returns the read string</returns>
    public string ReadFromFile(FileStream fstream)
    {
      int endOfReading = ReadingLimits(fstream);
      fstream.Seek(LastStringPosition, SeekOrigin.Begin);
      {
        int startOfReading = LastStringPosition;
        byte[] array = new byte[endOfReading];
        fstream.Read(array, 0, endOfReading);
        LastStringPosition += endOfReading;
        return Encoding.Default.GetString(array);
      }
    }

    /// <summary>
    /// This method finds quantity of elements before next string 
    /// </summary>
    /// <param name="fileStream"> This is file that contains of srings</param>
    /// <returns>the number of items that we must read in the first line</returns>
    private int ReadingLimits(FileStream fileStream)
    {
      //fileStream.Seek(lastStringPosition, SeekOrigin.Begin);
      int countOfReaded = 0;
      byte[] item = new byte[fileStream.Length];
      while (fileStream.Position != fileStream.Length)
      {
        fileStream.Read(item, 0, 1);
        if (item[0] != '\n') //Encoding.Default.GetBytes("\n")- converts a string in parentheses to bytes
        {
          countOfReaded++;
        }
        else
        {
          break;
        }
      }
      return countOfReaded + 1;
    }

    /// <summary>
    /// Sorts strings in file.
    /// </summary>
    /// <param name="path">Path to file, which need to sort.</param>
    public void SortStringsInFile()
    {
      bool notSorted = true;
      using (FileStream fstream = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite))
      {
        do
        {
          string firstString = ReadFromFile(fstream);
          notSorted = false;
          while (fstream.Position < fstream.Length)
          {
            string secondString = ReadFromFile(fstream);
            if (String.Compare(firstString, secondString) > 0)
            {
              SwapStringsInFile(firstString, secondString, fstream);
              notSorted = true;
            }
            else
            {
              firstString = secondString;
            }
          }
          fstream.Seek(0, SeekOrigin.Begin);
          LastStringPosition = 0;
        } while (notSorted);
      }
    }

    public void SwapStringsInFile(string firstString, string secondString, FileStream fstream)
    {
      string connectedStrings = MergeStrings(firstString, secondString);
      byte[] stringsInBytes = Encoding.Default.GetBytes(connectedStrings);
      fstream.Seek(-(stringsInBytes.Length), SeekOrigin.Current);
      fstream.Write(stringsInBytes, 0, stringsInBytes.Length);
    }

    /// <summary>
    /// This class merges two inputted strings. 
    /// </summary>
    /// <param name="firstString"> inputted string </param>
    /// <param name="secondString"> inputted string </param>
    /// <returns> merged string </returns>
    private string MergeStrings(string firstString, string secondString)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(secondString);
      //  stringBuilder.Append(FIRST_SYMBOL_OF_END_STRING);
      //stringBuilder.Append(SECOND_SYMBOL_OF_END_STRING);
      stringBuilder.Append(firstString);
      //stringBuilder.Append(FIRST_SYMBOL_OF_END_STRING);
      //stringBuilder.Append(SECOND_SYMBOL_OF_END_STRING);
      return stringBuilder.ToString();
    }
  }
}