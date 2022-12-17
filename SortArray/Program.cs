using Sort_Array;

Console.WriteLine("Введите числа для сортировки");
Console.WriteLine();
string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] array = new int[words.Length];
for (int i = 0; i < words.Length; i++)
{
    array[i] = int.Parse(words[i]);
}

var result = Sort.SortArray(array);
if (result.Length == 0 || result is null)
{
    Console.WriteLine("Массив пустой");
    return;
}

Console.Write($"Отсортированный массив - ");
foreach (int res in result)
{
    Console.Write($"{res} ");
}