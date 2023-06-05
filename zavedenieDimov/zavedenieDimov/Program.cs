using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavedenieDimov
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Добре дошли в нашия ресторант!");

            // Въвеждане на брой гости и маса
            Console.Write("Моля, въведете брой гости: ");
            int hora = int.Parse(Console.ReadLine());
            Console.Write("Моля, изберете тип на масата (пушачи/непушачи): ");
            string masa = Console.ReadLine();

            double obshtacena = 0;

            for (int i = 1; i <= hora; i++)
            {
                Console.WriteLine("Поръчка за човек №" + i + ":");

                // Категория "Салати"
                Console.WriteLine("Моля изберете салата:");
                Console.WriteLine("1. Шопска");
                Console.WriteLine("2. Млечна салата");
                Console.WriteLine("3. Туршия");
                Console.Write("Твоя избор е номер: ");
                int salata = int.Parse(Console.ReadLine());

                // Категория "Основни ястия"
                Console.WriteLine("Моля изберете основно ястие:");
                Console.WriteLine("1. Кебапче");
                Console.WriteLine("2. Пържен картоф");
                Console.WriteLine("3. Телешко");
                Console.Write("Твоя избор е номер: ");
                int osnovno = int.Parse(Console.ReadLine());

                // Категория "Десерти"
                Console.WriteLine("Моля изберете десерт:");
                Console.WriteLine("1. Торта");
                Console.WriteLine("2. Сладолед");
                Console.WriteLine("3. Крем");
                Console.Write("Твоя избор е номер: ");
                int dessert = int.Parse(Console.ReadLine());

                // Категория "Напитки"
                Console.WriteLine("Моля изберете напитка:");
                Console.WriteLine("1. Алкохол");
                Console.WriteLine("2. Безалкохолно");
                Console.WriteLine("3. Топли напитки");
                Console.Write("Твоя избор е номер: ");
                int pitieizbirane = int.Parse(Console.ReadLine());
                string pitieneshto = "";

                if (pitieizbirane == 1)
                {
                    Console.WriteLine("Моля изберете алкохол:");
                    Console.WriteLine("1. Ракия");
                    Console.WriteLine("2. Уиски");
                    Console.WriteLine("3. Водка");
                    Console.Write("Твоя избор е номер: ");
                    int alkoholizbirane = int.Parse(Console.ReadLine());

                    if (alkoholizbirane == 1)
                    {
                        pitieneshto = "Ракия";
                    }
                    if (alkoholizbirane == 2)
                    {
                        pitieneshto = "Уиски";
                    }
                    if (alkoholizbirane == 3)
                    {
                        pitieneshto = "Водка";
                    }
                }

                if (pitieizbirane == 2)
                {
                    Console.WriteLine("Моля изберете безалкохолна напитка:");
                    Console.WriteLine("1. Сок");
                    Console.WriteLine("2. Кола");
                    Console.WriteLine("3. Вода");
                    Console.Write("Твоя избор е номер: ");
                    int bezalkohol = int.Parse(Console.ReadLine());
                    if (bezalkohol == 1)
                    {
                        pitieneshto = "Сок";
                    }
                    if (bezalkohol == 2)
                    {
                        pitieneshto = "Кола";
                    }
                    if (bezalkohol == 3)
                    {
                        pitieneshto = "Вода";
                    }
                }

                if (pitieizbirane == 3)
                {
                    Console.WriteLine("Моля изберете топла напитка:");
                    Console.WriteLine("1. Горещ шоколад");
                    Console.WriteLine("2. Чай");
                    Console.WriteLine("3. Греяна ракия");
                    Console.Write("Твоя избор е номер: ");
                    int topli = int.Parse(Console.ReadLine());
                    if (topli == 1)
                    {
                        pitieneshto = "Горещ шоколад";
                    }
                    if (topli == 2)
                    {
                        pitieneshto = "Чай";
                    }
                    if (topli == 3)
                    {
                        pitieneshto = "Греяна ракия";
                    }

                }

                // Сумиране на поръчката

                if (salata == 1)
                {
                    obshtacena += 5.50;
                }
                if (salata == 2)
                {
                    obshtacena += 6.00;
                }
                if (salata == 3)
                {
                    obshtacena += 4.00;
                }

                if (osnovno == 1)
                {
                    obshtacena += 2.00;
                }
                if (osnovno == 2)
                {
                    obshtacena += 4.00;
                }
                if (osnovno == 3)
                {
                    obshtacena += 12.00;
                }

                if (dessert == 1)
                {
                    obshtacena += 4.50;
                }
                if (dessert == 2)
                {
                    obshtacena += 3.50;
                }
                if (dessert == 3)
                {
                    obshtacena += 2.00;
                }

                if (pitieizbirane == 1)
                {
                    if (pitieneshto == "Ракия")
                    {
                        obshtacena += 6.00;
                    }
                    if (pitieneshto == "Уиски")
                    {
                        obshtacena += 8.00;
                    }
                    if (pitieneshto == "Водка")
                    {
                        obshtacena += 7.00;
                    }
                }
                if (pitieizbirane == 2)
                {
                    if (pitieneshto == "Сок")
                    {
                        obshtacena += 2.50;
                    }
                    if (pitieneshto == "Кола")
                    {
                        obshtacena += 3.00;
                    }
                    if (pitieneshto == "Вода")
                    {
                        obshtacena += 2.00;
                    }
                }
                if (pitieizbirane == 3)
                {
                    if (pitieneshto == "Горещ шоколад")
                    {
                        obshtacena += 3.50;
                    }
                    if (pitieneshto == "Чай")
                    {
                        obshtacena += 1.50;
                    }
                    if (pitieneshto == "Греяна ракия")
                    {
                        obshtacena += 5.00;
                    }
                }
            }


            // Плащане на поръчката

            if (obshtacena > 100)
            {
                Console.WriteLine($"Цената на поръчката ви е {obshtacena}, искате ли да откажете нещо?");
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Не");
                Console.WriteLine("Твоя избор е номер: ");
                int otkazvane = int.Parse(Console.ReadLine());
                if (otkazvane == 1)
                {
                    Console.WriteLine("Какво искате да откажете?");
                    string otkazvane2 = Console.ReadLine();
                    if (otkazvane2 == "Шопска")
                    {
                        obshtacena -= 5.50;
                    }
                    if (otkazvane2 == "Млечна салата")
                    {
                        obshtacena -= 6.00;
                    }
                    if (otkazvane2 == "Туршия")
                    {
                        obshtacena -= 4.00;
                    }
                    if (otkazvane2 == "Кебапче")
                    {
                        obshtacena -= 2.00;
                    }
                    if (otkazvane2 == "Пържен картоф")
                    {
                        obshtacena -= 4.00;
                    }
                    if (otkazvane2 == "Телешко")
                    {
                        obshtacena -= 12.00;
                    }
                    if (otkazvane2 == "Торта")
                    {
                        obshtacena -= 4.50;
                    }
                    if (otkazvane2 == "Сладолед")
                    {
                        obshtacena -= 3.50;
                    }
                    if (otkazvane2 == "Крем")
                    {
                        obshtacena -= 2.00;
                    }
                    if (otkazvane2 == "Ракия")
                    {
                        obshtacena -= 6.00;
                    }
                    if (otkazvane2 == "Уиски")
                    {
                        obshtacena -= 8.00;
                    }
                    if (otkazvane2 == "Водка")
                    {
                        obshtacena -= 7.00;
                    }
                    if (otkazvane2 == "Сок")
                    {
                        obshtacena -= 2.50;
                    }
                    if (otkazvane2 == "Кола")
                    {
                        obshtacena -= 3.00;
                    }
                    if (otkazvane2 == "Вода")
                    {
                        obshtacena -= 2.00;
                    }
                    if (otkazvane2 == "Горещ шоколад")
                    {
                        obshtacena -= 3.50;
                    }
                    if (otkazvane2 == "Чай")
                    {
                        obshtacena -= 1.50;
                    }
                    if (otkazvane2 == "Греяна ракия")
                    {
                        obshtacena -= 5.00;
                    }
                    if (otkazvane2 == "Торта")
                    {
                        obshtacena -= 4.50;
                    }
                    if (otkazvane2 == "Сладолед")
                    {
                        obshtacena -= 3.50;
                    }
                    if (otkazvane2 == "Крем")
                    {
                        obshtacena -= 2.00;
                    }
                }
                if (otkazvane == 2)
                {
                    Console.WriteLine("Добре, няма да отказваме нищо.");
                }
            }
            Console.WriteLine("Общата сума за плащане е: " + obshtacena + " лв.");
            Console.WriteLine("Моля изберете начин на плащане:");
            Console.WriteLine("1. Кеш");
            Console.WriteLine("2. Карта");
            Console.Write("Твоя избор е номер: ");
            int plashtane = int.Parse(Console.ReadLine());
            if (plashtane == 1)
            {
                Console.WriteLine("Плащането ще бъде извършено в брой.");
                Console.WriteLine("Ще оставите ли бакшиш?");
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Не");
                Console.Write("Твоя избор е номер: ");
                int bakshish = int.Parse(Console.ReadLine());
                if (bakshish == 1)
                {
                    Console.WriteLine("Колко ще оставиш?");
                    double bakshish1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Благодарим Ви за бакшиша!");
                }
                if (bakshish == 2)
                {
                    Console.WriteLine("Благодарим Ви, че посетихте нашия ресторант! Желаем Ви приятнен ден!");
                }
            }
            if (plashtane == 2)
            {
                obshtacena += 0.05;
                Console.WriteLine("Моля поставете картата си в устройството за плащане.");
                Console.WriteLine($"Новата сума за плащане е {obshtacena}, понеже имаме такса за плащане с карта.");
            }
        }
    }
}
