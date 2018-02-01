    static void Main(String[] args)
    {
        int res;
        int noOfCurrentAgents;
        noOfCurrentAgents = Convert.ToInt32(Console.ReadLine());

        int callsTimes_rows = 0;
        int callsTimes_cols = 0;
        callsTimes_rows = Convert.ToInt32(Console.ReadLine());
        callsTimes_cols = Convert.ToInt32(Console.ReadLine());

        int[][] callsTimes = new int[callsTimes_rows][];
        for (int callsTimes_i = 0; callsTimes_i < callsTimes_rows; callsTimes_i++)
        {
            string[] callsTimes_temp = Console.ReadLine().Split(' ');
            callsTimes[callsTimes_i] = Array.ConvertAll(callsTimes_temp, Int32.Parse);

        }

        res = howManyAgentsToAdd(noOfCurrentAgents, callsTimes);
        Console.WriteLine(res);
        Console.ReadKey();
     }
     
         static int howManyAgentsToAdd(int noOfCurrentAgents, int[][] callsTimes)
    {
        //Taking the sortedlist , using collections
        SortedList<int, int> lst = new SortedList<int, int>();

        for (int i = 0; i < callsTimes.Length; ++i)
        {
            var b = callsTimes[i][0];
            var e = callsTimes[i][1];

            if (!lst.ContainsKey(b))
                lst.Add(b, +1);
            else
                lst[b]++;
            if (!lst.ContainsKey(e))
                lst.Add(e, -1);
            else
                lst[e]--;
        }
        int nmax = 0;
        int num = 0;
        foreach (int val in lst.Values)
        {
            num += val;
            if (nmax < num) nmax = num;
        }
        return nmax - noOfCurrentAgents;


    }
