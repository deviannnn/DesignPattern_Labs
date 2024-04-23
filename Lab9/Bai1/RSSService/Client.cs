using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Timer = System.Timers.Timer;

namespace RSSService
{
    internal class Client: IObserver
    {
        private int interval = 5000; // 5 seconds
        private Timer timer;
        private ISubject subject;
        private DateTime lastPull;

        public Client(ISubject subject)
        {
            this.subject = subject;
            lastPull = DateTime.Now;
            timer = new Timer();
            timer.Elapsed += TimerElapsed;
            timer.Interval = interval;
            timer.Start();
            subject.RegisterObserver(this);
        }

        public void Update(List<Post> posts)
        {
            lastPull = DateTime.Now;
            RefreshGUI(posts);
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (((RSSService)subject).HasNewPost(lastPull))
            {
                var posts = ((RSSService)subject).GetPosts();
                RefreshGUI(posts);
            }
        }

        private void RefreshGUI(List<Post> posts)
        {
            // Implement GUI refresh logic here
            Console.WriteLine("GUI has been refreshed with new posts.");
        }
    }
}
