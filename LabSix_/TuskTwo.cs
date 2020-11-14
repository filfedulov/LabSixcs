using System;
using System.Text;

namespace LabSix_
{
    class TuskTwo
    {
        protected string[] arrayStr;
        protected StringBuilder forArrayStr,
            ifMenuChoiceOne;
        
        public TuskTwo()
        {
            arrayStr = new string[0];
            forArrayStr = new StringBuilder("Лаб.  Работа!   №6?");
            ifMenuChoiceOne = forArrayStr;
        }

        protected string[] InputStr()
        {
            Console.WriteLine("\nЗаполните строку...");
            do
            {
                try
                {
                    forArrayStr = new StringBuilder(Console.ReadLine());
                    break;
                }
                catch(OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }

            } while (true);
            return ConvertStrInArray(ref forArrayStr);
        }

        protected string[] ConvertStrInArray(ref StringBuilder strBuilder, bool reverseYes = false)
        {
            if (reverseYes)
            {
                arrayStr = SplitForArray_(ref strBuilder);
                Cout(arrayStr);
                return arrayStr;
            }
            arrayStr = AddingSlachNAndSplit_(ref strBuilder);
            Cout(arrayStr);
            return arrayStr;
        }

        private string[] AddingSlachNAndSplit_(ref StringBuilder strBuilder)
        {
            for (UInt16 i = 0; i < strBuilder.Length; i++)
            {
                if (strBuilder[i] == '.' || strBuilder[i] == '!' || strBuilder[i] == '?')
                {
                    strBuilder.Length = strBuilder.Length + 1;
                    strBuilder[i + 1] = '\n';
                }
            }
            return SplitForArray_(ref strBuilder);
        }

        private string[] SplitForArray_(ref StringBuilder strBuilder)
        {
            string[] arrayStr_ = strBuilder.ToString().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            return arrayStr_;
        }

        protected void Cout(in string[] forCout = null)
        {
            if (forCout == null || forCout.Length == 0)
            {
                Console.WriteLine("\nМассив пуст.\n");
                return;
            }
            Console.Write("\n");
            foreach (string s in forCout)
            {
                Console.WriteLine(s);
            }
            Console.Write("\n");
        }

        protected string[] ReverseStrInArray()
        {
            StringBuilder tmp = new StringBuilder();
            string[] forReverse = arrayStr;
            char[] rev;
            for (UInt16 i = 0; i < forReverse.Length; i++)
            {
                if (i % 2 == 0)
                {
                    rev = forReverse[i].ToCharArray();
                    Array.Reverse(rev);
                    tmp.Append(rev);
                    tmp.Append("\n");
                }
                else
                {
                    rev = forReverse[i].ToCharArray();
                    tmp.Append(forReverse[i]);
                    tmp.Append("\n");
                }
            }
            forArrayStr = tmp;
            return ConvertStrInArray(ref forArrayStr, reverseYes: true);
        }
    }
}
