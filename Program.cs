//Напишите программу, которая перевернет массив (последний элемент будет на первом месте,
//а первый на последнем и т.д.)

/*
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

int [] ReverseArray(int [] array)
{
    int k = array.Length;
    for (int i = 0; i < k /2; i++)    // делим на два что - бы остановить разворот, иначе вернемся к исходному порядку
    {
        int temp = array[i];            //ячейка для заполнения
        array[i] = array[k - 1 - i];
        array[k - 1 - i] = temp;        // сохраняем в ячейку
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
Console.Write(" -> ");                       
//Console.WriteLine(); - на следующей строке
int [] reversedArray = ReverseArray(newArray);
ShowNewArray(reversedArray);

//ShowNewArray(ReverseArray(newArray));   // можно записать так (замена пред. двум строкам)
*/

//Не используя рекурсию, выведете первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b (задает пользователь)
//Последовательность Фибоначчи.
// F(i) = F(i-1) + F(i-2)
//4 5 9 14 23 (N = 5)
//1 1 -> 1 + 1 = 2; 1 + 2 = 3; 2 + 3 = 5
//1 1 2 3 5 

/*
void Fibonachi(int count, int a, int b)
{
    int [] fibArray = new int [count];
    fibArray[0] = a;
    fibArray[1] = b;
    for (int i = 2; i < count; i++)      // i = 2, тк первые два эл-та нам даны (a, b)
        fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
    ShowArray(fibArray);
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine("Input count of elements: ");
int countElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first element: ");
int firstElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second element: ");
int secondElem = Convert.ToInt32(Console.ReadLine());

Fibonachi(countElem, firstElem, secondElem);
*/

//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длинны.
//каждая сторона треугольника меньше суммы двух других сторон.

bool Triangle(int side1, int side2, int side3)

{
    if (side1 + side2 > side3 && side2 + side3 > side3 && side1 + side3 > side2)
        return true;
    else return false;
}

Console.WriteLine($"Input first side: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input second side: ");
int secondtSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input trird side: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(firstSide, secondtSide, thirdSide);
if (result == true)
    Console.WriteLine("Triangle exists");
else Console.WriteLine("Triangle does not exists");

