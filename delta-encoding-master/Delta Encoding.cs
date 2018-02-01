// Solution in c#

    static int[] delta_encode(int[] array)
    {
        List<int> lst = new List<int>();
        lst.Add(array[0]);

        for (int i = 1; i < array.Length; i++)
        {
            int diff = (array[i] - array[i - 1]);
            if (Math.Abs(diff) > 127)
            {
                lst.Add(-128);
            }
            lst.Add(diff);

        }

        return lst.ToArray();

    }
