//  Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

Console.WriteLine("Введите координаты элемента через запятую");


var arr = CreateArray(4,6);
var numbers = GetNumbers(Console.ReadLine());

if (arr.GetLength(0)-1 >= numbers[0] && arr.GetLength(1)-1 >= numbers[1]){
    Console.WriteLine(arr[numbers[0], numbers[1]]);
}else{
    Console.WriteLine($"[{numbers[0]}, {numbers[1]}] -> такого числа нет в массиве");
}

int[] GetNumbers(string str){
    var strings = str.Split(',');
    var res = new int[2];
    res[0] = int.Parse(strings[0]);
    res[1] = int.Parse(strings[1]);
    return res;
}

int[,] CreateArray(int m, int n)
{
    var res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        var line = Line(n);
        for (int x = 0; x < line.Length; x++)
        {
            res[i, x] = line[x];
        }
    }

    return res;
}

int[] Line(int count)
{
    var res = new int[count];
    for (int i = 0; i < count; i++)
    {
        res[i] = new Random().Next(1, 10);
    }

    return res;
}
