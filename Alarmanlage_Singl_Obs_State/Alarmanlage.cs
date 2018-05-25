using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarmanlage_Singl_Obs_State
{
    public class Alarmanlage : Subject
    {
        IState Status;
        private string Password;
                        
        public Alarmanlage(IState newStatus)
        {
            Status = newStatus;
        }

        public IState GetStatus()
        {
            return Status;
        }

        public void SetStatus(IState newStatus)
        {
            Status = newStatus;
        }

        public void Anschalten(string parameter)
        {
            SetPassword(parameter);
            Status.Anschalten(this);
            Notify();
        }

        public void Ausschalten(string parameter)
        {
            if (PasswordCheck(parameter))
            {
                Status.Ausschalten(this);
                Notify();
            }            
            else
            {
                AlarmAusloesen();
                MessageBox.Show("Passwort Falsch!");
            }
        }

        public void AlarmAusloesen()
        {
            Status.AlarmAusloesen(this);
            Notify();
        }

        private bool PasswordCheck(string pw)
        {
            if (pw == Password)
            {
                return true;
            }
            else
            { return false; }
        }

        public void SetPassword(string pw)
        {
            Password = pw;
        }
    }
}
