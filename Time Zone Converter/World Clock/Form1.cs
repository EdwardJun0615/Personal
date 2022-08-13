using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace World_Clock
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer interval
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if(hh<10)
            {
                time = "0" + hh;
            } else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time = "0" + mm;
            } else
            {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {
                time = "0" + ss;
            } else
            {
                time += ss;
            }

            jst.Text = time;

            string estTime = "";
            int estH = hh - 13;
            if(estH < 10)
            {
                estTime = "0" + estH;
            }
            else
            {
                estTime += estH;
            }
            estTime += ":";

            if(mm < 10) { 
                estTime = "0" + mm;
            }
            else
            {
                estTime += mm;
            }
            estTime += ":";

            if(ss < 10)
            {
                estTime = "0" + ss;
            }
            else
            {
                estTime += ss;
            }
            est.Text = estTime;
        }
    }
}