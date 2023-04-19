using YoutubeExplode;
using YoutubeExplode.Converter;

namespace HW2
{
    class Reciever : CreateFolder
    {
        YoutubeClient youtube = new();

        private string _urlAddress = string.Empty;
        public Reciever(string UrlAdress)
        {
            _urlAddress = UrlAdress;
        }
        internal async Task ShowInfoAsync()
        {
            var video = await youtube.Videos.GetAsync(_urlAddress);

            Console.WriteLine($"Название видео: {video.Title}");    //получение названия видео
            Console.WriteLine($"Название канала: {video.Author.ChannelTitle}"); //получение названия канала видео
            Console.WriteLine($"Длительность видео: {video.Duration}"); //получение длительности видео

        }

        internal async Task DownLoadVideoAsync()
        {
            var video = await youtube.Videos.GetAsync(_urlAddress);
            try
            {
                CreateNewFolder();
                var u = youtube.Videos.DownloadAsync(_urlAddress, $"{outPutPath}{video.Title}.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));

                Console.Write("Идёт скачивание файла");

                do
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(200);
                    }

                    Console.SetCursorPosition(21, 3);

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(" ");
                        Thread.Sleep(200);
                    }

                    Console.SetCursorPosition(21, 3);
                } while (!u.IsCompleted);

                await u;
                Task.WaitAll();

                Console.WriteLine("\nФайл загружен!");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }

}
