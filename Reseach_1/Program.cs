using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Reseach_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, reminder;

            // Считываем введенные число
            number = Int32.Parse(
                Interaction.InputBox(
                    "Введите целое число: ",
                    "Проверка")
                );

            //Вычисляем очтаток от деления на 3
            reminder = number % 3;
            string txt = "Вы ввели число, которое ";
            txt += (reminder == 0 ? "делится" : "не делится") + " на 3 !";
            MessageBox.Show(txt);
        }
    }
}
