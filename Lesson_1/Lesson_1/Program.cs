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
        }
    }
}
