/*
// Question 1:
Card visa = new Card();
visa.pay(30);
Card mastercard = new Card();
mastercard.pay(40);
Console.WriteLine(visa.balance());
Console.WriteLine(mastercard.balance());


class Card
{
    private int euro = 100;
    public void pay(int arg)
    {
        euro = euro - arg;
    }
    public int balance()
    {
        return euro;
    }
}
*/
/*

// Question 2:
PhotoCopier xerox = new PhotoCopier();

xerox.setpaper(5);
xerox.setcopies(3);
xerox.copy(77);
Console.WriteLine(xerox.checkpaper());
xerox.copy(44);
Console.WriteLine(xerox.checkpaper());


class PhotoCopier
{
    private int paper;
    private int copies;

    public void setcopies(int arg)
    {
        copies = arg;
    }
    public void setpaper(int arg)
    {
        paper = arg;
    }
    public void copy(int arg)
    {
        for (int i = 0; i < copies && checkpaper(); i++)
        {
            Console.WriteLine(arg);
            paper = paper - 1;
        }
    }
    public bool checkpaper()
    {
        return (paper > 0);
        //if (paper > 0) return true;
        return false;
        
    }
}
*/


// Question 3:
/*

using System;

class Program
{
    public static void Main()
    {
        string str = "Merito";
        string rstr = Reverse(stxr);
        Console.WriteLine(rstr); // BSW
    }

    public static string Reverse(string str)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            result = str[i] + result;
           
        }
        return result;
    }
}
*/
/*
// Question 3 test:
using System;

class Program
{
    public static void Main()
    {
        string str = "WSB";
        string rstr = Reverse(str);
        Console.WriteLine(rstr); // BSW
    }

    public static string Reverse(string str)
    {
        // add code here
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            result = str[i] + result;

        }
        return result;
    }
}
*/

// Puzzles Question 2:

// v1 
/*
using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine(IsPalindrome("abcde"));
        Console.WriteLine();
        Console.WriteLine(IsPalindrome("abcdcba"));
        Console.WriteLine(IsPalindrome("a"));
        Console.WriteLine(IsPalindrome("ab"));
        Console.WriteLine(IsPalindrome("aba"));
        Console.WriteLine(IsPalindrome("abb"));
        Console.WriteLine(IsPalindrome("abba"));
        Console.WriteLine(IsPalindrome("abcdefghhgfedcba"));
        Console.WriteLine(IsPalindrome("abcdefghihgfedcba"));
        Console.WriteLine(IsPalindrome("abcdefghihgfeddcba"));
    }

    public static bool IsPalindrome(string str)
    {   
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            result = str[i] + result;
        }
        if (str == result)
        {
            return true;
        }
        return false;
    }
}
*/

// v2
/*
using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine(IsPalindrome("abcde"));
        Console.WriteLine();
        Console.WriteLine(IsPalindrome("abcdcba"));
        Console.WriteLine(IsPalindrome("a"));
        Console.WriteLine(IsPalindrome("ab"));
        Console.WriteLine(IsPalindrome("aba"));
        Console.WriteLine(IsPalindrome("abb"));
        Console.WriteLine(IsPalindrome("abba"));
        Console.WriteLine(IsPalindrome("abcdefghhgfedcba"));
        Console.WriteLine(IsPalindrome("abcdefghihgfedcba"));
        Console.WriteLine(IsPalindrome("abcdefghihgfeddcba"));
    }

    public static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == str[str.Length-1])
            {
                return true;
            }
            return false;
        }
            return false;
        
        
    }
}
*/
/*
int[] arrA = { 3, 6, 7, 9 };
int[] arrB = { 2, 4, 7, 8 };

int posA = 0;
int posB = 0;
while (posA < arrA.Length && posB < arrB.Length)
{
    if 

}
*/
using System;
class Program
{
    public static void mergeArrays(int[] arr1, int[] arr2, int[] arr3) {

        int i = 0, j = 0, k = 0;


        while (i < arr1.Length && j < arr2.Length) {

            if (arr1[i] < arr2[j])
                arr3[k++] = arr1[i++];
            else
                arr3[k++] = arr2[j++];

        }
        while (i < arr1.Length)
            arr3[k++] = arr1[i++];
        while (j < arr2.Length)
            arr3[k++] = arr2[j++];
    }

    public static void Main() {
        int[] arr1 = { 1, 3, 5, 7 };
        int[] arr2 = { 2, 4, 6, 8 };
        int[] arr3 = new int[arr1.Length + arr2.Length];

    }
}







/*
// C# program to merge
// two sorted arrays
using System;

class GFG
{
	// Merge arr1[0..n1-1] and
	// arr2[0..n2-1] into
	// arr3[0..n1+n2-1]
	public static void mergeArrays(int[] arr1, int[] arr2,
								int n1, int n2, int[] arr3)
	{
		int i = 0, j = 0, k = 0;
	
		// Traverse both array
		while (i < n1 && j < n2)
		{
			// Check if current element
			// of first array is smaller
			// than current element
			// of second array. If yes,
			// store first array element
			// and increment first array
			// index. Otherwise do same
			// with second array
			if (arr1[i] < arr2[j])
				arr3[k++] = arr1[i++];
			else
				arr3[k++] = arr2[j++];
		}
	
		// Store remaining
		// elements of first array
		while (i < n1)
			arr3[k++] = arr1[i++];
	
		// Store remaining elements
		// of second array
		while (j < n2)
			arr3[k++] = arr2[j++];
	}
	
	// Driver code
	public static void Main()
	{
		int[] arr1 = {1, 3, 5, 7};
		int n1 = arr1.Length;
	
		int[] arr2 = {2, 4, 6, 8};
		int n2 = arr2.Length;
	
		int[] arr3 = new int[n1+n2];
	
		mergeArrays(arr1, arr2, n1, n2, arr3);
	
		Console.Write("Array after merging\n");
		for (int i = 0; i < n1 + n2; i++)
			Console.Write(arr3[i] + " ");
	}
}
/*

