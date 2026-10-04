// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Jerry"); // задание 1

PrintABC();    // задание 2
Thread.Sleep(500);
PrintABC();
Thread.Sleep(500);
PrintABC();
Thread.Sleep(500);

void PrintABC() 
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

A();  //задание 3
A();
A();

void A()
{
    Console.WriteLine("Функция A");
    B();
    C();
}

void B()
{
    Console.WriteLine("Функция B");
}

void C()
{
    Console.WriteLine("Функция C");
}

Console.WriteLine("Начало"); // задание 4

void Unused()
{
    Console.WriteLine("Меня никто не вызвал");
}

Console.WriteLine("Конец");

First(); // задание 5

void First()
{
    Console.WriteLine("First");
    Second(); // Second определена ниже, но это работает
}

void Second()
{
    Console.WriteLine("Second");
}

Console.ReadKey();
