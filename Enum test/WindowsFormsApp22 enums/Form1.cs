using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp22_enums
{
    public partial class Form1 : Form
    {
        enum Wyliczanie
        {
            Sit = 7,
            Beg = 25,
            RollOver = 50,
            Fetch = 10,
            ComeHere = 5,
            Speak = 30,
            Mowienie = 31,
        }

        enum Wyliczanie2
        {
            Sit,
            Beg,
            RollOver,
            Fetch,
            ComeHere,
            Speak,
            Mowienie = 31,
        }


        Wyliczanie wynik = (Wyliczanie)30;//po wartosci 30 zwraca enum speak
        int wartosc = (int)Wyliczanie.Fetch;//Po indeksie Fetch zwraca wartosc 10

        public Form1()
        {
            InitializeComponent();    
            label1.Text = wynik.ToString();
            label1.Text += wartosc.ToString();





            richTextBox1.Text += ((int)Wyliczanie2.ComeHere).ToString();
            richTextBox1.Text+=("\n");

            richTextBox1.Text += Wyliczanie2.ComeHere.ToString();
            richTextBox1.Text += ("\n");


            Wyliczanie2 poIndeksie = (Wyliczanie2)31;
            richTextBox1.Text += poIndeksie.ToString();
        }

    }
}
