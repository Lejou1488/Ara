using System;
using System.IO;
namespace _20._03._2020_Работа_с_фаилами
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b; //объявление переменных
            Console.WriteLine("Введите логин");
            a = Console.ReadLine(); //присвоение переменной того, что ввёл пользователь
            Console.WriteLine("Введите пароль");
            b = Console.ReadLine();
            FileStream file1 = new FileStream(@"C:\Temp\aut.txt", FileMode.Create); //файловый поток
            StreamWriter writer = new StreamWriter(file1); //потоковый писатель
            writer.Write("Логин: "); //запись в файл
            writer.Write(a);
            writer.Write(" Пароль: ");
            writer.Write(b);
            writer.Close(); //закрытыие потока
        }
    }
}
