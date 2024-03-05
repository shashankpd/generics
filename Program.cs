/*using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class largestNumberFinder<T> where T : IComparable<T>
    {
        public T findlargest(T s1, T s2, T s3)
        {

        if (s1.CompareTo(s2)>0 && s1.CompareTo(s3)>0)
        {
            return s1;
        }

        else if (s2.CompareTo(s3) > 0 && s2.CompareTo(s1)>0) 
        {
            return s2;
        }
        else
        { 
        return s3;
        }
    }

    }
    
    internal class Program 
    {
    static void Main(string[] args)
    {
        *//* Console.WriteLine("enter the first value");
         int n1=Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("enter the second value");
         int n2 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("enter the second value");
         int n3 = Convert.ToInt32(Console.ReadLine());

     largestNumberFinder<int> find = new largestNumberFinder<int>();
       int res= find.findlargest(n1, n2, n3);
     Console.WriteLine($"{res} is largest");*//*

        //for float values

        *//*Console.WriteLine("enter the first float value");
        float f1 = float.Parse(Console.ReadLine());

        Console.WriteLine("enter the second float value");
        float f2 = float.Parse(Console.ReadLine()); 

        Console.WriteLine("enter the second third value");
        float f3 = float.Parse(Console.ReadLine());

        largestNumberFinder<float> find = new largestNumberFinder<float>();
        float res = find.findlargest(f1, f2, f3);
        Console.WriteLine($"{res} is largest");*//*

        // for string values

        Console.WriteLine("enter the first string value");
        string s1 = Console.ReadLine();

        Console.WriteLine("enter the second string value");
        string s2 = Console.ReadLine();

        Console.WriteLine("enter the third value");
        string s3 = Console.ReadLine();

        largestNumberFinder<string> find = new largestNumberFinder<string>();
        string res = find.findlargest(s1, s2, s3);
        Console.WriteLine($"{res} is largest");

    }
    }*/

using System;
using System.Collections.Generic;
using System.Linq;

public class largestNumberFinder<T> where T : IComparable<T>
{
    public T FindLargest(params T[] values)
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("At least one value must be provided");
        }

        return values.Max();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // Example for int values
        largestNumberFinder<int> findInt = new largestNumberFinder<int>();
        int resInt = findInt.FindLargest(10, 5, 8, 20, 15);
        Console.WriteLine($"{resInt} is the largest");

        // Example for string values
        largestNumberFinder<string> findString = new largestNumberFinder<string>();
        string resString = findString.FindLargest("apple", "banana", "orange", "grape", "kiwi");
        Console.WriteLine($"{resString} is the largest");
    }
}



