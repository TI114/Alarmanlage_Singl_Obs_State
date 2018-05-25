using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    class State_Scharf : IState
    {
        private static IState Instance;

        private State_Scharf()
        {

        }

        public static IState GetInstance()
        {
            if (Instance == null)
            {
                Instance = new State_Scharf();
            }
            return Instance;

        }

        public void AlarmAusloesen(Alarmanlage alarmanlage)
        {
            alarmanlage.SetStatus(State_Alarmiert.GetInstance());
        }

        public void Anschalten(Alarmanlage alarmanlage)
        {
            // bleibt leer
        }

        public void Ausschalten(Alarmanlage alarmanlage)
        {
            alarmanlage.SetStatus(State_Aus.GetInstance());   
        }        

    }
}
