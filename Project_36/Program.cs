// See https://aka.ms/new-console-template for more information
int a, i, sum = 0;
void FillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;
    }
}
void PrintArray(int[] coll)
{
    int pos = 0;
    while (pos < coll.Length)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }
}
Console.Write("Enter the length of an array: ");
a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
FillArray(array);
for (i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Sum of numbers with odd indexes is: " + sum);