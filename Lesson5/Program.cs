using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        public static bool Check(StringBuilder a, StringBuilder b)
        {
            return
        }

        static void Main(string[] args)
        {
            /*Выполнила Ярмолинская Анастасия
            Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            Например: badc являются перестановкой abcd.*/

            StringBuilder sA = new StringBuilder(Console.ReadLine());
            StringBuilder sB = new StringBuilder(Console.ReadLine());
            if ()
            bool trueF = true;
            while (sA.Length != 0 && trueF != false)
            {
                trueF = Check(sA, sB);
                sA.Remove(sA.Length - 1, 1);
            }
            
            
        }
    }
}
