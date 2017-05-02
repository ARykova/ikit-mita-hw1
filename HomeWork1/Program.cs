using System;
using Model;

namespace HomeWork1
{
    class Program
    {        
        static void Main(string[] args)
        {
            int age = 0, menu = -1;
            Console.WriteLine("Приветствуем Вас в зоомагазине виртуальных кошек. " +
                "Чтобы приобрести питомца введите возраст животного и нажмите Enter: ");
            do
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        throw new Exception("Введите, пожалуйста, число больше 0: ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " Попробуйте еще раз: ");
                }                
            }
            while (age == 0);
            var cat = new Cat(age);
            Console.WriteLine("Поздравляем! Вы стали счастливым обладателем виртуальной кошки. ");
            do
            {
                ShowMenu();
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());                    
                    if (menu < 0 || menu > 4) throw new Exception("Такого пункта меню не существует, попробуйте еще раз: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Clear();
                switch (menu)
                {
                    case 0:                        
                        break;

                    case 1:
                        if (!String.IsNullOrEmpty(cat.Name))
                        {
                            Console.WriteLine("У вашей кошки уже есть имя: " + cat.Name + 
                                ". Его нельзя поменять");
                        }
                        else
                        {
                            Console.WriteLine("Введите имя: ");
                            cat.Name = Console.ReadLine();
                            Console.WriteLine("Имя кошки успешно задано.");
                        }
                        menu = -1;
                        Console.Read();
                        break;

                    case 2:
                        cat.Feed();
                        Console.WriteLine("Кошка покормлена. Здоровье кошки увеличено.");
                        menu = -1;
                        Console.Read();
                        break;

                    case 3:
                        cat.Punish();
                        Console.WriteLine("Кошка наказана. Здоровье кошки уменьшено.");
                        menu = -1;
                        Console.Read();
                        break;

                    case 4:
                        Console.WriteLine("Цвет Вашей кошки - " + cat.Color);
                        menu = -1;
                        Console.Read();
                        break;
                }
            }
            while (menu <0 || menu >4);  
        }
        public static void ShowMenu()
        {
            Console.WriteLine("Вам доступны следующие функции:");
            Console.WriteLine("1. Дать кошке имя.");
            Console.WriteLine("2. Покормить кошку.");
            Console.WriteLine("3. Наказать кошку.");
            Console.WriteLine("4. Узнать окраску кошки.");

            Console.WriteLine("Для выбора пункта меню введите его номер: ");
            Console.WriteLine("Для выхода из программы нажмите 0.");
        }
    }
}
