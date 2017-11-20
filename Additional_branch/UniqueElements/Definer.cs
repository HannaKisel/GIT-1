using System;
using System.Collections;

namespace UniqueElements
{
  class Definer
  {
    public ArrayList FindUnEl(int[] array, int size)
    {
      ArrayList list = new ArrayList();
      for (int i = 0; i < size; i++)
      {
        int counter = 0;
        for (int j = 0; j < size; j++)
        {
          if (array[i] == array[j])
          {
            counter++;
          }
        }
        if (counter == 1)
        {
          list.Add(array[i]);
        }
      }
      if (list.Count == 0)
      {
        Console.WriteLine("\nThere is no unique elements.");
      }
      return (list);
    }
  }
}