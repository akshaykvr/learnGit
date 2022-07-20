using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        for(int i=w.Length-2;i>=0;i--)
        {
            for(int j=w.Length-1;j>i;j--)
            {
                if(w[j]>w[i])
                {
                    string result="";
                    for(int k=0;k<i;k++)
                    {
                        result+=w[k];
                    }
                    result+=w[j];
                    for(int t=w.Length-1;t>i;t--)
                    {
                        if(t!=j)
                        {
                            result+=w[t];
                        }
                        else
                        {
                            result+=w[i];
                        }
                        
                    }
                    return result;
                }
            }
        }
        return "no answer";
        

    }
    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

