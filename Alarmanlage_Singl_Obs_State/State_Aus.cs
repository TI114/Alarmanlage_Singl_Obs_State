using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    class State_Aus : IState
    {
        public void Change(StateContext context)
        {
            if (context.Password == context.EingegebenesPW)
            {
                context.AktuellenStatusSetzen(new State_Scharf());
                Console.WriteLine("Status Scharf");
            }
            else
            { Console.WriteLine("Passwort Falsch"); }
        }

        
    }
}
