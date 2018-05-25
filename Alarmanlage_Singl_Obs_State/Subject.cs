using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    public abstract class Subject
    {
        private List<IObserver> ObserverListe = new List<IObserver>();

        public void Attach(IObserver objekt)
        {
            ObserverListe.Add(objekt);
        }

        public void Detach(IObserver objekt)
        {
            ObserverListe.Remove(objekt);
        }

        public void Notify()
        {
            foreach (IObserver observer in ObserverListe)
            {
                observer.Update();
            }
        }
    }
}
