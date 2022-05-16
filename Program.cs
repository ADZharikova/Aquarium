using System;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aquarium aquarium = new Aquarium();
            string putUser;
            Random random = new Random();
            int maxAge;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Аквариум");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("В аквариуме одномоментно может находится 10 рыб.\nКаждое действие увелиличивает возраст рыбы на 1.\n" +
                    "По истечении определённого возраста рыба умирает.");
                Console.ResetColor();

                aquarium.ShowInfo();

                Console.SetCursorPosition(0, 6);
                Console.WriteLine("1. Добавить рыбу\n2. Достать рыбу\n3. Просто так увеличить её возраст\n");
                Console.Write("Введите номер действия: ");
                putUser = Console.ReadLine();

                switch (putUser)
                {
                    case "1":
                        Console.Write("Введите имя: ");
                        putUser = Console.ReadLine().Replace(" ", "");
                        while (String.IsNullOrEmpty(putUser))
                        {
                            Console.Write("Вы ничего не ввели: ");
                            putUser = Console.ReadLine().Replace(" ", "");
                        }
                        maxAge = random.Next(8, 10);
                        aquarium.AddFish(putUser, 0, maxAge);
                        break;

                    case "2":
                        Console.Write("Введите имя: ");
                        putUser = Console.ReadLine().Replace(" ", "");
                        while (String.IsNullOrEmpty(putUser))
                        {
                            Console.Write("Вы ничего не ввели: ");
                            putUser = Console.ReadLine().Replace(" ", "");
                        }
                        aquarium.RemoveFish(putUser);
                        break;

                    case "3":
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Из-за вашей ошибки, все рыбы умрут быстрее.");
                        Console.ResetColor();
                        break;
                }

                aquarium.AddYaer();
                aquarium.CheckAge();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Для продолжения нажмите любую кнопку.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
