using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmanlage_Singl_Obs_State
{
    public class Singleton
    {
        private static Singleton InstanceObjekt = null;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (InstanceObjekt == null)
            {
                InstanceObjekt = new Singleton();
                
            }
            return InstanceObjekt;
        }

    }
}
