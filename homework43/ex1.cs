using System;
using System.Threading;

class Program
{
    const int TimeFactor = 100;

    static void Main(string[] args)
    {
        Thread morningRoutine = new Thread(VasyaMorningRoutine);
        morningRoutine.Start();
    }

    static void VasyaMorningRoutine()
    {
        int totalTime = 0;

        totalTime += LieInBed();
        totalTime += BoilKettle();
        totalTime += HeatDinner();
        totalTime += FillBath();
        totalTime += TakeBath();
        totalTime += Breakfast();
        totalTime += GetDressed();
        totalTime += CommuteToWork();

        Console.WriteLine($"\nОбщее затраченное время: {totalTime} минут.");
    }

    static int LieInBed()
    {
        int timeSpent = 15;
        Console.WriteLine("Вася проснулся и лежит в кровати...");
        Thread.Sleep(timeSpent * TimeFactor);
        Console.WriteLine($"Время в кровати: {timeSpent} минут.");
        return timeSpent;
    }

    static int BoilKettle()
    {
        int timeSpent = 5;
        Console.WriteLine("Вася ставит чайник...");
        Thread.Sleep(timeSpent * TimeFactor);
        Console.WriteLine($"Чайник закипел за {timeSpent} минут.");
        return timeSpent;
    }

    static int HeatDinner()
    {
        int timeSpent = 5;
        Console.WriteLine("Вася подогревает вчерашний ужин...");
        Thread.Sleep(timeSpent * TimeFactor);
        Console.WriteLine($"Ужин подогрет за {timeSpent} минут.");
        return timeSpent;
    }

    static int FillBath()
    {
        int timeSpent = 10;
        Console.WriteLine("Вася набирает ванну...");
        Thread.Sleep(timeSpent * TimeFactor);
        Console.WriteLine($"Ванна наполнена за {timeSpent} минут.");
        return timeSpent;
    }

    static int TakeBath()
    {
        int timeSpent = 15;
        Console.WriteLine("Вася принимает ванну...");
        Thread.Sleep(timeSpent * TimeFactor);
        Console.WriteLine($"Вася принял ванну за {timeSpent} минут.");
        return timeSpent;
    }

    static int Breakfast()
    {
        int timeSpent = 10;
        Console.WriteLine("Вася завтракает...");
        Thread.Sleep(timeSpent * TimeFactor);
        Console.WriteLine($"Завтрак занял {timeSpent} минут.");
        return timeSpent;
    }

    static int GetDressed()
    {
        int timeSpent = 5;
        Console.WriteLine("Вася одевается...");
        Thread.Sleep(timeSpent * TimeFactor);
        Console.WriteLine($"Время на одевание: {timeSpent} минут.");
        return timeSpent;
    }

    static int CommuteToWork()
    {
        int timeSpent = 55;
        Console.WriteLine("Вася едет на работу...");
        Thread.Sleep(timeSpent * TimeFactor);
        Console.WriteLine($"Время в пути до работы: {timeSpent} минут.");
        return timeSpent;
    }
}
