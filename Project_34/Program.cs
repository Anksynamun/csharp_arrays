// See https://aka.ms/new-console-template for more information
int a, n = 0;
void FillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(100, 999);
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
Console.Write("Enter the length of array: ");
a = Convert.ToInt32(Console.ReadLine()!);
int[] array = new int [a];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        n++;
    }
}
Console.WriteLine("This array have this number of even numbers: " + n);