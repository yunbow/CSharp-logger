namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.GetInstance();
            log.Error("error log.");
            log.Warn("warn log.");
            log.Info("info log.");
            log.Debug("debug log.");
        }
    }
}
