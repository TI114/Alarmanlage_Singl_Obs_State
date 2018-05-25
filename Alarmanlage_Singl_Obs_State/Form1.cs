using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarmanlage_Singl_Obs_State
{
    public partial class Form1 : Form
    {
        StateContext Alarmanlage = new StateContext();
        List<StateContext> myList = new List<StateContext>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            
            Alarmanlage.EingegebenesPW = textBox1.Text;
            if (Alarmanlage.Password == null)
            {
                Alarmanlage.Password = Alarmanlage.EingegebenesPW;
            }
            Alarmanlage.Change();
            listBox1.Items.Clear();
            listBox1.Items.Add(Alarmanlage.AktuellerStatus);
        }
    }
}
