// See https://aka.ms/new-console-template for more information
using SimpleFTP;
namespace SimpleFTP
{
    class TestMyApp
    {
        static void Main()
        {
            MyApp app = new();
            ISimpleFTP ftp = new MyFTP();

            app.SetFTP(ftp);
            app.DoSomething();

            ftp = new FTPAdapter();
            app.SetFTP(ftp);
            app.DoSomething();
        }
    }
}