using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart5_StaticMethod
{
    class Program
    {
        // Шаблон try{} catch{} для быстрого коппирования.
        public void TryCatch()
        {
            try
            {

            }
            catch
            {
                MessageBox.Show(
                           "Вы ввели несоответсвующие данные!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning
                           );
            }            
        }

        /* Напишите программу, в которой описан статический метод для вычслений двойного факториала
        * числа, переданнаго аргументом методу. По определению, двойной факториал числа 'n' n!!.
        */

        static int Factorial_Task1(int n)
        {
            if (n % 2 == 0)
            {
                if (n == 2)
                {
                    return 2;
                }
                else
                {
                    return n * Factorial_Task1(n - 2);
                }
            }
            else
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * Factorial_Task1(n - 2);
                }
            }
        }
        static void Task_1()
        {
            try
            {
                Console.WriteLine("\n********************************\n");
                Console.WriteLine("\tРЕШЕНИЕ ЗАДАЧИ №1\n");

                Console.WriteLine("Введите число для вычисления двойного факториала!\n\n");
                int number = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\t----------------------------------");
                Console.WriteLine("\tРЕЗУЛЬТАТ");
                Console.WriteLine("\t----------------------------------");
                for (int i = number; number > 0; number -= 2)
                {
                    Console.WriteLine("\t" + number + "! = " + Factorial_Task1(number));
                }
                Console.WriteLine("\t----------------------------------");

            }
            catch
            {
                MessageBox.Show(
                           "Вы ввели несоответсвующие данные!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning
                           );
            }
        }






        static void Main(string[] args)
        {
            try
            {
                Program ob = new Program();
                int index = -1;

                while (index != 0)
                {
                    Console.WriteLine("\n\n\n************ГЛАВНОЕ МЕНЮ********************");
                    Console.WriteLine("\nВыберите пожалуйста функцию выполнения: \n" +
                                        "1. Task_1(); \n" +
                                        "2. Task_2(); \n" +
                                        "3. Task_3(); \n" +
                                        "4. Task_4(); \n" +
                                        "6. Task_6(); \n" +
                                        "7. Task_7(); \n" +
                                        "8. Task_8(); \n" +
                                        "9. Task_9(); \n" +
                                        "10. Task_10(); \n" +
                                        "0. Выход; \n \n" +
                                        "Нажмите соответсвующую цифру...");
                    index = Int32.Parse(Console.ReadLine());

                    switch (index)
                    {
                        case 1: Program.Task_1(); break;
                        //case 2: ob.Task_2(); break;
                        //case 3: ob.Task_3(); break;
                        //case 4: ob.Task_4(); break;
                        //case 5: ob.Task_5(); break;
                        //case 6: ob.Task_6(); break;
                        //case 7: ob.Task_7(); break;
                        //case 8: ob.Task_8(); break;
                        //case 9: ob.Task_9(); break;
                        //case 10: ob.Task_10(); break;

                        default: break;
                    }
                }
            }
            catch
            {
                MessageBox.Show(
                "Возникла непредвиденная ошибка!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }

        }
    }
}
