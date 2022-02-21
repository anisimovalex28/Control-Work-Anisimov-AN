// Написать программу, которая из имеющегося массива строк формируте массив из строк, длина которых меньше либо равна 3 символа 
void PrintInitialArray(string[] array)
{
    Console.Write("Изначальный массив: ( ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(")");
}
