using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    class State_Aus : IState
    {
        private static IState Instance;

        private State_Aus()
        {
            
        }

        public static IState GetInstance()
        {
            if (Instance == null)
            {
                Instance = new State_Aus();
            }
            return Instance;
            
        }

        public void AlarmAusloesen(Alarmanlage alarmanlage)
        {
            // bleibt leer
        }

        public void Anschalten(Alarmanlage alarmanlage)
        {
            alarmanlage.SetStatus(State_Scharf.GetInstance());
        }

        public void Ausschalten(Alarmanlage alarmanlage)
        {
            // bleibt leer
        }


    }
}
