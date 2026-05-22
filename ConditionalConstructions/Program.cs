using System.Security.Cryptography.X509Certificates;

namespace ConditionalConstructions
{
    internal class Program
    {
        public static void TaskOne()
        {
            /* 
             * Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
             * А программа сранивает два введенных числа и выводит на консоль результат сравнения 
             * (два числа равны, первое число больше второго или первое число меньше второго).
             */

            Console.Write("Введите Ваше первое число: ");
            double firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Ваше второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Первое число больше ({firstNumber}), чем второе ({secondNumber})");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine($"Второе число больше ({secondNumber}), чем перввое ({firstNumber})");
            }
            else
            {
                Console.WriteLine($"Числа равны: {firstNumber} = {secondNumber}");
            }
        }
        public static void TaskTwo()
        {
            /* 
             * Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, 
             * то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число". 
             */

            Console.Write("Введите Ваше число: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            if (userNumber > 5 && userNumber < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        public static void TaskThree()
        {
            /* 
             * Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, 
             * то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".
             */

            Console.Write("Введите Ваше число: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            if (userNumber == 5 || userNumber == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        public static void TaskFour()
        {
            /* 
             * В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу, 
             * в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, 
             * то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с 
             * начисленными процентами.Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine()) 
             */

            Console.Write("Введите Вашу сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            double bonus;

            if (sum < 100)
            {
                Console.WriteLine($"Сумма Вашей надбавки составляет {bonus = sum * 0.05}. Итоговая сумма на счету: {sum + bonus}");
            }
            else if (sum >= 100 && sum <= 200)
            {
                Console.WriteLine($"Сумма Вашей надбавки составляет {bonus = sum * 0.07}. Итоговая сумма на счету: {sum + bonus}");
            }
            else
            {
                Console.WriteLine($"Сумма Вашей надбавки составляет {bonus = sum * 0.10}. Итоговая сумма на счету: {sum + bonus}");
            }
        }
        public static void TaskFive()
        {
            /* 
             * Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
             * И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. 
             * Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы. 
             */

            Console.Write("Введите Вашу сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            
            double bonus;
            const double SPECIAL_BONUS = 15;


            if (sum < 100)
            {
                Console.WriteLine($"Сумма Вашей надбавки составляет {bonus = sum * 0.05}. Бонус: {SPECIAL_BONUS}. Итоговая сумма на счету: {sum + bonus + SPECIAL_BONUS}");
            }
            else if (sum >= 100 && sum <= 200)
            {
                Console.WriteLine($"Сумма Вашей надбавки составляет {bonus = sum * 0.07}. Бонус: {SPECIAL_BONUS}. Итоговая сумма на счету: {sum + bonus + SPECIAL_BONUS}");
            }
            else
            {
                Console.WriteLine($"Сумма Вашей надбавки составляет {bonus = sum * 0.10}. Бонус: {SPECIAL_BONUS}. Итоговая сумма на счету: {sum + bonus + SPECIAL_BONUS}");
            }
        }
        public static void TaskSix()
        {
            /* 
             * Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". 
             * Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции, 
             * и в зависимости от номера операции программа выводит ему название операции. Для определения операции по введенному номеру используйте конструкцию switch...case.
             * Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том, что операция 
             * неопределена. 
             */

            Console.Write("Введите номер операции: 1 - Сложение, 2 - Вычитание, 3 - Умножение: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1: 
                    Console.WriteLine("Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }
        }
        public static void TaskSeven()
        {
            /* 
             * Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с введенными числами 
             * выполняются определенные действия (например, при вводе числа 3 числа умножаются). Результат операции выводиться на консоль.
             */

            Console.Write("Введите номер операции: 1 - Сложение, 2 - Вычитание, 3 - Умножение: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваше первое число: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваше второе число: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Сложение: {firstNumber + secondNumber}");
                    break;
                case 2:
                    Console.WriteLine($"Вычитание: {firstNumber - secondNumber}");
                    break;
                case 3:
                    Console.WriteLine($"Умножение: {firstNumber * secondNumber}");
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }
        }

        static void Main(string[] args) { }
    }
}
