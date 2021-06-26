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
    public partial class Sponsor : Form
    {
        NewEventEntry parentForm;
        public Sponsor(NewEventEntry ParParentForm)
        {
            InitializeComponent();
            parentForm = ParParentForm;
            
        }

        private void frmSPNbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSPNbtnOK_Click(object sender, EventArgs e)
        {
            int index = parentForm.dataGridView1.Rows.Add();
            parentForm.dataGridView1.Rows[index].Cells[0].Value = "Sponsor";
            parentForm.dataGridView1.Rows[index].Cells[1].Value = SPFName.Text;
            parentForm.dataGridView1.Rows[index].Cells[2].Value = SPLName.Text;
            parentForm.dataGridView1.Rows[index].Cells[3].Value = SPAddress.Text;
            parentForm.dataGridView1.Rows[index].Cells[4].Value = SPTel.Text;
            parentForm.dataGridView1.Rows[index].Cells[5].Value = SPMobile.Text;
            parentForm.dataGridView1.Rows[index].Cells[6].Value = SPTwon.Text;
            parentForm.dataGridView1.Rows[index].Cells[7].Value = txtboxTypeofdonation.Text;
            parentForm.dataGridView1.Rows[index].Cells[8].Value = double.Parse(SPAmount.Text);

            Close();
            
        }
    }
}
