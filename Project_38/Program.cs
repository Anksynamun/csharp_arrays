// See https://aka.ms/new-console-template for more information
int a, i, d, max, min;
Console.Write("Enter the length of array: ");
a = Convert.ToInt32(Console.ReadLine()!);
int[] array = new int [a];
Random myrandom = new Random();
for (i = 0; i < array.Length; i++)
{
    array[i] = myrandom.Next(0, 100);
}
Array.ForEach(array, Console.WriteLine);
max = array.Max();
min = array.Min();
d = max - min;
Console.WriteLine("Max number of array is: " + max);
Console.WriteLine ("Min number of array is: " + min);
Console.WriteLine("Difference between the elements of array is: " + d);