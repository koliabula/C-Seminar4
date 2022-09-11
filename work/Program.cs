
Console.Clear();
int i = 0;
int n = 0;
Console.WriteLine("Введите номер задачи:");
        
while (i == 0){
    Console.WriteLine("1 Программа принимает на вход А и выводит сумму от 1 до А: ");
    Console.WriteLine("2 Программа принимает на вход число и выводит колличество цифр в числе: ");
    Console.WriteLine("3 Программа принимает на вход число N и выводит произведение от 1 до N:");
    Console.WriteLine("4 Программа выводит массив из 0 и 1   -   8 элементов");
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0 & n < 5){
        break;
    }
    else {
        Console.WriteLine("Введите номер задачи, которую хотите решить:");
        

    }
}

if (n == 1){    //Программа принимает на вход А и выводит сумму от 1 до А  
    
    int Sum (int number){
        int summa = 0;
        for(int i = 0; i <= number; i++){
            summa += i;
        }
        return summa;
    }
                
    while(i == 0){   
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Сумма от 1 до {a} = {Sum(a)}");


        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}

else if (n == 2){    //Программа принимает на вход число и выводит колличество цифр в числе.

    int CountNumber (int n){
        int i = 0;
        for (i = 0; n != 0; i++)
        {
            n /= 10;
        }
        return i;
    }
    

    while(i == 0){

        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"В числе {number} - {CountNumber(number)} цифр");
        
        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}

else if(n == 3){//Программа принимает на вход число N и выводит произведение от 1 до N.
    
    int MultiplyNumber (int n){
        int multiply = 1;
        for (int i = 1; i <= n; i++)
        {
            multiply *= i;
        }
        return multiply;
    } 

    while(i == 0){

        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Произведение чисел от 1 до {number} = {MultiplyNumber(number)}");
        
        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}

else if(n == 4){

    void RandomArray(){
        int[] array = new int [8];
        for (int j = 0; j < array.Length; j++)
        {
            array[j] = new Random().Next(0,2);
            Console.Write($"{array[j]}; ");
        }
    }

    while(i == 0){

        RandomArray();

        Console.WriteLine();
        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}