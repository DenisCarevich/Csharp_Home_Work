/*
    Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
    Использовать рекурсию, не использовать циклы.
*/

Console.WriteLine("Исходный массив:");
int[] resultOriginalArray = GetOriginalArray();
Console.WriteLine("");

RevertArray(resultOriginalArray);

void RevertArray(int[] array) {
    if (array.Length < 1) return;

    Console.Write($"{array[array.Length - 1]} ");

    RevertArray(array[..(array.Length - 1)]);
}

int[] GetOriginalArray() {
    int[] originalArray = new int[5];
    Random randNum = new Random();

    for (int i = 0; i < originalArray.Length; i++)
    {
        int val = randNum.Next(0, 20);
        originalArray[i] = val;

        Console.Write($"{val} ");
    }

    return originalArray;
}

