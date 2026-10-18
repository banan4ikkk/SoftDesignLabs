// Пример 1
int a = 5;
F();

static void F()
{
    int b = 6;
}

// Пример 2
int a = 5;
F();

static void F()
{
    int a = 6;
}

// Пример 3
int a = 5;
F();
b = 7;

static void F()
{
    int b = 6;
}

// Пример 4
int a = 5;
F(a);

static void F(int b)
{
    b = 6;
}

// Пример 5
int a = 5;
F(a);

static void F(int a)
{
    a = 6;
}

// Пример 6
int b = 6;
F(1, b);

static int F(int a, int b)
{
    return a + b;
}

// Пример 7
int b = 6;
int s = F(1, b);
b = s;

static int F(int a, int b)
{
    return a + b;
}

// Пример 8 
int b = 6;
int s = F(F(1, F(2, b)), b);

static int F(int a, int b)
{
    return a + b;
}

// Пример 9 
F(1);

static void F(int a)
{
    F(a);
}

// Пример 10
int a = 1;
F(a + 2);
a = 10;

static void F(int x)
{
    Console.WriteLine(x);
}

// Пример 11 
int a = 1;
int b = F(a);
a = 2;

Console.WriteLine(a);
Console.WriteLine(b);

static int F(int x)
{
    return x;
}

// Пример 12
string s = GetGreeting();
Console.WriteLine(s);

static string GetGreeting()
{
    return "Привет";
}