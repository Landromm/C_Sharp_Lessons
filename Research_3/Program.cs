using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Research_3
{
    class Program
    {

        public void Task_1() {

            String Vivod_info(int result_one, int result_two) {
                string str = "Остаток от деления на 3 = " + result_one +
                     "\nОстаток от деления на 7 = " + result_two +
                     "\nРезультат удовлетворяет условию!!!";
                return str;
            }

            try {

                int number_1, number_test_3 = 3, number_test_7 = 7;

                number_1 = Int32.Parse(
                    Interaction.InputBox(
                        "Введите любое целое число:",
                        "Проверка!"
                        )
                    );

                int result_one = number_1 % number_test_3;
                int result_two = number_1 % number_test_7;

                Console.WriteLine("Остаток от деления на 3 = " + result_one);
                Console.WriteLine("Остаток от деления на 7 = " + result_two);

                if (result_one == 0 && result_two == 0)
                {
                    MessageBox.Show(
                     Vivod_info(result_one, result_two),
                     "Результат",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation
                     );
                }
                else {
                    MessageBox.Show(
                     Vivod_info(result_one, result_two),
                     "Результат",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation
                     );
                }

            }
            catch {
                MessageBox.Show(
                    "Надо было ввести целое число!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }

        public void Task_2() {

            try
            {
                double number_1, number_2;

                number_1 = Double.Parse(
                    Interaction.InputBox(
                        "Введите первое число: ",
                        "Ввод числа №1")
                    );

                number_2 = Double.Parse(
                    Interaction.InputBox(
                        "Введите второе число: ",
                        "Ввод числа №2")
                    );
                Console.WriteLine("Вы ввели числа: \n" +
                                   "1-число = " + number_1 +
                                   "\n2-е число = " + number_2 +
                                   "\n-----------------------------");
                if (number_1 > number_2)
                {
                    MessageBox.Show(
                        "ПЕРВОЕ число больше второго!",
                        "Результат!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if (number_2 > number_1) {
                    MessageBox.Show(
                        "ВТОРОЕ число больше первого!!",
                        "Результат!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                } 
                else if (number_1 == number_2)
                {
                    MessageBox.Show(
                        "ПЕРВОЕ число = ВТОРОМУ числу!",
                        "Результат!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch {
                MessageBox.Show(
                    "Введите поочереди 2 числа.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        public void Task_3() {
            int number, summ = 0;

            try
            {
                do
                {
                    MessageBox.Show(
                    "Сумма введенных чисел = " + summ,
                    "Результат!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    number = Int32.Parse(
                    Interaction.InputBox(
                    "ВВедите любое целое число:",
                    "Воод числа")
                    );

                    summ += number;
                    Console.WriteLine(summ);

                } while (number != 0);

                MessageBox.Show(
                    "Программа завершенна. Всего доброго!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
            }
            catch {
                MessageBox.Show(
                    "Чтобы завершить работу введите '0' ",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                Task_3();
            }

            
        }

        public void Task_4() {

            int number;
            string day = "";

            try
            {
                number = Int32.Parse(
                Interaction.InputBox(
                    "Введите целое число от 1 до 7:")
                );

                switch (number)
                {
                    case 1:
                        day = "Понедельник";
                        break;
                    case 2:
                        day = "Вторник";
                        break;
                    case 3:
                        day = "Среда";
                        break;
                    case 4:
                        day = "Четверг";
                        break;
                    case 5:
                        day = "Пятница";
                        break;
                    case 6:
                        day = "Суббота";
                        break;
                    case 7:
                        day = "Воскресенье";
                        break;
                    default:
                        day = "Введено некоректное значение!\nВведите цифру от 1 до 7!";
                        break;
                }

                MessageBox.Show(
                    day,
                    "День Недели",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                if (!(number>=1 && number<=7)) 
                { Task_4(); }

            }
            catch {
                MessageBox.Show(
                    "Вы ввели некоректное значение!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

            };        
            }

        public void Task_6() {

            try {
                int number = Int32.Parse(
                    Interaction.InputBox(
                        "Введите любое целое число!",
                        "Ввод числа")
                    ); ;
                int sum_for = 0;

                for (int i = 1; i <= number; i++)
                {
                    sum_for += i * 2;
                }

                Console.WriteLine(sum_for);

                MessageBox.Show(
                    "Ответ: Сумма количетва введеных четных чисел = " + sum_for,
                    "ответ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                int summa = number * (number + 1);
                Console.WriteLine(summa);
            }
            catch {
                MessageBox.Show(
                    "Вы ввели некоректное значение!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }



        }

        public void Task_7() {
            try {
                int number = Int32.Parse(
                    Interaction.InputBox(
                        "Введите любое целое число:",
                        "Ввод числа"
                        )
                    );

                int summ_1 = 0, testSumm = 0;
                string str = "";

                for (int i = 1; i <= number; i++) {
                    summ_1 += (int)Math.Pow(i, 2);
                    Console.WriteLine("Промежуточный Результат 'FOR' = " + summ_1);
                }

                testSumm = (number * (number + 1) * (2 * number + 1)) / 6;
                Console.WriteLine("Результат 'FOR' = " + summ_1);
                Console.WriteLine("Проверочный результат = " + testSumm);

                MessageBox.Show(
                    "Результат вычислений суммы квадратов = " + summ_1,
                    "...Результат...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

            }
            catch {
                MessageBox.Show(
                    "Вы ввели некоректное значение!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        public void Task_8() {
            try {
                int number = Int32.Parse(
                    Interaction.InputBox(
                        "Введите любое целое число:",
                        "Ввод числа"
                        )
                    );

                int a = 0, b = 1, c = 0;

                Console.WriteLine("Промежуточный результат суммы Предидущих 2-ух чисел: №" + 0 + " = " + 1);

                for (int i = 0; i < number-1; i++) {
                    c = a + b;
                    a = b;
                    b = c;
                    
                    Console.WriteLine("Промежуточный результат суммы Предидущих 2-ух чисел: №" + (int)(i+1) + " = " + c);
                }
            }

            catch {
                MessageBox.Show(
                    "Вы ввели некоректное значение!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        public void Task_9() {

            int number1, number2;
            string str = "";

            try {
                number1 = Int32.Parse(
                    Interaction.InputBox(
                        "Введите наименьшее число: ",
                        "Ввод первого числа"
                        )
                    );

                number2 = Int32.Parse(
                    Interaction.InputBox(
                        "Введите наибольшее число: ",
                        "ввод второго числа"
                        )
                    );
                if (number1 < number2)
                {
                    for (; number1 <= number2; number1++)
                    {
                        Console.Write("| ");
                        Console.Write(number1 + "| ");
                        str += number1.ToString() + " |";
                    }
                }
                else {
                    MessageBox.Show(
                    "Вы ввели значение не по условию!!!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    goto Finish;
                }
                

                MessageBox.Show(
                    "Все целлые числа от 1-го введенного до 2-го\n" + "| " + str,
                    "Результат",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                Finish:
                Console.ReadLine();

            }
           
            catch
            {
               
                MessageBox.Show(
                    "Вы ввели некоректное значение!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

            
        }

        public void Task_10() {

            int number1 = 0, amount, index = 0, summ = 0;

            amount = Int32.Parse(
                Interaction.InputBox(
                    "Введите количество чисел для суммы: ",
                    "Ввод количества числе.!."
                    ));


            Console.WriteLine("_____________________________________\n");

            for (int i = 0; ;number1++, i++) {
                if ((number1%5 == 2) || (number1% 3 == 1)) {
                   
                    Console.WriteLine("Число №" + (index+1) + " = " + number1 + ". ");
                    index++;
                    summ += number1;
                }
                if (index == amount) break;  
            }

            Console.WriteLine("***************\n"+"Сумма чисел равна = " + summ);
            Console.WriteLine("\n_____________________________________\n");

        }

        static void Main(string[] args)
        {
            try
            {
                Program ob = new Program();
                int index = -1;

                while (index != 0)
                {
                    Console.WriteLine("Выберите пожалуйста функцию выполнения: \n" +
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
                        case 1: ob.Task_1(); break;
                        case 2: ob.Task_2(); break;
                        case 3: ob.Task_3(); break;
                        case 4: ob.Task_4(); break;
                        case 6: ob.Task_6(); break;
                        case 7: ob.Task_7(); break;
                        case 8: ob.Task_8(); break;
                        case 9: ob.Task_9(); break;
                        case 10: ob.Task_10(); break;

                        default: break;
                    }
                }
            }
            catch {
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
