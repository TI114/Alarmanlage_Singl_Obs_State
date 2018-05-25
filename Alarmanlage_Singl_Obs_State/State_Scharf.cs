using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    class State_Scharf : IState
    {
        public void Change(StateContext context)
        {
            if (context.Password != context.EingegebenesPW)
            {
                context.AktuellenStatusSetzen(new State_Alarmiert());
                Console.WriteLine("Status Alarmiert");
            }
            if (context.Password == context.EingegebenesPW)
            {
                context.AktuellenStatusSetzen(new State_Aus());
                Console.WriteLine("Status Aus");
            }
            else
            { Console.WriteLine("Passwort Falsch"); }
        }

    }
}
