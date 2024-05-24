//создаем метод для разделения строки из консоли в массив по пробелу “ ”
string[] GetArrayStringConsole (string inConsolSimvol)
{
    string[] arraySimvol = new string[inConsolSimvol.Length];
    arraySimvol = inConsolSimvol.Split(" ");
    return arraySimvol;
}

//Создаем метод сортирующий символы из массива. 
//Отсчитываем количество элементов, удовлетворяющих требованию (необходимо для определения длинны нового массива). 
//Создаем массив по выясненой длинне, вносим туда символы удовлетворяющие требованиям.
string[] GetArrayThreeSimvol (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSimvol = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            arrayThreeSimvol[j] = simvol;
            j++;
        }
    }
    return arrayThreeSimvol;
}

//создаем метод для вывода информации из массивов с использованием цеклического вывода каждого элемента массива.
void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//Создаем вариант ввода символов в консоле пользователем (с пояснениями что неодходимо делать), и выводом результатов
Console.Write("Введите набор символов через знак пробела ( ) - ");
string inStringSimvol = Console.ReadLine();
string[] arraySimvol = GetArrayStringConsole(inStringSimvol);
Console.WriteLine();
Console.Write("Введенные символы - ");
Print(GetArrayStringConsole(inStringSimvol));
Console.WriteLine();
// Проверка метода GetArrayThreeSimvol, без ввода в консоль
// string[] arraySimvol = new string[5] {"123", "23", "hello", "world", "res"};
Console.Write("Введенные символы длинной меньше либо равны 3 - ");
Print(GetArrayThreeSimvol(arraySimvol));
Console.WriteLine();

