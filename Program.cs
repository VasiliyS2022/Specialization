///////////////////////////////////////////////////////////////////////////////////////////////////////
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равно 
// 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// метод для подсчета количества элементов, и создания массива с количеством <= 3
string[] Array3(string[] array)
{
    int count = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    
    for(int i = 0, j = 0; j < count; i++, j++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
        }
        else j--;
    }
    return newArray;
}


// метод для вывода массива строковых элементов
void ShowStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] myArray = 
{
    "hello", "2", "world", ":-)", "1234", "1567", "-2", 
    "computer sciense", "Russia", "Denmark", "Kazan"
};
Console.Write("Array: ");
ShowStringArray(myArray);
string[] newMyArray = Array3(myArray);
Console.Write("New array: ");
ShowStringArray(newMyArray);
///////////////////////////////////////////////////////////////////////////////////////////////////////
