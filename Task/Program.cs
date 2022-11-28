/* Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выпонения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello","2","world",":-)"]->["2",":-)"]
["1234","1567","-2","computer science"]->["-2"]  */

// строка состоящая из трёх или меньше символов
int size = 6;

string[] arrayOne = new string[size];

Console.WriteLine($"Заполните строки = {size} используя букывы, цифры, символы без пробелов. После каждого ввода подтверждайте командой Enter");

FillArray(arrayOne);


string[] arrayFinal = new string[size];
int len = 3;
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (arrayOne[j].Length <= len)
    {
        arrayFinal[pos] = arrayOne[j];
        pos++;
    }
}
PrintArray(arrayOne);
PrintArray(arrayFinal);


void FillArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
    Console.WriteLine();
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write("[ ");
        {
            Console.Write(arr[i] + " ");
        }
        Console.Write("]");
    }
    Console.Write(" -> ");
}



