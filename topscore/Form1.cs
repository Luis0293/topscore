using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topscore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contador conta = new Contador();

        private void Button1_Click(object sender, EventArgs e)
        {
            conta.Move(sender);
            label1.Text = conta.Score();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = conta.Time();
            conta.Gravar();
            label3.Text = conta.Ler;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label3.Text = conta.TopScore();
            timer1.Stop();
            label1.Text = conta.ResetP();
            label4.Text = conta.ResetT();
            conta.ResetO(button1);
        }
    }
}
