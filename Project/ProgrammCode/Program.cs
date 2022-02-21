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
void FindStringNeeded(string[] array)
{
    Console.Write("Массив, в котором все строки меньше или равны трём символам: ( ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.Write($"{array[i]} ");
    }
    Console.Write(")");
}
string[] initialArrayString = { "five", "tree", "cow", "13", "-123", "it" }; ;
PrintInitialArray(initialArrayString);
Console.Write(" => ");
FindStringNeeded(initialArrayString);