void FillArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length) 
    {
        collection[index] = new Random().Next(1,10);
        index++;
    } 
}


void PrintArray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если поставить в этот счетчик значение ноль, 
    // то если не будет найдено ни одного совпадающего с переменной find элемента,
    // то на выходе будет указан нулевой индекс, что неправильно

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //останавливает цикл после того как нашел первый элемент
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
array[3] = 4; // принудительно проставляем в индекс 3 четверку
array[7] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // если оставить 4, то результатом будет индекс номер 3, если рандомный выбор не даст четверку раньше. 
// если поставить лбое значение больше или равно 10, то значение переменной pos останется -1
Console.WriteLine(pos);
