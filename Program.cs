//Напишите программу, которая перевернет массив (последний элемент будет на первом месте,
//а первый на последнем и т.д.)

int [] CreateNewArray (int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowNewArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
}

int ReverseArray(int [] array)
{
    int k = array.Length;
    for (int i = 0; i < k / 2; i++)    // делим на два что - бы остановить разворот, иначе вернемся к исходному порядку
    {
        int temp = array[i];               //ячейка для заполнения
        array[i] = array[k - 1 - i];       //  
        array[k - 1 - i] = temp;           // сохраняем в ячейку
    }
    return array;
}
// 1-я итерация:
//i 0 1 2 3 4 5 
//i < k (i =0; k = 6)
//i = 0 -> k - 1 -0    0 <-> 5 -> 5 1 2 3 4 0
// 2-я итерация:
//i = 1 -> k = 4    0 <-> 4 -> 5 4 2 3 1 0 и т.д.

Console.WriteLine("Input size of array: ");
int countElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min posible value of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max posible value of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateNewArray(countElem, minValue, maxValue);
ShowNewArray(newArray);
Console.Writeline();
int [] reversedArray = ReverseArray(newArray);
ShowNewArray(reversedArray);

//ShowNewArray(ReverseArray(newArray));   // можно записать так (замена пред. двум строкам)


//

