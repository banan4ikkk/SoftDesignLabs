// Пример 1
bool a = true;
Console.WriteLine(a);

// Пример 2
bool a = null;

// Пример 3
bool a = 1 == 2;
Console.WriteLine(a);

// Пример 4
int x = 3;
int y = 4;
bool b = x == y;
Console.WriteLine(b);

// Пример 5

int x = 3;
int y = 4;
bool b = x * 2 == y + 4;
Console.WriteLine(b);

// Пример 6
bool a = 1 > 2;
a = 3 == 3;
Console.WriteLine(a);

// Пример 7
bool a = true;
F(a);

static void F(bool x)
{
    Console.WriteLine(x);
}

// Пример 8 
F(5 > 3);

static void F(bool flag)
{
    Console.WriteLine(flag);
}

// Пример 9 
bool result = F();
Console.WriteLine(result);

static bool F()
{
    return true;
}

// Пример 10
bool result = IsGreater(5, 3);
Console.WriteLine(result);

static bool IsGreater(int a, int b)
{
    return a > b;
}

// Пример 11 
bool a = true;
bool b = false;
bool c = a == b;
Console.WriteLine(c);

// Пример 12
bool a = false;
bool b = !a;
Console.WriteLine(b);

// Пример 13 
bool a = true;
bool b = false;
bool c = a && b;
Console.WriteLine(c);

// Пример 14
bool result = A() && B();

static bool A()
{
    Console.WriteLine("A");
    return true;
}

static bool B()
{
    Console.WriteLine("B");
    return true;
}

// Пример 15
bool result = A() && B();

static bool A()
{
    Console.WriteLine("A");
    return true;
}

static bool B()
{
    Console.WriteLine("B");
    return false;
}

// Пример 16
bool result = A() && B();

static bool A()
{
    Console.WriteLine("A");
    return false;
}

static bool B()
{
    Console.WriteLine("B");
    return true;
}
// Пример 17
bool result = A() || B();

static bool A()
{
    Console.WriteLine("A");
    return true;
}

static bool B()
{
    Console.WriteLine("B");
    return true;
}