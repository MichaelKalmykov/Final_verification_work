string[] array = new string[4] { "1234", "1567", "-2", "computer science" };

Console.Clear();
Console.WriteLine($"Исходный массив: [ {string.Join(", ", array)} ]");

int count = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) count++;

if (count > 0)
{
    Console.WriteLine($"В исходном массиве, {count} элементов, длинной до трех символов.");
    string[] result = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    Console.WriteLine($"Итоговый массив: [ {string.Join(", ", result)} ]");
}
else
{
    Console.WriteLine($"В исходном массиве нет элементов, длинной до трех символов.");
}