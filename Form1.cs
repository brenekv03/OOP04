using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto auto1 = new Auto("123-ABC", 0, DateTime.MinValue,5, false);
        private void button1_Click(object sender, EventArgs e)
        {
            auto1.Rozjed();
            MessageBox.Show(auto1.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto1.Zastav(200);
            auto1.CelkovaSpotreba();
            MessageBox.Show(auto1.ToString());
        }
    }
}
