using System;

namespace LabSix_
{
    class TuskTwo
    {
        private string[] arrayStr;
        private string forArrayStr;
        

        protected string InputArrayStr()
        {
            Console.WriteLine("\nЗаполните строку...");
            forArrayStr = Console.ReadLine();
            return forArrayStr;
        }

        protected string[] ToArray()
        {
            if (arrayStr.Length == 0)
            {
                Console.WriteLine("\nСначала заполните строку!");
                return null;
            }
                
            Console.WriteLine("\nСтрока преобразованная в массив строк");
            arrayStr = InputArrayStr().Split(new string[] { " ", "   ", "   ", ",", ":", ";"}, StringSplitOptions.RemoveEmptyEntries);
            return arrayStr;
        }

        protected void Cout()
        {
            if (arrayStr.Length != 0)
            {
                for (UInt16 i = 0; i < arrayStr.Length; i++)
                {
                    Console.WriteLine($"{arrayStr[i]}!");
                }
                return;
            }
            Console.WriteLine("\nМассив пуст.");
        }
    }
}
