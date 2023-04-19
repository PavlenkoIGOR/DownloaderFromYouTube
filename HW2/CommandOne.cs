namespace HW2
{
    class CommandOne : Command
    {
        Reciever _reciever;
        public CommandOne(Reciever reciever)
        {
            _reciever = reciever;
        }

        public override void HarvesInfo()
        {
            _reciever.ShowInfoAsync();
            Console.WriteLine("сбор информации!");
        }
        public override void DownloadVideo()
        {
            _reciever.DownLoadVideoAsync();
            Console.WriteLine("скачивание видео!");
        }
    }
}
