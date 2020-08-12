using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()//odświeżenie formularza
        {
            JoeLabel.Text = joe.Name + " has $" + joe.Cash;
            BobLabel.Text = bob.Name + " has $" + bob.Cash;
            BankLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };
            bob = new Guy() { Cash = 100, Name = "Bob" };

            UpdateForm();
        }


        private void give10Joe_Click(object sender, EventArgs e)
        {
            if (bank >= 10)

            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            } else
            {
                MessageBox.Show("The bank has not enough money");
            }
        }

        private void receive5Bob_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();

        }

        private void joeBob10_Click(object sender, EventArgs e)//joe gives to bob
        {
            if (joe.Cash > 10)
            {
                // joe.GiveCash(10);
                // bob.ReceiveCash(10);
                bob.ReceiveCash(joe.GiveCash(10));
                UpdateForm();

            }
            else
            {
                MessageBox.Show("Joe doesnt have enough to give 10");
            }
        }

        private void bobJoe5_Click(object sender, EventArgs e)//bob gives to joe
        {
            if (bob.Cash > 5)
            {
                // bob.GiveCash(10);
                // joe.ReceiveCash(10);
                joe.ReceiveCash(bob.GiveCash(5));
                UpdateForm();

            }
            else
            {
                MessageBox.Show("Bob doesnt have enough to give 5");
            }
        }







        //SEIALIZATION:
        private void saveButton_Click(object sender, EventArgs e)   //ZAPIS
        {
            using (Stream output = File.Create("Guy_File.dat"))  //tworzenie pliku strumieniem
            {
                BinaryFormatter formatter = new BinaryFormatter();  //tworzenie BF
                formatter.Serialize(output, joe);   //zapis serializacją obiektu JOE poprzez formatter i parametr Streamu(output)
            }
        }

        private void loadButton_Click(object sender, EventArgs e)   //WCZYTANIE
        {
            using (Stream input = File.OpenRead("Guy_File.dat"))    //załadowanie pliku do strumienia
            {
                BinaryFormatter formatter = new BinaryFormatter();  //tworzenie BF
                joe = (Guy)formatter.Deserialize(input);    //deserializacja
            }
            UpdateForm();   //wywołanie odświeżenia

        }
    }
}

