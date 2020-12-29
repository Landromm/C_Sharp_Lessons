using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Research_2
{
    class Program
    {
        public void Task_2()
        {
            int number, reminder_5, reminder_7;

            number = Int32.Parse(
                Interaction.InputBox(
                    "Введите целое число:",
                    "Проверка")
                );

            reminder_5 = number % 5;
            reminder_7 = number % 7;

            Console.WriteLine("Остаток от деления на 5 =" + reminder_5);
            Console.WriteLine("Остаток от деления на 7 =" + reminder_7);

            string txt = "Ваше число ";
            txt += ((reminder_5 == 2) & (reminder_7 == 1) ? "соответсвует" : "не соответсвует") + " условию задачи!";

            MessageBox.Show(txt);
        }

        public void Task_3() {

            int number, reinder;

            number = Int32.Parse(
                Interaction.InputBox(
                    "Введите целое число от 0 до 10:",
                    "Проверка!"));
            reinder = number % 4;
            Console.WriteLine("Остаток от деления введенного числа: " + reinder);

            if (number > 10) { 
                if (reinder == 0) 
                {                    
                    MessageBox.Show("Ваше число полностью соответсвует условию задачи!");               
                } 
                else 
                { 
                    MessageBox.Show("Введите другое число!");
                }
            }
            else
            {
                MessageBox.Show("Введите число больше 10 !!!");
            }
        }

        public void Task_4() {
            int result = 0, number;
            while (result == 0) 
            {
                Console.WriteLine("Введите исло от 5 до 10 включительно");
                number = Int32.Parse(Console.ReadLine()); ;
                result = ((number > 5) && (number <= 10) ? 1 : 0);

                string txt = "Введеное число " + ((number > 5) && (number <= 10) ? "соответсвует условию " : "не соответсвует условию");
            }

            Console.WriteLine("Ваше введеное число соответсвует поставленной задачи !!!");

        }

        public void Task_5()
        {
            int number, kol_number;

            number = Int32.Parse(
                Interaction.InputBox(
                    "Введите любое 5-ти значное число: ",
                    "Проверка количества тысяч!"));

            kol_number = number / 1000 % 10;
            Console.WriteLine("Количество тысяч в числе = " + kol_number);

            string txt = "Количество тысяч: " + kol_number;

            MessageBox.Show(txt, "Тысячи");
        }

        static void Main(string[] args)
        {
            Program ob = new Program();
            int index = -1;

            while (index != 0)
            {
                Console.WriteLine("Выберите пожалуйста функцию выполнения: \n" +
                                    "1. Task_2(); \n" +
                                    "2. Task_3(); \n" +
                                    "3. Task_4(); \n" +
                                    "4. Task_5(); \n" +
                                    "0. Выход; \n \n" +
                                    "Нажмите соответсвующую цифру...");
                index = Int32.Parse(Console.ReadLine());

                switch (index)
                {
                    case 1: ob.Task_2(); break;
                    case 2: ob.Task_3(); break;
                    case 3: ob.Task_4(); break;
                    case 4: ob.Task_5(); break;

                    default: break;
                }

            }
        }

    }
}
