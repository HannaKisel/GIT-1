﻿using System;

namespace checkSeq
{
    class checkSequence
    {
        const string ERRORLENGTHS = "This sequence is not nondecreasing and is't decreasing ";

        static void Main(string[] args)
        {
            bool Checking = true;
            while (Checking)
            {
                try
                {
                    Inputer inputer = new Inputer();
                    int[] array = inputer.input();
                    if (array.Length == 1)
                    {
                        Console.WriteLine(ERRORLENGTHS);
                        continue;
                    }
                    else
                    {
                        Outputer outputer = new Outputer();
                        outputer.Output(array);
                        SequenceType sequenceType = new SequenceType();
                        Console.WriteLine(sequenceType.DetectSeqType(array));
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number. Try again");
                    continue;
                }
                Checking = false;
            }
        }
    }
}