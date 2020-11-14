using System;

namespace LabSix_
{
    class Menu : TuskTwo
    {
        public int MainMenu()
        {
            
            uint choice = 0;
            bool can = false;
            Console.WriteLine("\n\t\t\tКОНСОЛЬНОЕ ПРИЛОЖЕНИЕ ДЛЯ РАБОТЫ С МАССИВАМИ СТРОК");
            try
            {
                Console.WriteLine("\nВыберите индекс действия основного меню" +
                "\n1.  Преобразовать строку по-умолчанию в массив строк;" +
                "\n2.  Заполнить строку самостоятельно и преобразовать в массив строк;" +
                "\n3.  Вывод массива строк;" +
                "\n4.  Перевернуть каждую четную строку;" +
                "\n5.  Выход.");
                choice = uint.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ConvertStrInArray(ref ifMenuChoiceOne);
                        break;
                    case 2:
                        InputStr();
                        break;
                    case 3:
                        Cout(arrayStr);
                        break;
                    case 4:
                        ReverseStrInArray();
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
