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
    public partial class NewEventEntry : Form
    {
        public NewEventEntry()
        {
            InitializeComponent();
            //dataGridView1.Columns[8].CellTemplate.Style.Format = "£0.00";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int InsertEvent(SqlConnection connection) 
        {
            
            int eventId=-1;
            
            string queryInsertEvent =
                @"INSERT INTO Event (EventName, EventDate, Location, [Event manager]) 
                Values (@ParEventName, @ParEventDate, @ParLocation, @ParEventManager)";

            string queryIdentity = "Select @@Identity";
                                    
            //inserts event details to sql server event table.
            //create object command of class SqlCommand class.
            SqlCommand command = new SqlCommand(queryInsertEvent, connection);
            command.Parameters.AddWithValue("@ParEventName", txtboxEventName.Text);
            command.Parameters.AddWithValue("@ParEventDate", DTEventDate.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@ParLocation", txtboxLocation.Text);
            command.Parameters.AddWithValue("@ParEventManager", txtboxEventManager.Text);
            command.ExecuteNonQuery();  //executes and nothing to retun.

            // Gets last generated identity eventID from Identity table created automatically.
            command.CommandText = queryIdentity;
            command.Parameters.Clear();
            object result = command.ExecuteScalar();  //grabs the result from the query.
            //ExecuteScalar returned a scalar value on first column
            //of first row in the returned Result Set.
            if (result != null)
            {
                eventId = Convert.ToInt32(result);
            }
            return eventId;
        }
        private int InsertSubscriber(SqlConnection connection, DataGridViewRow row) 
        {
            int subsciberId = -1;

            string queryInsertSub =
            @"INSERT INTO Subscriber (FName, LName, Address, Tel, Mobile, Town)
            Values(@ParFName, @ParLName, @ParAddress, @ParTel, @ParMobile, @ParTown)";

            string subqueryIdentity = "Select @@Identity";
            SqlCommand command = new SqlCommand(queryInsertSub, connection);

            command.Parameters.AddWithValue("@ParFName", row.Cells[1].Value);
            command.Parameters.AddWithValue("@ParLName", row.Cells[2].Value);
            command.Parameters.AddWithValue("@ParAddress", row.Cells[3].Value);
            command.Parameters.AddWithValue("@ParTel", row.Cells[4].Value);
            command.Parameters.AddWithValue("@ParMobile", row.Cells[5].Value);
            command.Parameters.AddWithValue("@ParTown", row.Cells[6].Value);
            command.ExecuteNonQuery();

            //Get last generated Identity
            command.CommandText = subqueryIdentity;
            command.Parameters.Clear();
            object result = command.ExecuteScalar(); //Grabs the result from the query
            if (result != null) 
            {
                subsciberId = Convert.ToInt32(result);
            }
            return subsciberId;
        }
        private int InsertSponsor(SqlConnection connection, DataGridViewRow row) 
        {
            int sponsorId = -1;
            string queryInsertSpons =
                "Insert INTO Sponsor (SP_Fname, SP_LName, Address, Tel, Mobile, Town) " +
                "Values(@ParSP_FName, @ParSP_LName, @ParAddress, @ParTel, @ParMobile, @ParTown)";

            string spoQueryIdentity = "Select @@Identity";
            SqlCommand command = new SqlCommand(queryInsertSpons, connection);
            command.Parameters.AddWithValue("@ParSP_FName", row.Cells[1].Value);
            command.Parameters.AddWithValue("@ParSP_LName", row.Cells[2].Value);
            command.Parameters.AddWithValue("@ParAddress", row.Cells[3].Value);
            command.Parameters.AddWithValue("@ParTel", row.Cells[4].Value);
            command.Parameters.AddWithValue("@ParMobile", row.Cells[5].Value);
            command.Parameters.AddWithValue("@ParTown", row.Cells[6].Value);
            command.ExecuteNonQuery();

            command.CommandText = spoQueryIdentity;
            command.Parameters.Clear();

            object result = command.ExecuteScalar();
            if (result != null) 
            {
                sponsorId = Convert.ToInt32(result);
            }
            return sponsorId;
        }
        private void insertIntoSubscriber_Even(SqlConnection connection, int eventiD, int SubiD) 
        {

            string queryInsertSubEvent =
                @"insert into Subscriber_Event(SubscriberID, EventID)
			    Values(@ParSubiD, @PareventiD)";


            SqlCommand command = new SqlCommand(queryInsertSubEvent, connection);

            command.Parameters.AddWithValue("@PareventiD", eventiD);
            command.Parameters.AddWithValue("@ParSubiD", SubiD);
            command.ExecuteNonQuery();
        }


        private void InsertintoSponsor_Event(SqlConnection connection, int SponsorID, int EventID) 
        {
            string queryInsertSpEvent =
                @"Insert INTO Sponsor_Event (SponsorID, EventID) Values(@ParSponsorID, @ParEventID)";

            SqlCommand command = new SqlCommand(queryInsertSpEvent, connection);

            command.Parameters.AddWithValue("@ParSponsorID", SponsorID);
            command.Parameters.AddWithValue("@ParEventID", EventID);
            command.ExecuteNonQuery();

        }
        private void insertToDonationT(SqlConnection connection, DataGridViewRow row, int subscriberId, int eventId, int sponsorId ) 
        {
            string queryInsertDon =
                   @"INSERT INTO Donation([Type of Donation], Don_Date, Amont, SubscriberID, EventID, SponsorID) 
                   VALUES (@ParTypeOfDonation, @ParDon_Date, @ParAmont, @ParSubscriberID, @ParEventID, @ParsponsorId)";
            SqlCommand command = new SqlCommand( queryInsertDon, connection);
            
            command.Parameters.AddWithValue("@ParTypeOfDonation", row.Cells[7].Value);
            command.Parameters.AddWithValue("@ParDon_Date", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@ParAmont", row.Cells[8].Value);

            if (subscriberId == -1)
            {
                command.Parameters.AddWithValue("@ParSubscriberID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ParSubscriberID", subscriberId);
            }
            
            command.Parameters.AddWithValue("@ParEventID", eventId);
            if (sponsorId == -1)
            {
                command.Parameters.AddWithValue("@ParsponsorId", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ParsponsorId", sponsorId);
            }
            
            
            command.ExecuteNonQuery();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            //these will store the new generated ids
            int eventId;
        
            //create a new conenction object and pass sql server connecitn string
            using (SqlConnection connection = new SqlConnection("Server=localhost;Initial Catalog=Gargar_management;Integrated Security=True;"))
            {
                connection.Open();
                eventId = InsertEvent(connection);  //insert event details into sql server

                //loops the rows of the data grid
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    int subId =-1;
                    int spoId = -1;
                    //checks the first cell is subscirber or sponsor
                    if (row.Cells[0].Value.ToString() == "Subscriber") 
                    {
                        
                        //insert subscriber into sql server
                        subId = InsertSubscriber(connection, row);
                        insertIntoSubscriber_Even(connection, eventId, subId);

                    }
                    else 
                    {
                        //insert sponsor details into sql server.
                        spoId =InsertSponsor(connection, row);
                        InsertintoSponsor_Event(connection, spoId, eventId);

                        //Sponsor goes here
                    }
                    //insert event ponsor and subscriber details into sql server
                    insertToDonationT(connection, row, subId, eventId, spoId);
                }
            }
             txtboxEventName.Text = "";
             txtboxLocation.Text = "";
             txtboxEventManager.Text = "";
             Close();
  
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            (new CriteriaSearch()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Subscriber(this)).Show();  //passing the objecT of this form(Eventform)

        }

        private void btnNewSponsor_Click(object sender, EventArgs e)
        {
            (new Sponsor(this)).Show();
        }
    }
}
