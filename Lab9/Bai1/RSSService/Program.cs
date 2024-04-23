using System.Timers;

namespace RSSService
{
    public class Test
    {
        public static void Main(string[] args)
        {
            RSSService service = new RSSService();
            Client client1 = new Client(service);
            Client client2 = new Client(service);

            // Call AddPost to test
            Post p1 = new Post("post 1 title", "post 1 content");
            service.AddPost(p1);
            Post p2 = new Post("post 2 title", "post 2 content");
            service.AddPost(p2);
        }
    }
}