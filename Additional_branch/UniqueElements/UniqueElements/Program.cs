using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of yours array: size= ");
            int size = int.Parse(Console.ReadLine());
            Inputer inputer = new Inputer();
            int[] array = inputer.InputArray(size);
            Console.WriteLine(" Yours array is: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + "; ");
            }
            Console.WriteLine();
            Definer definer = new Definer();
            ArrayList list = definer.FindUnEl(array, size);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Unique element is: " + list[i]);
            }
            Console.ReadKey();
        }
    }
}