using System;

namespace WorkWithFile
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string filePath = args[0];
      FileComtainsManipulator lineManipulator = new FileComtainsManipulator(filePath);
      lineManipulator.WriteToFile();
      lineManipulator.SortStringsInFile();
    }
  }
}