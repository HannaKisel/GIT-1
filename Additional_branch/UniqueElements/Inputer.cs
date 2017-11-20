using System;

namespace UniqueElements
{
  class Inputer
  {
    public int[] InputArray(int size)
    {
      int[] array = new int[size];
      for (int i = 0; i < size; i++)
      {
        Console.Write("Enter " + (i + 1) + " elment of array= ");
        array[i] = int.Parse(Console.ReadLine());
      }
      return array;
    }
  }
}