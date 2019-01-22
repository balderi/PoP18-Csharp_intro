using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoting
{
    public partial class Form1 : Form
    {
        Class1 nyKlasse;

        
        public Form1()
        {
            InitializeComponent();
            nyKlasse = new Class1(1, 2);
        }

        private string OtherMethod(int tal,string tekst)
        {
            return tekst + " " + tal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nyKlasse.StringMthd(20));
            nyKlasse.MyMethod("hej", 420);   
            MessageBox.Show("whatup");
            label1.Text = nyKlasse.DelMeth(OtherMethod);

            for(int i = 0; i < 10; i++)
            {
                label1.Text += i.ToString();
            }
            int staticNum = Class2.nyeTal;
        }
    }
}
