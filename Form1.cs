using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDBTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.formsDBTwoDataSet);

        }

        //Fetch data if data fill object fails
        private void GetCityData() 
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CityData", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();

            //Read into the table
            SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlConnection.Close();

            //Send to the gridview
            cityDataDataGridView.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formsDBTwoDataSet.CityData' table. You can move, or remove it, as needed.
            //Fill form when the program runs
            //this.cityDataTableAdapter.Fill(this.formsDBTwoDataSet.CityData);
            GetCityData();

        }

        //Static connection to the db
        SqlConnection sqlConnection = new SqlConnection("Data Source = lab000000\\SQLEXPRESS; Initial Catalog = FormsDBTwo; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            city_nameTextBox.Clear();
            minTextBox.Clear();
            maxTextBox.Clear();
            windTextBox.Clear();
        }
    }
}
