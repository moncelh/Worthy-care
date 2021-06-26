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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search(SqlConnection connection, string EventName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("pc_SearchResult", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parEventName", EventName);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "EventResult");
            //EventResukt is a made up is a datamember that refers to the data of dataset
            //you can make many datamember for dataset, but for this case refers to ds.
            dataGridViewSearchform.DataSource = ds;
            dataGridViewSearchform.DataMember = "EventResult";

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Initial Catalog=Gargar_management;Integrated Security=True;"))
            {
                conn.Open();
                Search(conn, txtbEventName.Text);
                txtNbRecords.Text = dataGridViewSearchform.Rows.Count.ToString();
            }
                

        }
    }
}
