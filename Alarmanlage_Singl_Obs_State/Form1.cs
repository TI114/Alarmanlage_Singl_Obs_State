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
        Alarmanlage UnsereAA;

        public Form1()
        {
            InitializeComponent();
            UnsereAA = new Alarmanlage(State_Aus.GetInstance());            
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            UnsereAA.Anschalten(textBox1.Text);            
        }

        private void btn_aus_Click(object sender, EventArgs e)
        {
            UnsereAA.Ausschalten(textBox1.Text);
        }
    }
}
