using AnononimMetods;
using System.Globalization;
namespace Task3
{
    internal class Program
    {

        /*
Задание 3
Создайте лямбда-выражение для подсчёта количества чисел в массиве, кратных семи. Напишите код для
тестирования работы лямбды.
*/
        static void Main(string[] args)
        {
            var anon = new Anononim();

            {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                int x = random.Next(-15, 20);
                numbers.Add(x);
            }

            int count = anon.CountNumbers(numbers, anon.Divisible(7));
            Console.WriteLine("Количество чисел делимых на 7: {0}", count);

            count = anon.CountNumbers(numbers, anon.Divisible(2));
            Console.WriteLine("Количество положительных чисел: {0}", count);


            List<int> negatives = anon.GetNewList(numbers);
            Console.WriteLine("Отрицательные числа: {0}", string.Join(" ", negatives));

            Console.WriteLine("Нажмите любую кнопку для продолжения");
            Console.ReadKey();
            Console.Clear();
            }

            string txt = "Создайте лямбда-выражение для подсчёта количества чисел в массиве, кратных семи. Напишите код для\r\nтестирования работы лямбды";

            string word = "семи";
            Console.WriteLine("Введите слово которое хотите найти: ");
            string? word2 = Console.ReadLine();
            var IsInTxt = anon.IsWord(txt, word2);
            Console.WriteLine(IsInTxt? "Слово найдено": "Слово не найдено");



            Console.WriteLine("Нажмите любую кнопку дя выхода");
            Console.ReadKey();

        }

    }
}
