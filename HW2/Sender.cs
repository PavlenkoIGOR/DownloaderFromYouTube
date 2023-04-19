
namespace HW2
{
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Вывести в консоль
        public void ConsoleViewerSender()
        {
            _command.HarvesInfo();
        }

        // Выполнить скачивание
        public void DownLoadVideoSender()
        {
            _command.DownloadVideo();
        }

    }

}
