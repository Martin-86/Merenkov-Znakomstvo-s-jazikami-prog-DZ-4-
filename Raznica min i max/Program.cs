// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] collection)   
{                                    
                                    
   
    int length = collection.Length;  
    int index = 0;                      
    while (index < length)           
    {
        collection[index] = new Random().Next(1, 10);
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

int resmin(int[] col)
{
    int position = 0;
    int min = col[position];
    int temp = 0;
    while(position < col.Length)
    {   
        if(col[position] < min) 
        {   
            temp = col[position];
            min = temp;
            position++; 
        }
        position++;     
    }
    return min;
    
    
}

int resmax(int[] col)
{ 
    int position = 0;
    int max = col[position];
    int temp = 0;
    while(position < col.Length)
    {   
        if(col[position] > max) 
        {   
            temp = col[position];
            max = temp;
            position++; 
        }
        position++;     
    }
    return max;
    
}


int[] array = new int [9];

FillArray(array);
PrintArray(array);

int min = resmin(array);
Console.WriteLine("min = " + min);
Console.WriteLine();

int max = resmax(array);
Console.WriteLine("max = " + max);
Console.WriteLine();

Console.Write("Разница между max и min = ");
Console.Write(max - min);