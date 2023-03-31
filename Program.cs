
//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длинна которых меньше либо ровна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//только массивами. Пример: ["hello","2","world",":-)"]->["2","6-)"] 
//                          ["1234","1567","computer science"]->
//                          ["-2"] ["Russia","Denmark","Kazan"]
string[] ResAr = { "hello","2","world",":-)","Wednesday","Thirsday","Friday","Saturday","1234","1567","computer science","-2","Russia","Denmark","Kazan"};

string[] GetArray()
{
    string[] ResAr1 = new string[ResAr.Length];

    for (int i = 0; i < ResAr.Length; i++)
    {
        if (ResAr[i].Length > 3) 
        {
            ResAr1[i] = ResAr[i];
        }  
        
        else if (ResAr[i].Length <= 3) 
        {
            ResAr1[i] = ResAr[i+1];
            //i++;
        }           
    } return ResAr1;
    }

 void PrintArray(string[] inarray) //печать массива
{
    for (int i = 0; i < inarray.Length; i++)
    {
        Console.Write($" {inarray[i]}");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Clear();
PrintArray(ResAr);
string[] array = GetArray();
PrintArray(array);