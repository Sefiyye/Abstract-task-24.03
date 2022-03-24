using System;

namespace Abstract_Task
{
     class Program
    {
        static void Main(string[] args)
        {
            EmailSender send = new EmailSender();
            SmsSender sender = new SmsSender();

            Console.WriteLine("If you need sent by Email click to 1");
            Console.WriteLine("If you need sent by Sms click to 2");
            Console.WriteLine("When pressing 0 aplication the and");

            Console.WriteLine("Enter number: ");
            byte number = Convert.ToByte(Console.ReadLine());

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine(send.SendMessage());
                        break;
                    case 2:
                        Console.WriteLine(sender.SendMessage());
                        break;
                    case 0:
                        Console.WriteLine("Aplication the end");
                        break;
                    default:
                        Console.WriteLine("Enter number to 0 from 2");
                        break;

                }
                break;
            }
            while (number >= 0 && number <= 2);
        }
    }
}
