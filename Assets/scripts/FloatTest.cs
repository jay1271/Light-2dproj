using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class FloatTest : MonoBehaviour
{
    string abc;
    public int y;
    public int x;
   public float a ;
    public float b;
    byte[] vs;
    bool abcd;
    private void Start()
    {
     
        palindrome();
        /*vs= BitConverter.GetBytes(a);
        Debug.Log(vs[0]);
        Debug.Log(vs[1]);
        Debug.Log(vs[2]);
        Debug.Log(vs[3]);
        Debug.Log(vs.Length);
        GetFloat();*/
    }

    void GetFloat()
    {
         b = BitConverter.ToSingle(vs, 1);
    }


    void palindrome()
    {
        string a = "abcdee";

        for (int xy = 0; xy < a.Length; xy++)
        {
            abc = abc + a.Substring((a.Length - 1) - xy, 1);
            Debug.Log(abc);
        }


        //for int

        while (x > y)
        {
            y = y * 10 + (x % 10);
            x /= 10;
            
        }
        if(x == y || y%10 == x)
        {
            abcd = true;
        }
    }
}
