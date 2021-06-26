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

namespace GGR_Foundation
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            (new NewEventEntry()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new SearchForm()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getEventfromTable(SqlConnection connection)
        {
            string queryStr =
              "Select Top 50  EventID, EventName, EventDate, Location, [Event manager]" +
                " From Event Order By EventDate Desc";

            //SqlCommand command = new SqlCommand(queryStr, connection);
            //Databiding
            SqlDataAdapter adapter = new SqlDataAdapter(queryStr, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Event"); //pass parameters ds and Event to the adapter
            dataGridViewEvent.DataSource = ds; //assign the dataset to the source
            dataGridViewEvent.DataMember = "Event"; //assign the table Event to the datagrid.   

             
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //create a new conenction object and pass sql server connection string
            
            using (SqlConnection connection = new SqlConnection("Server=localhost;Initial Catalog=Gargar_management;Integrated Security=True;"))
            {
                connection.Open();
                getEventfromTable(connection);
            }
        }

        private void dataGridViewEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e is the information of the cell, it contains the row index and cell index.
            //e 
            if (e.ColumnIndex == 0)
            {
                object cellValue = dataGridViewEvent.Rows[e.RowIndex].Cells["EventID"].Value;
                
                int iD = Convert.ToInt32(cellValue);
                ViewEvent viewEvent = new ViewEvent(iD);
                viewEvent.Show(); 
             }

        }
    }
}
