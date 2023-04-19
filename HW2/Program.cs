using HW2;

namespace Module18.HW
{



    internal class Program
    {
        static void Main(string[] args)
        {
                //выберем видео с ютьюбчика
                Console.Write("укажите адрес видео: ");
                string urlFile = Console.ReadLine();

                Reciever youTubeFile = new Reciever(urlFile);

                Sender sender = new Sender();

                //команда для скачивания
                CommandOne commandOne = new CommandOne(youTubeFile);
                sender.SetCommand(commandOne);

                Console.Write("скачать видео(1) или показать инфо(2) о нём? (1/2): ");
                switch (Convert.ToByte(Console.ReadLine()))
                {
                    case 1:
                    sender.DownLoadVideoSender();
                    break;
                    case 2:
                    sender.ConsoleViewerSender();
                    break;
                    default:
                    break;
                }

            Console.ReadKey();
        }
    }
}