void FillArray(int[] collection)   
{                                    
                                    
   
    int length = collection.Length;  
    int index = 0;                      
    while (index < length)           
    {
        collection[index] = new Random().Next(100, 999);
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
        if(col[position] % 2 == 0) 
        {
            temp = count + 1;
            count = temp;
        }       
        position++;
    }
    Console.WriteLine("Количество четных чисел " + count);
    Console.WriteLine();
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Count(array);
