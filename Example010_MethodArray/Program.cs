int[] array = {31,2,13,45,5,68,5,58};

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine (index); // консоль пишет все индексы элементов, которые мы ищем с помощ.переменной find
        // break; эту команду используем, если нам достаточно найти только первый индекс совпавшего элемента
    }
    index++;
    // или index = index + 1;
}