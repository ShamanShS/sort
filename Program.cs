using System;

namespace sort;


class sort
{
    static void Main(string[] args)
    {
        int[] mas = new int[10]{39,78,56,36,24,25,15,15,89,71};
        int n = mas.Length;
        int l = 0;
        for (int i = 0; i < n; i++)
        {
            bool f = true;
            for (int i1 = 0; i1 < n - (i + 1); i1++)
            {
                if (mas[i1] > mas[i1 + 1])
                {
                    int t = mas[i1];
                    mas[i1] = mas[i1 + 1];
                    mas[i1 + 1] = t;
                    l++;
                    f = false;
                }
            }
            if (f){break;}
        }
        System.Console.Write("[");
        foreach (var i in mas)
        {
            System.Console.Write($"{i} ");
        }
        System.Console.WriteLine("]");
    }
}
