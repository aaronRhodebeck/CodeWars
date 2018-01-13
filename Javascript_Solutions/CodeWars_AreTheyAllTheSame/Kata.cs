using System;

public static class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (ArraysAreBad(a, b))
        {
            return false;
        }
        return CompareArrays(a, b);
    }

    private static bool ArraysAreBad(int[] a, int[] b)
    {
        if (a == null || b == null
        || a.Length != b.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool CompareArrays(int[] a, int[] b)
    {
        Array.Sort(a);
        Array.Sort(b);

        for (int i = 0; i < a.Length; i++)
        {
            if(a[i] * a[i] != b[i])
            {
                return false;
            }
        }
        return true;
    }
}