// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

void FillArray(int[] collection)   
{                                    
                                    
   
    int length = collection.Length;  
    int index = 0;                      
    while (index < length)           
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; 
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position] + " ");
        position++;
    }
Console.WriteLine();
}

void Proizvedenije(int[] col)
{
    int count = col.Length; 
    int position = 0;
    int res = 0;
    int a = 0;
    int b = 0;
    int c = 0;
    if(count % 2 != 0)
    {
        while(a < ((count/2) - 1/2))
        {
            res = (col[position + b]) * (col[count - 1 - c]);
            Console.WriteLine("Ответ " + res);
            a++;
            b++;
            c++;
        }
        res = (col[count/2]);
        Console.WriteLine("Ответ " + res);
    }
    else
    {
        while(a < (count/2))
        {
            res = (col[position + b]) * (col[count - 1 - c]);
            Console.WriteLine("Ответ " + res);
            a++;
            b++;
            c++;
        }
    }
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Proizvedenije(array);