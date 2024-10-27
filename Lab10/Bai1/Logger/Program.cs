namespace Logger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // nén – log;
            Logger logger1 = new DefaultLogger();
            logger1 = new CompressLogger(logger1);
            logger1.Log("Hello Lab10");

            // mã hóa – log;
            Logger logger2 = new DefaultLogger();
            logger2 = new EncryptedLogger(logger2);
            logger2.Log("Bonjour Lab10");

            // nén – mã hóa – log;
            Logger logger3 = new DefaultLogger();
            logger3 = new EncryptedLogger(logger3);
            logger3 = new CompressLogger(logger3);
            logger3.Log("Xin chào Lab10");

            // mã hóa – nén – log;
            Logger logger4 = new DefaultLogger();
            logger4 = new CompressLogger(logger4);
            logger4 = new EncryptedLogger(logger4);
            logger4.Log("Hallo Lab10");
        }
    }
}