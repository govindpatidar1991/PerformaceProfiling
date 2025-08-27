// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Add(5, 3);
Subtract(10, 4);
Multiply(6, 7);
Increment(9);
Decrement(15);
Divide(20, 4);
Absolute(-10);
Max(8, 12);
Modulo(10, 3);
Negate(5);

static int Add(int a, int b) => a + b;

static int Subtract(int a, int b) => a - b;

static int Multiply(int a, int b) => a * b;

static double Divide(int a, int b) => b != 0 ? (double)a / b : throw new DivideByZeroException();

static int Modulo(int a, int b) => b != 0 ? a % b : throw new DivideByZeroException();

static int Increment(int a) => a + 1;

static int Decrement(int a) => a - 1;

static int Negate(int a) => -a;

static int Absolute(int a) => Math.Abs(a);

static int Max(int a, int b) => Math.Max(a, b);