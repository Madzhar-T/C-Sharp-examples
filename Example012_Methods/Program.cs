// Вид 1. Ничего не принимают, ничего не возвращают. Можно поставить подпись. Например:

void Method1()
{
    Console.WriteLine("Автор...");
}
Method1(); // вызов метода




// Вид 2. Ничего не возвращают, но могут принимать какие-то аргументы:

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("текст сообщения");

// если метод принимает какое-то количество аргументов, то они могут быть именованными

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine (msg);
        i++;
    }
}
// Method21("Текст", 4); // или можно использовать именованные аргументы, если они именованы, то писать их можно в любом порядке
Method21(msg: "Текст новый", count: 4);




// Вид 3 Что-то возвращают (return), но ничего не принимают

int Method3() // обязательно тип данных
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);




// Вид 4. Что-то принимают и что-то возвращают.

//  string Method4(int count, string text)
//  {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }   
//     return result;
//  }

// четвертый метод с циклом for
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    } 
    return result;
}

string res = Method4(10, "asdf "); // в скобках последовательно записываем аргументы метода, которые даем на вход
Console.WriteLine (res);
