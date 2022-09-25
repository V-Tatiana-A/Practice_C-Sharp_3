// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using static System.Console;

Clear();
WriteLine("Задача 19");
WriteLine("Введите пятизначное число");
int num1=Math.Abs(Convert.ToInt32(ReadLine()));
if ((num1>-10000 && num1<10000) || num1>99999 || num1<-99999) WriteLine("По условию число должно быть пятизначным");
else {
    if (num1/10000==num1%10 && (num1/1000)%10==(num1/10)%10) {
        WriteLine("Это полиндром");
    }
    else {
        WriteLine("Это не полиндром");
    }
}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

WriteLine();
WriteLine("Задача 21");
WriteLine("Введите координаты точки A (x, y и z)");
double xa=Convert.ToDouble(ReadLine()!);
double ya=Convert.ToDouble(ReadLine()!);
double za=Convert.ToDouble(ReadLine()!);
WriteLine("Введите координаты точки B (x, y и z)");
double xb=Convert.ToDouble(ReadLine()!);
double yb=Convert.ToDouble(ReadLine()!);
double zb=Convert.ToDouble(ReadLine()!);
double d = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));
WriteLine("Расстояние между точками A и B составляет:");
WriteLine($"{d:f2}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

WriteLine();
WriteLine("Задача 23");
WriteLine("Введите число");
int numb=Convert.ToInt32(ReadLine()!);
if (numb==0) WriteLine("1, 0");
if (numb>0) {
    int i = 1;
    while (i<=numb) {
        Write($"{Math.Pow(i,3)} ");
        i+=1;
    }
}
if (numb<0) {
    int j = 1;
    while (j>=numb) {
        Write($"{Math.Pow(j,3)} ");
        j-=1;
    }
}