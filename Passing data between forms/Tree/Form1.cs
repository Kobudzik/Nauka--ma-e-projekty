using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class Form1 : Form
    {
        //MUSI BYĆ STATYCZNE ABY NIE TRZEBA BYŁO TWORZYĆ INSTANCJI
        public static string value;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = textBox1.Text;
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
         // textBox1.Text=secondForm.
        }
    }
}
