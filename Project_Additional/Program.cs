// See https://aka.ms/new-console-template for more information
int a, i, length, x, y;
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
int[] newarray = new int[0];
FillArray(array);
Console.Write("Source array is: ");
PrintArray(array);
Console.WriteLine();
length = a - 1;
for (i = 0; i < array.Length / 2; i++)
{
        x = array[i] * array[length];
        newarray = newarray.Append(x).ToArray();
        length -= 1;
}
if (array.Length % 2 != 0)
{
y = array[a / 2];
newarray = newarray.Append(y).ToArray();
}
Console.Write("New array is: ");
PrintArray(newarray);
Console.WriteLine();