int a = 15;
int b = 3;

Add(a, b);
Add(10, 100);
Add(9754, 78);

Multiply(a, b);
Multiply(10, 100);
Multiply(38, 45);

Substract(a, b);
Substract(10, 100);
Substract(25, 5);

Divide(a, b);
Divide(100, 10);
Divide(25, 5);
static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

static void Multiply (int x, int y)
{
    Console.WriteLine ($"{x} * {y} = {x * y}");
}

static void Substract(int x, int y)
{
    Console.WriteLine ($"{x} - {y} = {x - y}");
}

static void Divide(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}