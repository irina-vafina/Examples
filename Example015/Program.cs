// Лекция 4 двумерные массивы и рекурсия

//выводит таблицу из 2 строк и 5 столбцов. на месте ячейки 1,2 слово *слово*
/*
string[,] table = new string[2,5];  //2строки5столбцов
*/
// String.Empty    //инициализация для строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[0,0] table[1,1] table[1,2] table[1,3] table[1,4]
/*
table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}-");
    }
Console.WriteLine();
}
*/
//выводит таблицу из 3 строк и 4 столбцов
/*
int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
*/

/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1; 10)
        }
    }
}


int[,] matrix = new int[3, 4]; //инициализация массива
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
// рисует контур +
/*
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine();
    }
}

//закрашивает внутреннюю область рисунка, ограниченного +

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] == 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}
FillImage(int row, int col)
*/
//найти факториал 5, затем цикл до 40
/*
double Factorial(int n)
{
    //1!=1
    //0!=1
    if (n==1) return 1;
    else return n * Factorial(n-1);
}
//Console.WriteLine(Factorial(3));// 1*2*3=6
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}!={Factorial(i)}");
}
*/
//фибоначчи
// f(1)=1
// f(2)=1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 40; i++)
{
    //Console.WriteLine(Fibonacci(i));
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}





//















