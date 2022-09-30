using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            Program.Repeat(24, "хеллоу");

            string login = Console.ReadLine();

            string pass = Console.ReadLine();

            double visota = Convert.ToInt32(Console.ReadLine());

            double dlina = Convert.ToInt32(Console.ReadLine());

            double shirina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ploshad(dlina, shirina, visota));


            Console.WriteLine(Auth(login, pass));
        }


        static public void Repeat(int count, string text)
        {
            for (int i = 0; i < count; i++)                              /*Метод 1*/
            {
                Console.WriteLine(text);
            }
        }

        static public string Auth(string login, string pass)
        {


            if (login == "admin" && pass == "123")
                return ("Авторизация успешна!");

            return ("Проверьте данные!");
        }


        static public string Ploshad(double dlina, double shirina, double visota)
        {                                                                      /*Считает площадь  и возвращает результат*/
            return $"Площадь =  {dlina * shirina * visota}";
        }






    }
}
