string [] UserArray = new string[NumFromConsole("размер массива")];
StringKeyboard(UserArray);
Console.Clear();
System.Console.WriteLine("Начальный массив: ");
Print(UserArray);
int size = CountOfValues (UserArray);
string [] resultArray = new string [size];
ThreeDigitsArray(UserArray);
System.Console.WriteLine();
System.Console.WriteLine("Конечный массив: ");
Print(resultArray);

Console.ReadKey();

int NumFromConsole(string userNumber)  //  Метод для ввода значений с консоли
{
    Console.Write($"Введите значение {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void StringKeyboard(string [] elements)  //  Метод заполнение одномерного массива с клавиатуры
{
    int length = elements.Length;

    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine("Введите элемент: ");
        elements[i] = Console.ReadLine();
    }
    return;
}

void Print(string [] point)  //  Метод вывод в консоль одномерного массива
{
    int digit = point.Length;
    for (int count = 0; count < digit; count++)
    {
        System.Console.Write(point[count] + " ");
    }
    return;
}

int CountOfValues (string [] array) // Метод для подсчета количества элементов в результирующем массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= 3)
                count++;
        }    
    }
    return count;
}

string [] ThreeDigitsArray (string [] array) //  Метод для записи элементов длиной больше 3-х символов в новый массив
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= 3)
            {
                resultArray[j] = array[i];
                j++;
            }    
        }    
    }
    return resultArray;
}
