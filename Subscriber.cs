using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGR_Foundation
{
    public partial class Subscriber : Form
    {
        NewEventEntry parentForm;  //creating parentForm var of type EventForm

        public Subscriber(NewEventEntry parParentForm)  //creating a parParentForm of EventForm 
        {
            InitializeComponent();
            parentForm = parParentForm;  // assigning the parameter parParentForm to the var parentForm


        }

        private void frmSBbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = parentForm.dataGridView1.Rows.Add();
            parentForm.dataGridView1.Rows[index].Cells[0].Value = "Subscriber";
            parentForm.dataGridView1.Rows[index].Cells[1].Value = SUFName.Text;
            parentForm.dataGridView1.Rows[index].Cells[2].Value = SULName.Text;
            parentForm.dataGridView1.Rows[index].Cells[3].Value = SUFAddress.Text;
            parentForm.dataGridView1.Rows[index].Cells[4].Value = SUTel.Text;
            parentForm.dataGridView1.Rows[index].Cells[5].Value = SUMobile.Text;
            parentForm.dataGridView1.Rows[index].Cells[6].Value = SUTown.Text;
            parentForm.dataGridView1.Rows[index].Cells[7].Value = txtboxTypeofdonation.Text;
            parentForm.dataGridView1.Rows[index].Cells[8].Value = double.Parse(SUAmount.Text);


            //parentForm.dataGridView1.Rows.Add(new string[] {"Subscriber", "", SUFName.Text, SULName.Text, SUFAddress.Text, SUTel.Text, SUMobile.Text, SUTown.Text,  SUAmount.Text});



            this.Close();
        }

        private void Subscriber_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialogue = MessageBox.Show("Do you really want to exit?", "Exit Window", MessageBoxButtons.YesNo);
            if (dialogue == DialogResult.Yes)
            {
                //Application.Exit();
                //this.Close();
            }
            else if (dialogue == DialogResult.No)
            {
                //(new Subscriber()).Show()
                e.Cancel = true;

            }
            
        }
    }
}
