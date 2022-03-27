// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string[] array = new string[8];
for (int i = 0; i < array.Length; i++) {
    Console.WriteLine($"Введите {i + 1} элемент массива");
    array[i] = Convert.ToString(Console.ReadLine());
}
for (int n = 0; n < array.Length; n++) {
    if (n < array.Length - 1) Console.Write($"{array[n]}; "); else Console.Write($"{array[n]}");
}