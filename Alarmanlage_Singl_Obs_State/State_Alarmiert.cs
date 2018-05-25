﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    class State_Alarmiert : IState
    {
        public void AlarmAusloesen(Alarmanlage alarmanlage)
        {
            // bleibt leer
        }

        public void Anschalten(Alarmanlage alarmanlage)
        {
            // bleibt leer
        }

        public void Ausschalten(Alarmanlage alarmanlage)
        {
            alarmanlage.SetStatus(new State_Aus());
        }


    }
}
