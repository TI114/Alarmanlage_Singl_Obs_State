using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    interface IState
    {
        void Change(StateContext context);
        //void Ausschalten(StateContext context);
    }
}
