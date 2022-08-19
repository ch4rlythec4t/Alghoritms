while (true)
{
    Console.WriteLine("Введите размер массива");
    int sizeList = Convert.ToInt32(Console.ReadLine());
    int[] list = new int[sizeList];
    int low = 0;
    int high = sizeList;
    int mid = (low + high) / 2;
    int count =  1;

    for (int i = 0; i == sizeList; i++)
    {
        list[i] = 1;
    }

    Console.WriteLine($"Введите искомое значение от 0 до {sizeList}");
    int NumSearch = Convert.ToInt32(Console.ReadLine());

    if ((NumSearch < 0) ^ (NumSearch > sizeList))
    {
        Console.WriteLine("Введенное число не входит в указанный диапазон");
        break;

    }

    else
    {
       while (mid != NumSearch)
       {
       if (NumSearch > mid)
       {
        low = mid;  
        count++; 
        mid = (low + high) / 2;     
       }
       else
       {
        high = mid;
        count++;
        mid = (low + high) / 2;   
       }
       }
       Console.WriteLine($"Число найдено за {count} операций");
    }
}