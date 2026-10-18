// Пример 1
if (true)
{
    Console.WriteLine("Hello");
}

// Пример 2
if (false)
{
    Console.WriteLine("Hello");
}

// Пример 3
bool execute = true;
if (execute)
{
    Console.WriteLine("Hello");
}

bool notExecute = !execute;
if (notExecute)
{
    Console.WriteLine("Not executed");
}

// Пример 4
static void F1()
{
    if (A())
    {
        if (B())
        {
            Console.WriteLine("Hello");
        }
    }
}

static void F2()
{
    if (A() && B())
    {
        Console.WriteLine("Hello");
    }
}

static void F3()
{
    bool a = A();
    bool b = B();
    bool ok = a && b;
    if (ok)
    {
        Console.WriteLine("Hello");
    }
}

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

// Пример 5
// if (1)
// {
//     Console.WriteLine("Hello");
// }

// Пример 6
if (false)
{
    Console.WriteLine("A");
    Console.WriteLine("B");
}

// Пример 7
if (false)
{
    Console.WriteLine("A");
}
Console.WriteLine("B");

// Пример 8
if (false)
{
    Console.WriteLine("A");
}
else
{
    Console.WriteLine("B");
}

// Пример 9
bool condition = true;
if (condition)
{
    condition = false;
}
else
{
    Console.WriteLine("B");
}

// Пример 10
F();

static void F()
{
    if (true)
    {
        return;
    }
    else
    {
        Console.WriteLine("Else");
    }

    Console.WriteLine("After Else");
}

// Пример 11
if (true)
{
    Console.WriteLine("A");
}
else
{
    Console.WriteLine("B");
}
Console.WriteLine("C");

// Пример 12
if (true)
    Console.WriteLine("A");
else
{
    Console.WriteLine("B");
}

// Пример 13
bool a = true;
bool b = false;
bool c = false;

if (a)
{
    Console.WriteLine("A");
}
else if (b)
{
    Console.WriteLine("B");
}
else if (c)
{
    Console.WriteLine("C");
}

// Пример 14
F(true, false, false);

static void F(bool a, bool b, bool c)
{
    if (a)
    {
        Console.WriteLine("A");
        return;
    }

    Console.WriteLine("After A");

    if (b)
    {
        Console.WriteLine("B");
        return;
    }

    Console.WriteLine("After B");

    if (c)
    {
        Console.WriteLine("C");
        return;
    }

    Console.WriteLine("After C");
}

// Пример 15
int i = 0;
while (true)
{
    if (i == 4)
    {
        Console.WriteLine("ERROR: Should not happen");
        break;
    }

    if (i == 3)
    {
        Console.WriteLine("Exit");
        break;
    }

    if (i == 0)
    {
        Console.WriteLine("Increase by 2 on first iter");
        i += 2;
        continue;
    }

    Console.WriteLine("Increase by 1 normally");
    i++;
}

// Пример 16
static int F()
{
    while (true)
    {
        if (true)
        {
            return 0;
        }

        break;
    }

    return 1;
}
