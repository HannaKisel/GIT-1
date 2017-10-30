using System;

namespace StringReplacement
{
  class EntryPoint
  {
    static void Main()
    {
      StringCreator stringCreator = new StringCreator();
      string stringA = stringCreator.CreateString();
      string stringB = stringCreator.CreateString();
      Console.WriteLine("Your string A: " + stringA);
      Console.WriteLine("Your string B: " + stringB);
      StringReplacer stringReplacer = new StringReplacer();
      Console.WriteLine("New string : " + stringReplacer.ExchangeSubsrings(stringA, stringB));
      Console.ReadKey();
    }
  }
}