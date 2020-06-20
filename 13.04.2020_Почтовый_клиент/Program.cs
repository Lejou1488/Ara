using System;
using System.Net;
using System.Net.Mail;

namespace _13._04._2020_Почтовый_клиент
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine(); //ввод почты отправителя
            string password = Console.ReadLine(); //ввод пароля от почты отправителя
            string name = Console.ReadLine(); //обращение
            string toEmail = Console.ReadLine(); //ввод почты получателя

            MailAddress from = new MailAddress(email, name); //почта и обращение
            MailAddress to = new MailAddress(toEmail); //почта получателя

            MailMessage objectMail = new MailMessage(from, to); //создание объекта письма
            objectMail.Subject = "Test"; //тема письма
            objectMail.Body = "Test-text"; //текст письма
            objectMail.IsBodyHtml = true; //письмо представляет код хтмл

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)) //адрес smp-сервера, с которого отправляется письмо
            {
                objectMail.Subject = "Test";
                objectMail.Body = "Test-text";
                objectMail.IsBodyHtml = true;

                smtp.Credentials = new NetworkCredential(email, password); //логин и пароль
                smtp.EnableSsl = true;
                smtp.Send(objectMail);
                Console.ReadKey();
            }
        }
    }
}
