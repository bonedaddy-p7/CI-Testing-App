using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CITesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string DoSomething()
        {
            return DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CILib.CIStuff s = new CILib.CIStuff();
            //label1.Text = s.GetNowDateTimeString();
            label1.Text = s.GiveMeAString();
            //label1.Text = DoSomething();
        }
    }
}
