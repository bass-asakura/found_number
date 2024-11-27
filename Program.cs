namespace found_number;

class Program
{
    static void print(string qwe)
    {
        Console.WriteLine(qwe);
    }

    static void Main(string[] args)
    {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            print("Число загадано, ждем ваши варианты!");

        while (true)
        {
            int example_num = Convert.ToInt32(Console.ReadLine());
            if (example_num > number)
            {
                print("Ваше число больше загаданного \n Введите еще раз");
            }
            else if (example_num < number)
            {
                print("Ваше число меньше загаданного \n Введите еще раз");
            }
            else
            {
                print("Вы угадали число!");
                return;
            }
        }       
    }
}
