
// Создание массива

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

// Сохраняем кол-во элементов в массиве

int array_elements = array.Length;

// Выводим на экран

Console.WriteLine("Кол-во элементов:");

Console.WriteLine(array_elements);

// Складываем все элементы

int array_sum = 0;
for (int i = 0; i < array_elements; i++)
    array_sum = array_sum + array[i];

int array1 = array_sum / array_elements;
Console.WriteLine("Среднеарифметическое массива:");
Console.WriteLine(array1);

Console.WriteLine("Элементы массива:");


// Вывод всех элементов массива:
for (int i = 0; i < array_elements; i++)
    Console.WriteLine(array[i]);


// минимальный элемент
int array_min = array.Min();
Console.WriteLine("Минимальный элемент:");
Console.WriteLine(array_min);

// изменение положения элементов

