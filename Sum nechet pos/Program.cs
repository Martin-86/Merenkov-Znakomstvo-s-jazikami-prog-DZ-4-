// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

void FillArray(int[] collection)   
{                                    
                                    
   
    int length = collection.Length;  
    int index = 0;                      
    while (index < length)           
    {
        collection[index] = new Random().Next(1, 9);
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

void Count(int[] col)
{
    int lg = col.Length; 
    int position = 0;
    int count = 0;
    int temp = 0;
    while(position < lg)
    {
        if(position % 2 != 0) 
        {
            temp = count + col[position];
            count = temp;
        }       
        position++;
    }
    Console.WriteLine("Сумма чисел на нечетных позициях " + count);
    Console.WriteLine();
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Count(array);