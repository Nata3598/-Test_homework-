int NewArrayLength(string[] arrayone)
{
    int count = 0;
    for (int i = 0; i < arrayone.Length; i++)
    {
        if(arrayone[i].Length <= 3)
            count++;
    }
    return count;
}

void ArrayCreation(string[] arrayone, string[] arraytwo)
{
    int count = 0;
    for (int i = 0; i < arrayone.Length; i++)
    {
        if(arrayone[i].Length <= 3)
        {
            arraytwo[count] = arrayone[i];
            count++;
        }
    }
}

void PrintArray(string[] arraytwo)
{
    Console.Write("|");
    for (int i = 0; i < arraytwo.Length; i++)
    {   
        if (i != 0)
            Console.Write("|");  

        Console.Write($" {arraytwo[i]} ");
    }  
    Console.Write("|");    
    
}

string[] arrayone = new string[9] {"hello", "2", "world", ":)", ":-(", "-8", "hi", "10", "8888"};

int len = NewArrayLength(arrayone);
string[] arraytwo = new string[len];

ArrayCreation(arrayone, arraytwo);
PrintArray(arraytwo);