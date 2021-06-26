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
    public partial class ViewEvent : Form
    {
        int eventId;
        public ViewEvent(int parEventId)
        {
            InitializeComponent();
            eventId = parEventId;
        }

        private void getEventData(SqlConnection parConnection)
        {
            
            string queryStr =
                "Select * From Event Where EventId =@ParEventId";
            SqlDataAdapter adapter = new SqlDataAdapter(queryStr, parConnection);//Binding method
            adapter.SelectCommand.Parameters.AddWithValue("@ParEventId", eventId);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Event");

            txtbEventName.DataBindings.Add("Text", ds, "Event.EventName");
            Binding b = txtbEventDate.DataBindings.Add("Text", ds, "Event.EventDate");
            b.FormatString = "d";
            b.FormattingEnabled = true;
            //textEventDate to format it to show only date no time.
            // do it with databinding


            //DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //dt.ToString("d");
            //txtbEventDate
            txtbLocation.DataBindings.Add("Text", ds, "Event.Location");
            txtbxEventManager.DataBindings.Add("Text", ds, "Event.Event Manager");
        }
        private void getDataforGrid(SqlConnection parConnection)
        {
            //

            //using (SqlCommand cmd = new SqlCommand("GetParticipants", parConnection)
            //{
                //cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter adapter = new SqlDataAdapter("GetParticipants", parConnection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@ParEventId", eventId);
                
                DataSet ds = new DataSet();
                adapter.Fill(ds, "GetParticipants");

                dataGridViewParticipants.DataSource = ds;
                dataGridViewParticipants.DataMember = "GetParticipants";

                dataGridViewParticipants.Columns["Amont"].DefaultCellStyle.Format = "C2";
            //}
        }

        private void ViewEvent_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Server=localhost;Initial Catalog=Gargar_management;Integrated Security=True;"))
            {
                connection.Open();
                getEventData(connection);
                getDataforGrid(connection);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
