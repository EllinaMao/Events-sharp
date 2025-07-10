namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bag = new Schoolbag("Red", "Nike", "Nylon", 1.2, 10);

            bag.ItemAdded += (sender, item) =>
            {
                Console.WriteLine($"Добавлен предмет: {item.Name}, объем: {item.Volume}");
            };

            bag.AddItem(new Item("Книга", 2));
            bag.AddItem(new Item("Тетрадь", 1));
            bag.AddItem(new Item("Носок", 30));
            Console.WriteLine("Нажмите любую кнопку дя выхода");
            Console.ReadKey();
        }
    }
}
