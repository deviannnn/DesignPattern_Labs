using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSService
{
    public class RSSService : ISubject
    {
        private DateTime lastUpdate;
        private List<Post> posts;
        private List<IObserver> observers;

        public RSSService()
        {
            posts = new List<Post>();
            lastUpdate = DateTime.Now;
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(posts);
            }
        }

        public void AddPost(Post p)
        {
            posts.Add(p);
            lastUpdate = DateTime.Now;
            NotifyObservers();
        }

        public bool HasNewPost(DateTime dt)
        {
            return lastUpdate > dt;
        }

        public List<Post> GetPosts()
        {
            return new List<Post>(posts);
        }
    }
}   