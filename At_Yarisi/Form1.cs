using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int at_1_soluzaqliq, at_2_soluzaqliq, at_3_soluzaqliq;
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            at_1_soluzaqliq = pBox_at1.Left;
            at_2_soluzaqliq = pBox_at2.Left;
            at_3_soluzaqliq = pBox_at3.Left;

        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            pBox_at1.Left = 0;
            pBox_at2.Left = 0;
            pBox_at3.Left = 0;
            label6.Text = "";
            label7.Text = "";
            Application.Restart();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int xal = Convert.ToInt32(label7.Text);
            xal++;
            label7.Text = xal.ToString();


            int at_1_genislik = pBox_at1.Width;
            int at_2_genislik = pBox_at2.Width;
            int at_3_genislik = pBox_at3.Width;

            int bitme_uzaqligi = label5.Left;
            pBox_at1.Left += rand.Next(5, 10);
            pBox_at2.Left += rand.Next(5, 10);
            pBox_at3.Left += rand.Next(5, 10);

            if (pBox_at1.Left > pBox_at2.Left +5 && pBox_at1.Left > pBox_at3.Left +5)
            {
                label6.Text = "Birinci at yarisda irelidedir";
            }
            if (pBox_at2.Left > pBox_at1.Left + 5 && pBox_at2.Left > pBox_at3.Left + 5)
            {
                label6.Text = "Ikinci at liderliyi ele kecirir ";
            }
            if (pBox_at3.Left > pBox_at1.Left + 5 && pBox_at3.Left > pBox_at2.Left + 5)
            {
                label6.Text = "Ucuncu at ireli kecir";
            }
            if (at_1_genislik+ pBox_at1.Left > bitme_uzaqligi)
            {
                timer1.Enabled=false;
                label6.Text = "Birinci at qazandi";
                btn_exit.Enabled=true;
                btn_restart.Enabled = true;

            }
            if (at_2_genislik + pBox_at2.Left > bitme_uzaqligi)
            {
                timer1.Enabled = false;
                label6.Text = "Ikinci at qazandi";
                btn_exit.Enabled = true;
                btn_restart.Enabled = true;


            }
            if (at_3_genislik + pBox_at3.Left > bitme_uzaqligi)
            {
                timer1.Enabled = false;
                label6.Text = "Ucuncu at qazandi";
                btn_exit.Enabled = true;
                btn_restart.Enabled = true;


            }

        }

    }
}
