// Напсать программу, которая из имеющегося массива строк формирует массив из строк, длина
// которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры или 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// обойтись только массивами. 

Console.Clear();

string[] massiv;
Console.WriteLine("Введите элементы строчного массива через пробел:");
string stroka = Console.ReadLine() ?? "0";
massiv = stroka.Split(' ');
Console.WriteLine();

int realSize = 0;
foreach (string value in massiv)                // сначала считаем количество элементов с длиной =< 3
{                                               // в исходном массиве ( realSize )
    if (value.Length <= 3)
    {
        realSize++;
    }
}

string[] result = new string[realSize];         // после этого создаем новый массив с длиной согласно
int i = 0;                                      // предшествующего расчета и заполняем его элементами,
foreach (string value in massiv)                // удовлетворяющими условиям задачи
{
    if (value.Length <= 3) 
    {
        result[i] = value;
        i++;;
    }
}

Console.WriteLine("Результат выборки:");
PrintMas(result);

void PrintMas(string[] mas)                     // метод распечатки массива
{
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++)    // печатаем до предпоследнего элемента с пробелами
    {
        if (mas[i] != "" || mas[i] != " ") 
        Console.Write($"{mas[i]} ");                              
    }
    Console.Write(mas[mas.Length - 1]);         // печатаем последний элемент массива без пробела 
    Console.WriteLine("]");                     
}
