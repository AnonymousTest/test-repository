namespace Log4NetDemo
{
    using log4net.Config;
    using System;

    class Log4NetDemo
    {
        static void Main()
        {
            log4net.ILog log = log4net.LogManager.GetLogger("Some String");
            log.Info("For Your Information");
            log.Warn("Danger Will Robinson");
            log.Debug("Debug Message");

            //To show msg in console
            BasicConfigurator.Configure();
            
            try
            {
                throw new Exception("Deliberate Exception");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            
            log.Fatal("Die. Die. Die!", new ApplicationException("Fatal Exception"));
            Console.WriteLine("======================= End ========================");
            Console.ReadKey();
        }
    }
}