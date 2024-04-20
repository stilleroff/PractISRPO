using system;
namespace PractISRPO
{
    class programm
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введите первое число");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма чисел равна " +(x + y));
            Console.WriteLine("Произведение чисел равно " +(x * y));
            Console.WriteLine("Частное чисел равно "+(x/y));
        }
    }
}
