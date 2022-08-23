// ; *Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// ; ;  значения которых лежат в отрезке [10,99].
void FillArray(int[] collection)   
{                                    
                                    
   
    int length = collection.Length;  
    int index = 0;                      
    while (index < length)           
    {
        collection[index] = new Random().Next(1, 1444);
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

void PrintArray2(int[] col)
{
    int count = col.Length; 
    int position = 0;
    int a = 0;
    while(position < count)
    {
        if(col[position] < 100)
        {
            if(col[position] > 9)
            {
                Console.Write(col[position] + " ");
                a++;            
            }
        }        
        position++;
    }
    Console.WriteLine();
    Console.WriteLine("Количество искомых чисел " + a);
}

int[] array = new int [123];

FillArray(array);
PrintArray(array);
PrintArray2(array);