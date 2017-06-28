using System;

namespace checkSeq
{
    class SequenceType
    {
        public string DetectSeqType(int[] array)
        {
            int check = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    check++;
                }
            }
            if (check == 0)
            {
                return "\n This sequence is decreasing ";
            }
            else
            {
                return "\n This sequence is nondecreasing ;";
            }
        }
    }
}