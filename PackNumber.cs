using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    static string[] packNumbers(int[] arr)
    {
        List<string> lst = new List<string>();
        if (arr.Length != 0)
        {
            int ncnt = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i+1<=arr.Length -1)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        ncnt++;
                    }
                    else
                    {
                        if(ncnt>1)
                        lst.Add(arr[i] + ":" + ncnt);
                        else
                            lst.Add(arr[i].ToString());
                        ncnt = 1;
                    }
                }
                else
                { if(i+1 == arr.Length)
                    lst.Add(arr[i].ToString());
                }
            }
        }

        return lst.Select(x => x.ToString()).ToArray();

    }

    static void Main(String[] args)
    {
        string[] res;
        int arr_size = 0;
        arr_size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[arr_size];
        int arr_item;
        for (int arr_i = 0; arr_i < arr_size; arr_i++)
        {
            arr_item = Convert.ToInt32(Console.ReadLine());
            arr[arr_i] = arr_item;
        }

        res = packNumbers(arr);
        for (int res_i = 0; res_i < res.Length; res_i++)
        {
            Console.WriteLine(res[res_i]);
        }

        Console.ReadKey();
    }
}

