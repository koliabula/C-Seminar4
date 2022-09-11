/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/



Console.Clear();
int i = 0;
int n = 0;
Console.WriteLine("Введите номер задачи:");
        
while (i == 0){
    Console.WriteLine("1 Программа принимает на вход два числа (A и B)" +
                        " и возводит число A в натуральную степень B ");
    Console.WriteLine("2 Программа принимает на вход число и выдаёт сумму цифр в числе ");
    Console.WriteLine("3 Программа, которая задаёт массив из 8 элементов и выводит их на экран.");

    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0 & n < 4){
        break;
    }
    else {
        Console.WriteLine("Введите номер задачи, которую хотите решить:");
        

    }
}

if (n == 1){ //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    
    int MyPow (int n, int st){
        int mypow = 1;
        for(int i = 0; i < st; i++){
            mypow *= n;
        }
        return mypow;
    }
                
    while(i == 0){   
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень числа: ");
        int pow = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{number} в степени {pow} = {MyPow(number, pow)}");

        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}

else if (n == 2){    //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    int SumNumber (int n){
        
        int sum = 0;
        for (int i = 0; n != 0; i++)
        {
            sum += n%10;
            n /= 10;
        }
        return sum;
    }
    

    while(i == 0){

        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Сумма цифр числа {number} равна {SumNumber(number)}");
        
        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}

else if(n == 3){ //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
                //пользователь вводит размерность 
    
    void RandomArray(int N){
        int[] array = new int [N];
        for (int j = 0; j < N; j++)
        {
            array[j] = new Random().Next(0,1000);
            Console.Write($"{array[j]}, ");
        }
    }


    while(i == 0){

        Console.WriteLine("Введите размерность массива");
        int N = Convert.ToInt32(Console.ReadLine());
        
        RandomArray(N);
        
        Console.WriteLine();
        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}