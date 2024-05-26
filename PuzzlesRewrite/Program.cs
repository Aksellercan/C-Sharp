/*
// See https://aka.ms/new-console-template for more information
int[] arr1 = { 1, 3, 5, 7 };
int[] arr2 = { 2, 4, 6, 8 };
int[] Mergedarray = new int[arr1.Length + arr2.Length];
for (int i = 0; i < arr1.Length; i++)
{
    Mergedarray[i] = arr1[i];
}
for (int j = 0; j < arr1.Length; j++)
{
    Mergedarray[j+ arr1.Length] = arr2[j];
    
}

Console.WriteLine(string.Join(" ", Mergedarray));

*/
//O(n+n^2) Time Complexity
int[] arr = new int[20];
int target = 10;
for (int a = 0; a< arr.Length; a++) 
{
    arr[a] = a+1;
}
Console.WriteLine( "Array: " + String.Join(", ", arr));
for (int i = 0; i < arr.Length-1; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] + arr[j] == target) {
            Console.WriteLine("Positions: "+ i +","+ j);
        }
    }
    
}