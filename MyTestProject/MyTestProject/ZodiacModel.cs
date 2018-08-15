using System;
using System.Collections.Generic;
namespace MyTestProject
{
    public class ZodiacModel: IModelSubject
    {
        List<IModelObserver> m_observers = new List<IModelObserver>();

        public ZodiacModel() { }

        //notify observers
        public void NotifyObservers()
        {
            for (int i = 0; i < m_observers.Count; ++i)
            {
                m_observers[i].UpdateData(this);
            }
        }

        //remove observer
        public IModelObserver RegisterObserver(IModelObserver o)
        {
            if (!m_observers.Contains(o))
            {
                m_observers.Add(o);
                return o;
            }
            else
            {
                throw new Exception("subject already contains passed observer");
            }
        }

        //remove observer
        public IModelObserver RemoveObserver(IModelObserver o)
        {
            if (m_observers.Contains(o))
            {
                m_observers.Remove(o);
                return o;
            }
            else
            {
                throw new Exception("subject does not contain passed observer");
            }
        }
    }
}
