using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    public interface IState
    {
        //void Change(StateContext context);

        void Anschalten(Alarmanlage alarmanlage);

        void Ausschalten(Alarmanlage alarmanlage);

        void AlarmAusloesen(Alarmanlage alarmanlage);
        

    }
}
