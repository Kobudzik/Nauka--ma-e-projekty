using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsWithDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          


        private void Form1_Load(object sender, EventArgs e)
        {
            loadList();
        }


        //********************BUTTONS****************************

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEntryToDB();
        }
      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteEntryFromDB();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEntryInDB();
        }


        ///////////********************BUTTONS*****************









        //********************Methods****************************

        private void loadList()
        {
            //create connection string
            string connectionString = Properties.Settings.Default.dcCarsConnectionString;

            //define connection
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //connect if not connected
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            //define commands
            string sqlSelectCommand = "SELECT * from tbl_Cars";

            //define DataTable
            DataTable table = new DataTable();

            //define SQLadapter
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelectCommand, sqlConnection);
            adapter.Fill(table);

            lstCars.DisplayMember = "Car";
            lstCars.ValueMember = "IDCar";


            lstCars.DataSource = table;
        }

        private void addEntryToDB()
        {
            //create connection string
            string connectionString = Properties.Settings.Default.dcCarsConnectionString;

            //define connection
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //connect if not connected
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            //define command strings
            string sqlTextSelectCommand = "INSERT INTO tbl_Cars ([Car]) values ('" + txbInput.Text + "')";

            //defin command execution
            SqlCommand sqlCommand = new SqlCommand(sqlTextSelectCommand, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            loadList();
        }


        private void deleteEntryFromDB()
        {
            //create connection string
            string connectionString = Properties.Settings.Default.dcCarsConnectionString;

            //define connection
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //connect if not connected
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            //take selected row
            DataRowView selectedRow = lstCars.SelectedItem as DataRowView;
            //take car ID
            string CarID = selectedRow["IDCar"].ToString();


            //define command strings
            string sqlTextDeleteCommand = "DELETE FROM tbl_Cars WHERE (IDCar=" + CarID + ")";

            //defin command execution
            SqlCommand sqlCommand = new SqlCommand(sqlTextDeleteCommand, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            //reload list
            loadList();
        }

        private void updateEntryInDB()
        {
            //create connection string
            string connectionString = Properties.Settings.Default.dcCarsConnectionString;

            //define connection
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //connect if not connected
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            //take selected row
            DataRowView selectedRow = lstCars.SelectedItem as DataRowView;
            //take car ID
            string CarID = selectedRow["IDCar"].ToString();


            //define command strings
            string sqlTextUpdateCommand = "UPDATE tbl_Cars SET [Car]='" + txbInput.Text + "' WHERE IDCar=" + CarID;

            //defin command execution
            SqlCommand sqlCommand = new SqlCommand(sqlTextUpdateCommand, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            //reload list
            loadList();

        }



        ///**********************************Methods*****************


        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //take selected row
            DataRowView selectedRow = lstCars.SelectedItem as DataRowView;
            //refresh selected car name to the input
            txbInput.Text = selectedRow["Car"].ToString();
        }



    }
}
