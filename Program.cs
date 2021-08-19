using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    ///  выводящий данные о струдниках и автоматический подсчёт среднего балла по трём предметам.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод Main() является
        /// входной точкой работы программы
        /// </summary>
        /// <param name="args">Аргумент метода Main()</param>
        static void Main(string[] args)
        {

            //var padding = Console.WindowWidth / 2 + text.Length / 2;
            //Console.WriteLine("{0," + padding + "}", text);


            #region Specialist_1 

            ///Объявлены переменные под данные для первого сотрудника
            ///Рассчитать среднее арифметическое баллов для сотрудника

            Console.Write("Введите свое имя: ");
            string firstName1 = Console.ReadLine();                  // мя сотрудника
            Console.Write("Введите свой возраст: ");
            byte age1 = Convert.ToByte(Console.ReadLine());          // возраст сотрудника
            while (!Int32.TryParse(Console.ReadLine(), out age1) || age1 <= 18 || age1 > 75)
            {
                Console.WriteLine("Некорректные данные. Возраст должен быть положительным числом до 75. Попробуйте еще раз.");
            }

            Console.Write("Введите свой рост в см: ");
            int height1 = Convert.ToInt32(Console.ReadLine());       // рост сотрудника в см
            while (!Int32.TryParse(Console.ReadLine(), out height1) || height1 <= 100 || height1 > 270)
            {
                Console.WriteLine("Рост должен быть от 100 см до 270 см. Повторите попытку.");
            }
            Console.Write("Введите свой балл по русскому: ");
            int russ1 = Convert.ToInt32(Console.ReadLine());         // балл по русскому языку
            Console.Write("Введите свой балл по истории: ");
            int hist1 = Convert.ToInt32(Console.ReadLine());         // балл по истории
            Console.Write("Введите свой балл по математике: ");
            int math1 = Convert.ToInt32(Console.ReadLine());         // балл по математике
            double avgScore1 = (russ1 + hist1 + math1) / 3.0;          // Авторасчет среднего балла

            /*Простой вывод о сотруднике №1
             * Вывод данных в центре консоли
             */

            //int height1;
            //Console.WriteLine("Введите ваш рост");

            string pattern = "Имя: " + firstName1 + " Возраст: " + age1 + " Рост: " + height1 + " см.  Балл по русскому: " + russ1 + " Балл по истории: " + hist1 + " Балл по математике: " + math1 + " Средний балл: " + avgScore1.ToString("N2");
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + pattern.Length / 2) + "}", pattern);
            #endregion Specialist_1


            // Console.Clear(); //Очищаем консоль

            #region Specialist_2

            /////Объявлены переменные под данные для второго сотрудника
            /////Рассчитать среднее арифметическое баллов для сотрудника

            //Console.Write("Введите свое имя: ");
            //string firstName_2 = Console.ReadLine();                      // имя сотрудника
            //Console.Write("Введите свой возраст: ");
            //byte age = Convert.ToByte(Console.ReadLine());              // возраст сотрудника
            //Console.Write("Введите свой рост в см: ");
            //int height = Convert.ToInt32(Console.ReadLine());           // рост сотрудника в см
            //Console.Write("Введите свой балл по русскому: ");
            //int russian = Convert.ToInt32(Console.ReadLine());          // балл по русскому языку
            //Console.Write("Введите свой балл по истории: ");
            //int history = Convert.ToInt32(Console.ReadLine());          // балл по истории
            //Console.Write("Введите свой балл по математике: ");
            //int math = Convert.ToInt32(Console.ReadLine());             // балл по математике
            //double avg_score = (russian + history + math) / 3.0;          // средний балл


            ///*Простой вывод о сотруднике №2
            // * Вывод данных в центре консоли
            // */
            ///// Форматированный вывод о сотруднике №2         

            //string newPattern = "Имя: {0} \nВозраст: {1} \nРост: {2} см\nБалл по русскому: {3} \nБалл по истории: {4} \nБалл по математике: {5} \nСредний балл : {6}\n";

            //Console.WriteLine(newPattern,
            //                  firstName_2,
            //                  age,
            //                  height,
            //                  russian,
            //                  history,
            //                  math,
            //                  avg_score.ToString("N2"));
            //Print(newPattern);
            #endregion

            //Console.Clear(); //Очищаем консоль

            #region Specialist_3

            ///Объявлены переменные под данные для третьего сотрудника
            ///Рассчитать среднее арифметическое баллов для сотрудника

            Console.Write("Введите свое имя: ");
            string firstName_3 = Console.ReadLine();                      // имя сотрудника
            Console.Write("Введите свой возраст: ");
            byte age_3 = Convert.ToByte(Console.ReadLine());              // возраст сотрудника
            Console.Write("Введите свой рост в см: ");
            int height_3 = Convert.ToInt32(Console.ReadLine());           // рост сотрудника в см
            Console.Write("Введите свой балл по русскому: ");
            int russ_3 = Convert.ToInt32(Console.ReadLine());          // балл по русскому языку
            Console.Write("Введите свой балл по истории: ");
            int hist_3 = Convert.ToInt32(Console.ReadLine());          // балл по истории
            Console.Write("Введите свой балл по математике: ");
            int math_3 = Convert.ToInt32(Console.ReadLine());             // балл по математике
            double avg_score_3 = (russ_3 + hist_3 + math_3) / 3.0;          // средний балл
            string avg3 = avg_score_3.ToString("N2");

            /*Простой вывод о сотруднике №3
             * Вывод данных в центре консоли
             */
            /// Вывод с использованием интерполяции строк вывод о сотруднике №3

            //Console.WriteLine("{0," + ((Console.WindowWidth / 2) + msg.Length / 2) + "}", msg);
            string a = $"Имя: {firstName_3} \nВозраст: {age_3} \nРост: {height_3} \nБалл по русскому: {russ_3} \nБалл по истории: {hist_3} \nБалл по математике: {math_3} \nСредний балл : {avg_score_3.ToString("N2")}";
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + a.Length / 2) + "}", a);
            //Console.WriteLine($"Имя: {firstName_3} \nВозраст: {age_3} \nРост: {height_3} \nБалл по русскому: {russ_3} \nБалл по истории: {hist_3} \nБалл по математике: {math_3} \nСредний балл : {avg_score_3.ToString("N2")}");
            #endregion

            Console.ReadKey(); // Ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}
