namespace GGR_Foundation
{
    partial class NewEventEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtboxEventManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewSponsor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtboxLocation = new System.Windows.Forms.TextBox();
            this.txtboxEventName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ParticipantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typeofdonation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Event Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Event Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Location";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTEventDate);
            this.groupBox1.Controls.Add(this.txtboxEventManager);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNewSponsor);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtboxLocation);
            this.groupBox1.Controls.Add(this.txtboxEventName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 285);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event";
            // 
            // DTEventDate
            // 
            this.DTEventDate.Location = new System.Drawing.Point(129, 53);
            this.DTEventDate.Name = "DTEventDate";
            this.DTEventDate.Size = new System.Drawing.Size(200, 24);
            this.DTEventDate.TabIndex = 13;
            // 
            // txtboxEventManager
            // 
            this.txtboxEventManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEventManager.Location = new System.Drawing.Point(129, 147);
            this.txtboxEventManager.Name = "txtboxEventManager";
            this.txtboxEventManager.Size = new System.Drawing.Size(389, 31);
            this.txtboxEventManager.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Event  Manager";
            // 
            // btnNewSponsor
            // 
            this.btnNewSponsor.Location = new System.Drawing.Point(322, 231);
            this.btnNewSponsor.Name = "btnNewSponsor";
            this.btnNewSponsor.Size = new System.Drawing.Size(294, 41);
            this.btnNewSponsor.TabIndex = 10;
            this.btnNewSponsor.Text = "New Sponsor";
            this.btnNewSponsor.UseVisualStyleBackColor = true;
            this.btnNewSponsor.Click += new System.EventHandler(this.btnNewSponsor_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "New Subscriber";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtboxLocation
            // 
            this.txtboxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLocation.Location = new System.Drawing.Point(129, 86);
            this.txtboxLocation.Name = "txtboxLocation";
            this.txtboxLocation.Size = new System.Drawing.Size(389, 29);
            this.txtboxLocation.TabIndex = 3;
            // 
            // txtboxEventName
            // 
            this.txtboxEventName.Location = new System.Drawing.Point(129, 17);
            this.txtboxEventName.Name = "txtboxEventName";
            this.txtboxEventName.Size = new System.Drawing.Size(389, 24);
            this.txtboxEventName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(571, 667);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(718, 667);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(132, 43);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParticipantType,
            this.Fname,
            this.Lname,
            this.Address,
            this.Tel,
            this.Mobile,
            this.Town,
            this.Typeofdonation,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(8, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 340);
            this.dataGridView1.TabIndex = 18;
            // 
            // ParticipantType
            // 
            this.ParticipantType.HeaderText = "Participant Type";
            this.ParticipantType.Name = "ParticipantType";
            // 
            // Fname
            // 
            this.Fname.HeaderText = "First Name";
            this.Fname.Name = "Fname";
            // 
            // Lname
            // 
            this.Lname.HeaderText = "Last Name";
            this.Lname.Name = "Lname";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            // 
            // Mobile
            // 
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.Name = "Mobile";
            // 
            // Town
            // 
            this.Town.HeaderText = "Town";
            this.Town.Name = "Town";
            // 
            // Typeofdonation
            // 
            this.Typeofdonation.HeaderText = "Type of donation";
            this.Typeofdonation.Name = "Typeofdonation";
            // 
            // Amount
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 718);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EventForm";
            this.Text = "Event Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxLocation;
        private System.Windows.Forms.TextBox txtboxEventName;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNewSponsor;
        private System.Windows.Forms.TextBox txtboxEventManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTEventDate;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typeofdonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}

