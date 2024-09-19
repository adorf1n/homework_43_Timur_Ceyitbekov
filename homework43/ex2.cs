using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    const int TimeFactor = 100;
    static async Task Main(string[] args)
    {
        Console.WriteLine("Начинаем утренний распорядок Васи...");

        var kettleTask = BoilKettle();
        var dinnerTask = HeatDinner();
        var bathTask = FillBath();

        await Task.WhenAll(kettleTask, dinnerTask, bathTask);

        await TakeBath();
        await Breakfast();
        await GetDressed();
        await CommuteToWork();

        Console.WriteLine("\nВася успел на работу!");
    }

    static async Task BoilKettle()
    {
        int timeSpent = 5;
        Console.WriteLine("Вася ставит чайник...");
        await Task.Delay(timeSpent * TimeFactor);
        Console.WriteLine($"Чайник закипел за {timeSpent} минут.");
    }

    static async Task HeatDinner()
    {
        int timeSpent = 5;
        Console.WriteLine("Вася подогревает вчерашний ужин...");
        await Task.Delay(timeSpent * TimeFactor);
        Console.WriteLine($"Ужин подогрет за {timeSpent} минут.");
    }

    static async Task FillBath()
    {
        int timeSpent = 10;
        Console.WriteLine("Вася набирает ванну...");
        await Task.Delay(timeSpent * TimeFactor);
        Console.WriteLine($"Ванна наполнена за {timeSpent} минут.");
    }

    static async Task TakeBath()
    {
        int timeSpent = 15;
        Console.WriteLine("Вася принимает ванну...");
        await Task.Delay(timeSpent * TimeFactor);
        Console.WriteLine($"Вася принял ванну за {timeSpent} минут.");
    }

    static async Task Breakfast()
    {
        int timeSpent = 10;
        Console.WriteLine("Вася завтракает...");
        await Task.Delay(timeSpent * TimeFactor);
        Console.WriteLine($"Завтрак занял {timeSpent} минут.");
    }

    static async Task GetDressed()
    {
        int timeSpent = 5;
        Console.WriteLine("Вася одевается...");
        await Task.Delay(timeSpent * TimeFactor);
        Console.WriteLine($"Время на одевание: {timeSpent} минут.");
    }

    static async Task CommuteToWork()
    {
        int timeSpent = 55;
        Console.WriteLine("Вася едет на работу...");
        await Task.Delay(timeSpent * TimeFactor);
        Console.WriteLine($"Время в пути до работы: {timeSpent} минут.");
    }
}
