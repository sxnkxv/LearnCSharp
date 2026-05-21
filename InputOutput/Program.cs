namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string? name = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.Write("Введите свой рост: ");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите свою зарплату: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ваши данные с помощью интерполяции: ");
            Console.Write($"'Имя': {name}, 'Возраст': {age}, 'Рост': {height}, 'Зарплата': {salary}");

            Console.WriteLine();

            Console.WriteLine("Ваши данные с помощью плейсхолдеров: ");
            Console.Write("'Имя': {0}, 'Возраст': {1}, 'Рост': {2}, 'Зарплата': {3}", name, age, height, salary);
        }
    }
}