using System;

namespace LabSix_
{
    class Menu : TuskTwo
    {
        public int MainMenu()
        {
            uint choice = 0;
            bool can = false;
            Console.WriteLine("\t\t\tКОНСОЛЬНОЕ ПРИЛОЖЕНИЕ ДЛЯ РАБОТЫ С МАССИВАМИ СТРОК");
            try
            {
                Console.WriteLine("\nВыберите индекс действия основного меню\n1.  Заполнить символами строку;" +
                "\n2.  Преобразовать строку в массив строк;" +
                "\n3.  Вывод массива строк;" +
                "\n4.  Перевернуть каждую четную строку;" +
                "\n5.  Выход.");
                choice = uint.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InputArrayStr();
                        break;
                    case 2:
                        ToArray();
                        break;
                    case 3:
                        Cout();
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        can = true;
                        break;
                    default:
                        Console.WriteLine("\nНет действия под данным индексом, повторите ввод...\n");
                        break;
                }
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (OverflowException oex)
            {
                Console.WriteLine(oex.Message);
            }

            if (can)
                return 0;
            return MainMenu();
        }
    }
}
