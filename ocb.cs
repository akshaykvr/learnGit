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
     * Complete the 'organizingContainers' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts 2D_INTEGER_ARRAY container as parameter.
     */

    public static string organizingContainers(List<List<int>> container)
    {
        
        int n=container.Count;
        int[] sum_row=new int[n];
        int[] sum_column=new int[n];
        string result="";
        
        
        for(int i=0;i<n;i++)
        {
            int sum=0;
            foreach(int p in container[i])
            {
               sum+=p; 
            }
            sum_row[i]=sum;
        }
        
        
        for(int j=0;j<n;j++)
        {
            int b=0;
            for(int k=0;k<n;k++)
            {
               b+=container[k][j];
            }
            sum_column[j]=b;
        }
        
        Array.Sort(sum_row);
        Array.Sort(sum_column);
        
        for(int l=0;l<n;l++)
        {
        if(sum_row[l]==sum_column[l])
        {
            result="Possible";
        }
        else
        {
            result="Impossible";
        }
        
        }
        return result;
        

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> container = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                container.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(containerTemp => Convert.ToInt32(containerTemp)).ToList());
            }

            string result = Result.organizingContainers(container);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

