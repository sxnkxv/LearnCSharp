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

        static void Main(string[] args) { TaskTwo(); }
    }
}
