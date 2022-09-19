using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifFilter : MonoBehaviour
{
    public static int[] Diff(int[] xs)
    {
        int[] copyArray = new int[xs.Length];
        int dif = 0;
        int prevNum = 0;

        for (int i = 0; i < xs.Length; i++)
        {
            int num = xs[i];

            if (i == 0)
            {
                prevNum = 0;
                dif = num - prevNum;
            }
            else
            {
                prevNum = xs[i - 1];
                dif = prevNum - num;
            }

            if (dif < 0)
            {
                dif *= -1;
            }

            copyArray[i] = dif;

        }
        return copyArray;
    }
}
