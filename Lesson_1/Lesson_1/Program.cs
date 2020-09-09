using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше Имя: "); // Вывод сообщения и чтение данных введённых в консоль(строку)
            string name = Console.ReadLine(); //Чтение только что записаных данных в консоль и запись в пременную name
            Console.WriteLine("Привет:" + name); // конкатинация сообщения и строчной переменной
            Console.WriteLine("122134124");
            //Чтобы Шиза в других средах или после компиляции мгновенная не сворачивала консоль
            Console.WriteLine("Нажмите <Enter>, чтобы Шиза не закрыла консоль");
            Console.Read();
        }
    }
}
