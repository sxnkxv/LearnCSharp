namespace Loops
{
    internal class Program
    {
        public static void TaskOne()
        {
            /* 
             * За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и 
             * количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.Для вычисления суммы с учетом 
             * процентов используйте цикл for. Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет 
             * представлять тип decimal). 
             */

            Console.Write("Введите сумму Вашего вклада: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите количество месяцев: ");
            int monthsNumber = Convert.ToInt32(Console.ReadLine());

            decimal rate = 0.07m;
            decimal totalSum = depositAmount;
            decimal bonus = 0;

            for (int i = 1; i <= monthsNumber; i++)
            {
                bonus = totalSum * rate;
                totalSum += bonus;
            }

            Console.WriteLine($"Итоговая сумма составит: {totalSum}");
        }
        public static void TaskTwo() 
        {
            /* 
             * Напишите программу, которая выводит на консоль таблицу умножения 
             */

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
        public static void TaskThree()
        {
            /* 
             * За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и 
             * количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.Для вычисления суммы с учетом 
             * процентов используйте цикл while. Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет 
             * представлять тип decimal). 
             */

            Console.Write("Введите сумму вклада: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите количество месяцев: ");
            int monthsCount = Convert.ToInt32(Console.ReadLine());

            const decimal PERCENT = 0.07m;

            int month = 1;
            while (month <= monthsCount)
            {
                depositAmount += (depositAmount * PERCENT);
                month++;
            }

            Console.WriteLine($"Ваш вклад составит: {depositAmount}");
        }
        public static void TaskFour()
        {
            /* 
             * Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. 
             * При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. 
             * Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, 
             * что введенные числа недопустимы, и повторно запросить у пользователя ввод двух чисел. 
             * Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.
             * Для организации ввода чисел используйте бесконечный цикл while и оператор break.
             */

            double firstNumber;
            double secondNumber;

            while (true)
            {
                Console.Write("Введите первое число: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                secondNumber = Convert.ToDouble(Console.ReadLine());

                if ((firstNumber >= 0 && firstNumber <= 10) && (secondNumber >= 0 && secondNumber <= 10))
                {
                    Console.WriteLine($"Результат умножения: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine("Введенные числа недопустимы!");
                }
            }
        }

        static void Main(string[] args) { }
    }
}
