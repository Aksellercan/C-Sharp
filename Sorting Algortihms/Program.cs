// See https://aka.ms/new-console-template for more information


/*

  int[] arr1 = { 13, 1, 4, 7, 5, 3, 0 };
  for (int i = 0; i < arr1.Length; i++)
  {
      for (int j = 0; j < arr1.Length - i - 1; j++)
      {
          if (arr1[j] > arr1[j + 1])
          {
              int temp = arr1[j];
              arr1[j] = arr1[j + 1];
          arr1[j + 1] = temp; 

          }
      }
}

for (int o = 0; o < arr1.Length; o++)
{
  Console.Write($"{arr1[o]} ");
}
*/
/*
using System;

class Program
{
    public static void Main()
    {
        int[] array = { -7, 2, 3, 8, -10, 4, -6, -10, -2, -7, 10, 5, 2, 9, -9, -5, 3, 8 };
       int[] sortedarray = BubbleSort(array);
        foreach (int num in sortedarray)
        {
            Console.Write($"{num} ");
        }
    }

    public static int[] BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                }
            }
        }

       
        return array;
       

    }
}
*/
/*
using System;

class Program
{
    public static void Main()
    {
        int[] array = { 3,1,2};
        int[] sortedarray = InsertionSort(array);
        foreach (int num in sortedarray)
        {
            Console.Write($"{num} ");
        }
    }

    public static int[] InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int current = array[i];
            int j = i-1; //previous element
            while (j > -1 && current < array[j])
            {
                array[j+1] = array[j];
                j--;
            }
            array[j+1] = current;
        }
        return array;
    }
}
 */
/*

    int[] array = new int[10];
    for (int a = 0; a < array.Length; a++)
    {
        Console.WriteLine($"{a + 1}. number: ");
        array[a] = int.Parse(Console.ReadLine());
    }



static int[] bubblesort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}
    int[] sortedarray = bubblesort(array);
    foreach (int num in sortedarray)
    {
        Console.Write($"{num} ");
    }

    */

/*

//bubblesort

int[] array = { 2, 4, 8, 6, 1, 3, 5, 9, 10, 7 };
Console.WriteLine("Bubblesort");
for (int i = 0; i < array.Length; i++){
    for (int j = 0; j < array.Length - i - 1; j++)
    {
        if (array[j] > array[j+1])
        {
            int temp=array[j];
            array[j]=array[j+1];
            array[j+1]=temp;

        }
    }

}
foreach (int num in array)
{
    Console.Write($"{num} ");
}
Console.WriteLine();

//insertion sort
Console.WriteLine("Inserion sort");
//int[] array = { 2, 4, 8, 6, 1, 3, 5, 9, 10, 7 };
for (int k = 1; k < array.Length; k++)
{
    int current = array[k];
    int l = k-1;
    while (l > -1 && current < array[l])
    {
        array[l+1] = array[l];
        l--;
    }
    array[l +1] = current;
}
foreach (int num in array)
{
    Console.Write($"{num} ");
}

*/

/*
//alphabetic sorting bubblesort
using System;

class Program
{
    static void Main()
    {
        string[] fruits = { "apple", "banana", "orange", "pear", "grape" };

        // TODO: Implement bubble sort to sort the 'fruits' array

        Console.WriteLine("Sorted fruits:");
        foreach (string fruit in fruits)
        {
            Console.Write($"{fruit} ");
        }
    }

    static void BubbleSort(string[] array)
    {
        // TODO: Implement bubble sort algorithm here

        for (int i = 0; i < array.Length; i++) {
            for (int j = 0; j < array.Length-i-1; j++)
            {
                if (string.Compare(array[j], array[j+1]) > 0)
                {
                    string temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
                }
    }
}
*/