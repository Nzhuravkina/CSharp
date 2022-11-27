// Методы:

// Вид 1 (Ничего не принимают и не вохвращают):

void Mathod1()
{
    Console.WriteLine("Автор ...");
}
// Как вызвать метод:
Method1();



// Вид 2 (Ничего не возвращают, но могут принимать аругменты)

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Как вызвать метод:
Method2("Текст сообщения");

// ИЛИ

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Как вызвать метод (можно явно указывать, какому аргументу какое значение хотим присвоить(msg: )):
Method2(msg: "Текст сообщения", count: 4);


// Вид 3 (Метод не принимает аргументы, но возвращает результат)

int Method3()
{
    return DateTime.Now.Year;
}

// Как вызвать метод:
int year = Method3();
Console.WriteLine(year);


// Вид 4 (Что-то принимают и что-то возвращают)

str Method4(int count, string text)
{
    int i = 0;
    string result = ""; // Или string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// Как вызвать метод:
string res = Method4(10, "asdf");
Console.WriteLine(res);
