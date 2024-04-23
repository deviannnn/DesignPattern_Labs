using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public interface IObserver
    {
        void Update(int val);
    }

    public abstract class MySubject
    {
        protected List<IObserver> _observers = new();
        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public abstract void DataChange();
    }

    public class WorkingSubject : MySubject
    {
        int _val;
        int triggerValue
        {
            get => _val;
            set
            {
                _val = value;
                DataChange();
            }
        }
        readonly int Count;

        public WorkingSubject(int count)
        {
            _val = triggerValue = 0;
            Count = count;
        }

        public void Start()
        {
            var th = new Thread(new ThreadStart(DoWork));
            th.Start();
        }

        public void DoWork()
        {
            for (int i = 0; i < Count; i++)
            {
                triggerValue = i + 1;
                Thread.Sleep(200);
            }
        }

        public override void DataChange()
        {
            foreach (var observer in _observers)
                observer.Update(triggerValue);
        }
    }
}
