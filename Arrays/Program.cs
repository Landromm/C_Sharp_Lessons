using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart4_Arrays
{
    class Program
    {

        // dsiuhvfpsdfdsf
        //idofhvpsdfhv
        //oidfhvuisdhf[pd
        // Шаблон try{} catch{} для быстрого коппирования.
        public void TryCatch() 
        {
            try {
                            
            }
            catch {
                MessageBox.Show(
                           "Вы ввели несоответсвующие данные!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning
                           );
            }
        }

        /* 
         * ЗАДАЧА №1 
         * Напишите программу, в которой создается одномерный числовой массив и заполняется
         * числами, которые при делении на 5 дают в остатке 2 (числа 2, 7, 12, 17 и т.д.).
         * Размер массива вводиться пользователем. Предусмотреть обработку ошибки, связанной 
         * с вводом некорректного значения.
         */
        public void Task_1() {

            try {
                int size = Int32.Parse(
                    Interaction.InputBox(
                        "Введите любое число от 1 до 15: ",
                        "Ввод размерности массива"
                        ));

                // Проверка на ввод числа неудовлетворяющее условию.
                if (size > 15 || size < 1)
                {
                    MessageBox.Show(
                            "Вы ввели некорректное число.\n " +
                            "Пожалуйста повтрите.",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    Task_1();
                }
                int[] array = new int[size];
                Console.WriteLine(array.Length);

                for (int i=0; i < array.Length; i++)
                {
                    array[i] = i * 5 + 2;
                }

                int number = 1;

                Console.WriteLine("********************************\n");
                Console.WriteLine("\t РЕШЕНИЕ ЗАДАЧИ №1\n");
                foreach (int index in array) {
                    Console.WriteLine("Значение массива #{0} равно: \t{1}", number, index );
                    number++;
                }

                Console.WriteLine("\n********************************");

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

        /* 
         * ЗАДАЧА №2
         * Напишите программу, в которой создается массив из 11 целочисленных элемнтов. Массив
         * заполняется степенями двойки = 2^0=1, 2^1=2, 2^2=4 и так далее до 2^10=1024. При
         * заполнении массива учесть , что начальный элемент равен 1, а каждый следующий
         * больше предыдущего в 2 раза. Отобразить массив в консольном окне в прямом и обратном
         * порядке. Размер массива задается переменной.
         */
        public void Task_2() {
            try {
                int size = 11, number = 0;
                int[] array = new int[size];
                array[0] = 1;

                for (int i = 1; i < array.Length; i++)
                {                       
                    array[i] = (array[i-1]) * 2;
                    //Console.WriteLine("Данные при заполнении массива\n" + array[i]);                    
                }

                Console.WriteLine("********************************\n");
                Console.WriteLine("\t РЕШЕНИЕ ЗАДАЧИ №2\n");

                foreach (int index in array) 
                {
                    Console.WriteLine("{0}. \t2 в степени {1} равно: \t{2}.", number+1, number, index);
                    
                    number++;
                }

                Console.WriteLine("\n********************************");
            }
            catch {
                MessageBox.Show(
                       "Вы ввели несоответсвующие данные!",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                       );
            }
        }

        /* 
         * ЗАДАЧА №3
         * Напишите программу, в которой создается одномерный символьный массив из 10 элементов.
         * Массив заполняется буквавми "через одну", начиная с буквы 'а'. Отобразите массив в
         * консольном окне в прямом и обратном порядке. Размер массива задается переменной.
         */
        public void Task_3()
        {
            try
            {
                int size = 10, tmp, number = 1;
                char[] arrayChar = new char[size];
                char s = 'a';
                arrayChar[0] = s;

                for (int i = 1; i < arrayChar.Length; i++)
                {
                    tmp = (int)s + 2;
                    arrayChar[i] = (char)tmp;
                    s = (char)tmp;
                }

                Console.WriteLine("********************************\n");
                Console.WriteLine("\t РЕШЕНИЕ ЗАДАЧИ №3\n");

                foreach (char index in arrayChar)
                {
                    Console.WriteLine("Элемент массива \t№{0} равный: \t{1}", number, index);
                    number++;
                }

                Console.WriteLine("----------------------------------");

                for (int i = arrayChar.Length-1, y=0; i >= 0; i--)
                {
                    Console.WriteLine("Элемент массива \t№{0} равный: \t{1}", y, arrayChar[i]);
                    y++;
                }

                Console.WriteLine("\n********************************");
            }
            catch
            {
                MessageBox.Show(
                           "Пиздец все пропало!!!!!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning
                           );
            }
        }

        /* 
         * ЗАДАЧА №4
         * Напишите программу, в которой создается символьный массив из 19 элементов. Массив
         * заполнить большими (прописными) буквами английского алфавита. Буквы берутся подряд,
         * но только согласные (т.е. гласные буквы при присвоении нужно пропустить). Отобразите
         * содержимое созданного массива в консольном окне.
         */
        public void Task_4()
        {
            try
            {
                int size = 20, tmp, number = 1, indexArray = 0;
                char[] arrayChar = new char[size];
                char s = 'A';
                arrayChar[0] = s;

                for (int i = 0; i < 26; i++)
                {
                    if (s.Equals('A') || s.Equals('E') || s.Equals('Q') || s.Equals('Y') || s.Equals('I') || s.Equals('O'))
                    {
                        s++;
                    }
                    else {
                        arrayChar[indexArray] = s;
                        indexArray++;
                        s++;
                    }     
                }

                Console.WriteLine("********************************\n");
                Console.WriteLine("\t РЕШЕНИЕ ЗАДАЧИ №4\n");

                foreach (char index in arrayChar)
                {
                    Console.WriteLine("Элемент массива \t№{0} равный: \t{1}", number, index);
                    number++;
                }

                Console.WriteLine("\n********************************");
            }
            catch
            {
                MessageBox.Show(
                           "Пиздец все пропало!!!!!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning
                           );
            }
        }

        /* 
         * ЗАДАЧА №5
         * Напишите программу, в которой создается массив и заполняется случайными числами.
         * Массив отображается в консольном окне. В этом массиве необходимо определить элемент
         * с минимальным значением. В частности, программа должна вывести значение элемента
         * с минимальным значением и индекс этого элемента. Если элементов с минимальным значением
         * несколько, должны быть выведены индексы всех этих элементов.
         */
        public void Task_5()
        {
            try
            {
                int number, size, index = 0, lowElement, repeatLowElement;
                //int[] repeatIndex = new int[10];
                List<int> repeatIndex = new List<int>();
                
                Random rnd = new Random();


                size = Int32.Parse(
                        Interaction.InputBox(
                            "Введите размер массива от 2 до 100: ",
                            "Ввод размерности массива."
                            )
                    );

                int[] array = new int[size];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 10);
                }

                Console.Write("\tМассив: ");
                foreach (int element in array)
                {
                    Console.WriteLine(element);
                }

                Console.WriteLine("********************************\n");

                foreach (int element in array)
                {
                    Console.WriteLine("\t{0}.\tЗначение элемента массива № {1}:\t{2}", index+1, index, element);
                    index++;
                }

                Console.WriteLine("\n********************************");

                lowElement = 102;
                for (int i = 0; i < array.Length-1; i++)
                {
                     if (lowElement > array[i]) 
                    {
                        lowElement = array[i];
                        index = i;
                    }                  
                }

                for (int i = 0, y = 0; i < array.Length - 1; i++)
                {
                    if (lowElement == array[i] && index != i)
                    {
                        repeatIndex.Add(i);
                        y++;
                    }
                }

                Console.WriteLine("********************************\n");
                Console.WriteLine("\t РЕШЕНИЕ ЗАДАЧИ №5\n");

                Console.WriteLine("Результат выполнения программы\n Наименьшее число(-а) = {0}, с индексом {1}", lowElement, index);

                foreach (int repeatIndexIn in repeatIndex)
                {
                    Console.WriteLine("Индекс(-ы) повторяющегося наименьшего числа: ={0}", repeatIndexIn);
                }
                
                Console.WriteLine("\n********************************");

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

        /* 
         * ЗАДАЧА №6
         * Напишите программу, в которой создается целочисленный массив, заполняется случайными числами 
         * и после этого значения элементов в массиве сортируются в порядке убывания значений.
         */
        public void Task_6()
        {
            try {

                int size = Int32.Parse(
                    Interaction.InputBox(
                        "Введите размер массива: ",
                        "Ввод размерности массива."
                        )
                    );

                int[] array = new int[size];
                Random rnb = new Random();

                Console.WriteLine("********************************\n");
                Console.WriteLine("\t___ Неотсортированный массив ___");

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnb.Next(1, 100);
                    Console.WriteLine("Элемент массива \t№{0,2} \tравный {1} \tс индексом {2}", i+1, array[i], i);
                }

                Console.WriteLine("\n********************************");

                Console.WriteLine("\t___ ПРОИЗВОДИМ СОРТИРОВКУ МАССИВА ___\n");

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j=array.Length-1, s=0; j>0; j--)
                    {
                        if (array[j] > array[j - 1])
                        {
                            s = array[j - 1];
                            array[j - 1] = array[j];
                            array[j] = s;
                        }
                    }
                }

                Console.WriteLine("********************************\n");
                Console.WriteLine("\t РЕШЕНИЕ ЗАДАЧИ №6\n");
                Console.WriteLine("\t___ Отсортированный массив ___");
                Console.WriteLine("\t___ Элементы расположены по убыванию ___");

                for (int i = 0; i < array.Length; i++)
                {                    
                    Console.WriteLine("Элемент массива \t№{0} \tравный {1} \tс индексом {2}", i + 1, array[i], i);
                }

                Console.WriteLine("\n********************************");
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

        /* 
         * ЗАДАЧА №7
         * Нипишите программу, в которой создается символьный массив, а затем порядок элементов 
         * в массиве меняется на обратный.
         */
        public void Task_7()
        {
            try
            {
                Console.WriteLine("\n********************************\n");
                Console.WriteLine("\t РЕШЕНИЕ ЗАДАЧИ №7\n");
                Console.WriteLine("\tВВедите размер сивольного массива");

                int size = Int32.Parse(
                    Console.ReadLine());
                int index = 0;

                char[] array = new char[size];
                char[] arrayChange = new char[size];

                Random random = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = (char)random.Next(50, 150);
                }

                Console.WriteLine("\n Вывод на консоль созданного массива: ");

                foreach (char symbol in array)
                {
                    Console.Write("| {0} ", symbol);
                }
                Console.Write("|\n");

                // Меняем порядок элементов массива на обратный.
                for (int i = 0; i < array.Length; i++)
                {
                    size--;
                    arrayChange[size] = array[i];
                    
                }

                // Выводим измененный массив на консоль.
                Console.WriteLine("\n********************************\n");                
                Console.WriteLine("\t**** Измененный массив ****\n" +
                                  "\t**** с элементами в обратном порядке ****\n");

                foreach (char symbol in arrayChange)
                {
                    Console.Write("| {0} ", symbol);
                }
                Console.Write("|\n");

                Console.WriteLine("\n********************************\n");

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

        /* 
         * ЗАДАЧА №8
         * Напишите программу, в которой созадается двумерный целочисленный массив. Он заполняется
         * случайными числами. Затем в этом массиве строки и столбцы меняются местами: первая строка
         * становится первым столбцом, вторая строка становится вторым столбцом и так далее.
         * Например, если исходный массив состоял из 3 строк и 5 столбцов, то в итоге получаем 
         * массив из 5 строк и 3 столбцов.
         */
        public void Task_8()
        {
            try
            {
                int sizeX, sizeY, index = 0;

                Console.WriteLine("\n********************************\n");
                Console.WriteLine("\tРЕШЕНИЕ ЗАДАЧИ №8\n");
                Console.WriteLine("\tВВедите размер сивольного массиd\n");

                Console.WriteLine("Введите количество столбцов в массиве: ");
                sizeX = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество строк в массиве: ");
                sizeY = Int32.Parse(Console.ReadLine());

                int[,] arrayBefor = new int[sizeY, sizeX];
                int[,] arrayAfter = new int[sizeX, sizeY];

                Random random = new Random();

                // Заполнение двумерного массива случайными целочисленными числами
                Console.Write("\t\n----------------------------------\n");
                Console.Write("\t\n ***** \tПЕРВОНАЧАЛЬНЫЙ МАССИВ \t****\n");
                Console.WriteLine();
                for (int i = 0; i < arrayBefor.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayBefor.GetLength(1); j++)
                    {
                        arrayBefor[i,j] = random.Next(1, 100);

                        Console.Write("\t" + arrayBefor[i,j]);
                    }
                    Console.WriteLine();
                }

                // Меняем местами строки и столбцы. Записывает данные в новый массив.
               
                Console.Write("\t\n ***** \tИЗМЕНЕННЫЙ МАССИВ \t****\n");
                Console.WriteLine();
                for (int i = 0; i < arrayBefor.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayBefor.GetLength(1); j++)
                    {
                        int temp = arrayBefor[i, j];
                        arrayAfter[j, i] = temp;                      
                    }
                }

                // Выводим измененный массив на консоль.
                foreach (int temp in arrayAfter)
                {
                    index++;
                    Console.Write("\t" + temp);
                    if (index == sizeY)
                    {
                        Console.WriteLine();
                        index = 0;
                    }
                }
                Console.Write("\t\n----------------------------------\n");


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

        /*
         * ЗАДАЧА №9
         * Напишитее программу, в которой создается и инициализируется двумерный числовой массив.
         * Затем из этого массива удаляется строка и столбец (создается новый массив, в котором 
         * по сравнению с исходным удалена одна строка и один столбец). Индекс удаляемой строки 
         * и индекс удаляемого столбца определяется с помощью генератора случайных числел.
         */
        public void Task_9()
        {
            try
            {
                Random random = new Random();

                int sizeY, sizeX, a, b, index = 0;

                Console.WriteLine("\n********************************\n");
                Console.WriteLine("\tРЕШЕНИЕ ЗАДАЧИ №9\n");
                Console.WriteLine("\tВВедите размер сивольного массива\n");

                Console.WriteLine("Введите количество столбцов в массиве: ");
                sizeX = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество строк в массиве: ");
                sizeY = Int32.Parse(Console.ReadLine());

                int[,] arrayBefor = new int[sizeY, sizeX];
                int[,] arrayAfter = new int[arrayBefor.GetLength(0)-1, arrayBefor.GetLength(1)-1];

                int row = random.Next(arrayBefor.GetLength(0) - 1);
                int col = random.Next(arrayBefor.GetLength(1) - 1);

                // Создаем первичный двумерный массив и выводим его на консоль.
                Console.WriteLine("\t----------------------------------");
                Console.WriteLine("\t ***** \tПЕРВОНАЧАЛЬНЫЙ МАССИВ \t****\n");
                

                for (int i = 0; i < arrayBefor.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayBefor.GetLength(1); j++)
                    {
                        arrayBefor[i, j] = random.Next(1, 100);
                        Console.Write("\t" + arrayBefor[i, j]);
                    }
                    Console.WriteLine();
                }
                                
                Console.WriteLine("\n\t ***** \tИНДЕКС СЛУЧАЙНОЙ СТРОКИ = {0}\t****\n", row);
                Console.WriteLine("\t ***** \tИНДЕКС СЛУЧАЙНОГО СТОЛБЦА = {0}\t****\n", col);

                Console.WriteLine("\t ***** \tИЗМЕНЕННЫЙ МАССИВ \t****\n");

                for (int i = 0; i < arrayBefor.GetLength(0); i++)
                {
                    if (i > row)
                    {
                        a = i - 1;                        
                    } else a = i;
                    
                    for (int j = 0; j < arrayBefor.GetLength(1); j++)
                    {
                        if (j > col)
                        {
                            b = j - 1;
                        } else b = j;

                        arrayAfter[a, b] = arrayBefor[i, j];
                    }
                }

                // Выводим измененный массив на консоль.
                foreach (int temp in arrayAfter)
                {
                    index++;
                    Console.Write("\t" + temp);
                    if (index == arrayAfter.GetLength(1))
                    {
                        Console.WriteLine();
                        index = 0;
                    }
                }
                Console.Write("\t\n----------------------------------\n");
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

        public void Task_10()
        {
            try
            {
                int sizeY, sizeX, a, b, index = 0, indexFinal = 0;

                Console.WriteLine("\n********************************\n");
                Console.WriteLine("\tРЕШЕНИЕ ЗАДАЧИ №10\n");
                Console.WriteLine("\tВВедите размер целочисленного массива\n");

                Console.WriteLine("Введите количество столбцов в массиве: ");
                sizeX = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество строк в массиве: ");
                sizeY = Int32.Parse(Console.ReadLine());

                // i_Top - подсчет заполненых верхних строк массива.
                // i_Low - подсчет заполненых нижних строк массива. 
                // j_Right - подсчет заполненых правых столбцов массива. 
                // j_Left - подсчет заполненых левых столбцов массива.

                int i_Top = 0, i_Low = sizeY, j_Right = sizeX, j_Left = 0;

                int[,] array = new int[sizeY, sizeX];

                Console.Write("\t\n----------------------------------\n");

                for (int i = 0; i_Top < i_Low; i++)
                {   
                    // Запонение верхних строк слева на право.
                    for (int j = j_Left; j < j_Right; j++)
                    {
                        array[i, j] = index++;
                    }

                    i_Top++;

                    Console.WriteLine();

                    // Заполнение правых строк снизу вверх.
                    for (int i2 = i_Top; i2 < i_Low; i2++)
                    {
                        array[i2, j_Right - 1] = index++;
                    }
                    // Заполнение нижних строк справо налево.
                    for (int j2 = j_Right - 2; j2 >= j_Left; j2--)
                    {
                        array[i_Low - 1, j2] = index++;
                    }
                    // Заполнение левых строк снизу вверх.
                    for (int i3 = i_Low-2; i3 >= i_Top; i3--)
                    {
                        array[i3, j_Left] = index++;
                    }
                    
                    i_Low--;
                    j_Right--;
                    j_Left++;
                }

                //Выводим измененный массив на консоль.
                foreach (int temp in array)
                {
                    indexFinal++;
                    Console.Write("\t" + temp);
                    if (indexFinal == array.GetLength(1))
                    {
                        Console.WriteLine();
                        indexFinal = 0;
                    }
                }
                Console.Write("\t\n----------------------------------\n");

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

        static void Main()
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

                    if (index > 10 || index < 0)
                    {
                       MessageBox.Show(
                       "Вы ввели неверное число! Повторите ввод.",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                       );
                    }
                    switch (index)
                    {
                        case 1: ob.Task_1(); break;
                        case 2: ob.Task_2(); break;
                        case 3: ob.Task_3(); break;
                        case 4: ob.Task_4(); break;
                        case 5: ob.Task_5(); break;
                        case 6: ob.Task_6(); break;
                        case 7: ob.Task_7(); break;
                        case 8: ob.Task_8(); break;
                        case 9: ob.Task_9(); break;
                        case 10: ob.Task_10(); break;

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

                Main();
            }
        }
    }
}
