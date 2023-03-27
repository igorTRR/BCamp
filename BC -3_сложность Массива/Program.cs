// создаем массив - заполняее его пользователь- на 5 эл
        
Console.Clear();
Console.WriteLine("Введите числа: ");

int[] array = new int[5];
    for (int i = 0; i < 5; i++)
     array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("[" + String.Join(", ", array) + "]");
    

