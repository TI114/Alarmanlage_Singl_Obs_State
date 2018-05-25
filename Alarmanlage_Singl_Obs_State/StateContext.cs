using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    class StateContext
    {
        public IState AktuellerStatus = new State_Aus();

        private string MyEingegebenesPW;

        public string EingegebenesPW
        {
            get { return MyEingegebenesPW; }
            set { MyEingegebenesPW = value; }
        }
        
        private string MyPassword;

        public string Password
        {
            get { return MyPassword; }
            set { MyPassword = value; }
        }

        public void Change()
        {
            AktuellerStatus.Change(this);                
        }

        public void AktuellenStatusSetzen(IState NeuerStatus)
        {
            AktuellerStatus = NeuerStatus;
        }

    }
}
