namespace StreamToRtsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Core.Initialize();

            using var libVLC = new LibVLC(enableDebugLogs: true);
        }
    }
}