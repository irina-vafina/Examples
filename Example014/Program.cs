// Функции продолжение
// Виды методов

//вид 1
//не принимают, не возвращают

/*void Method1()
{
    Console.WriteLine("Автор...");
}

Method1();
*/


//вид 2
//что-то принимают, не возвращают

/*void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");
*/

/*void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg:"Текст сообщения");
*/

/*void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Текст", 4);
// или
//Method21(msg:"Текст", count: 4);
// или
Method21(count: 4, msg: "новый текст");
*/

// Вид 3
// ничего не принимают, что то возврают. 

/*int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Вид 4
// что-то принимают, что-то возвращают

/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  // пустая строка, вместо string result=" ";

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

// та же программа, но цикл for

/*string Method4(int count, string text)
{
    string result = String.Empty;  // пустая строка, вместо string result=" ";
    
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
*/

/*for(int i=0; i>10; i++) // пример цикла в цикле закрашивает прямоугольник  вроде
{
    for(int j=0; j<10; j++)
    {
        Console.WriteLine(i*j);
    }
    Console.WriteLine();
}
*/
/*
// Таблица умножения

for(int i=2; i<=10; i++) 
{
    for(int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", 
// а большие "С" заменить на "с".


/*       string text = "-Я думаю, - сказал князь, улыбаясь, - что,"
           + "ежели бы вас послали вместо нашего милого Винценгерде,"
           + "вы бы взяли приступом согласие прусского короля"
           + "Вы так красноречивы. Вы дадите мне чаю?";

       // string s = "qwerty"
       //             012 
       // s[3] // r

string Replase(string text, char oldValue, char newValue)
{
   string result = String.Empty;

   int length = text.Length;
   for(int i = 0; i < length; i++)
   {
       if(text[i] == oldValue) result = result + $"{newValue}";
       else result = result + $"{text[i]}";
   }

   return result;
}

string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'С', 'с');
Console.WriteLine(newText);
*/

// отсортировать массив. найти позицию в неотсорт.части,
// заменить ее с первой неотсорт позицией. пока не закончатся все позиции.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);