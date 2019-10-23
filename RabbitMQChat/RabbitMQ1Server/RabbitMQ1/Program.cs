using System;
using System.Threading;

namespace RabbitMQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Mq.Helper.PublisherHelper("chat", "welcome");
            new Mq.Helper.ConsumerHelper("chat");


            while (true)
            {
                string consoleMessage = Console.ReadLine();
                new Mq.Helper.PublisherHelper("chat", consoleMessage);
            }

            //new Mq.Helper.ConsumerHelper("bilgeadam");

            //while (true)
            //{
            //    new Mq.Helper.PublisherHelper("bilgeadam", "deneme123");
            //    Thread.Sleep(1000);
            //}

           
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
        }
    }
}
