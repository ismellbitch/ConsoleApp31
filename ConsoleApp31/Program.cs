internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите дату в формате dd/mm/yyyy: ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(date.ToString("d dddd MMMM yyyy"));

        Console.Write("Введите время старта: ");
        TimeSpan Start = TimeSpan.Parse(Console.ReadLine());
        Console.Write("Введите время старта: ");
        TimeSpan Finish = TimeSpan.Parse(Console.ReadLine());

        double Distance = 3000;
        double RunningTime = Finish.TotalSeconds - Start.TotalSeconds;
        double AverageSpeed = Distance / RunningTime;
        Console.WriteLine($"Время забега: {RunningTime} секунд, Средняя скорость: {AverageSpeed} м/с");
    }
}