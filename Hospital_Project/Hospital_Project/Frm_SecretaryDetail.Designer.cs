
namespace Hospital_Project
{
    partial class Frm_SecretaryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SecretaryDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.rtxtAnnouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnArrange = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.mskHour = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.mskPatientTC = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAppointmentList = new System.Windows.Forms.Button();
            this.btnBranchPanel = new System.Windows.Forms.Button();
            this.btnDoctorPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Info";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(169, 106);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(88, 26);
            this.LblNameSurname.TabIndex = 4;
            this.LblNameSurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(169, 68);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(133, 26);
            this.LblTC.TabIndex = 2;
            this.LblTC.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnnouncement);
            this.groupBox2.Controls.Add(this.rtxtAnnouncement);
            this.groupBox2.Location = new System.Drawing.Point(2, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 207);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Announcement";
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.Location = new System.Drawing.Point(6, 157);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(296, 44);
            this.btnAnnouncement.TabIndex = 1;
            this.btnAnnouncement.Text = "Make an announcement";
            this.btnAnnouncement.UseVisualStyleBackColor = true;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click_1);
            // 
            // rtxtAnnouncement
            // 
            this.rtxtAnnouncement.Location = new System.Drawing.Point(6, 32);
            this.rtxtAnnouncement.Name = "rtxtAnnouncement";
            this.rtxtAnnouncement.Size = new System.Drawing.Size(296, 119);
            this.rtxtAnnouncement.TabIndex = 0;
            this.rtxtAnnouncement.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnArrange);
            this.groupBox3.Controls.Add(this.chkStatus);
            this.groupBox3.Controls.Add(this.mskHour);
            this.groupBox3.Controls.Add(this.mskDate);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Controls.Add(this.cmbBranch);
            this.groupBox3.Controls.Add(this.mskPatientTC);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(317, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 392);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(122, 314);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(135, 57);
            this.btnArrange.TabIndex = 5;
            this.btnArrange.Text = "Arrange";
            this.btnArrange.UseVisualStyleBackColor = true;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(122, 267);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(86, 30);
            this.chkStatus.TabIndex = 13;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // mskHour
            // 
            this.mskHour.Location = new System.Drawing.Point(122, 228);
            this.mskHour.Mask = "00:00";
            this.mskHour.Name = "mskHour";
            this.mskHour.Size = new System.Drawing.Size(135, 33);
            this.mskHour.TabIndex = 12;
            this.mskHour.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(122, 189);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(135, 33);
            this.mskDate.TabIndex = 11;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(122, 149);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(135, 34);
            this.cmbDoctor.TabIndex = 10;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(122, 109);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(135, 34);
            this.cmbBranch.TabIndex = 9;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // mskPatientTC
            // 
            this.mskPatientTC.Location = new System.Drawing.Point(122, 70);
            this.mskPatientTC.Mask = "00000000000";
            this.mskPatientTC.Name = "mskPatientTC";
            this.mskPatientTC.Size = new System.Drawing.Size(135, 33);
            this.mskPatientTC.TabIndex = 8;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(122, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(135, 33);
            this.txtid.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Patient TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doctor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(607, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 261);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branches";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(287, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(607, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(293, 258);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(287, 226);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnAppointmentList);
            this.groupBox6.Controls.Add(this.btnBranchPanel);
            this.groupBox6.Controls.Add(this.btnDoctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(2, 400);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(599, 124);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quick Access";
            // 
            // btnAppointmentList
            // 
            this.btnAppointmentList.Location = new System.Drawing.Point(304, 32);
            this.btnAppointmentList.Name = "btnAppointmentList";
            this.btnAppointmentList.Size = new System.Drawing.Size(136, 70);
            this.btnAppointmentList.TabIndex = 3;
            this.btnAppointmentList.Text = "Appointment List";
            this.btnAppointmentList.UseVisualStyleBackColor = true;
            this.btnAppointmentList.Click += new System.EventHandler(this.btnAppointmentList_Click);
            // 
            // btnBranchPanel
            // 
            this.btnBranchPanel.Location = new System.Drawing.Point(162, 32);
            this.btnBranchPanel.Name = "btnBranchPanel";
            this.btnBranchPanel.Size = new System.Drawing.Size(136, 70);
            this.btnBranchPanel.TabIndex = 2;
            this.btnBranchPanel.Text = "Branch Panel";
            this.btnBranchPanel.UseVisualStyleBackColor = true;
            this.btnBranchPanel.Click += new System.EventHandler(this.btnBranchPanel_Click);
            // 
            // btnDoctorPanel
            // 
            this.btnDoctorPanel.Location = new System.Drawing.Point(20, 32);
            this.btnDoctorPanel.Name = "btnDoctorPanel";
            this.btnDoctorPanel.Size = new System.Drawing.Size(136, 70);
            this.btnDoctorPanel.TabIndex = 1;
            this.btnDoctorPanel.Text = "Doctor Panel";
            this.btnDoctorPanel.UseVisualStyleBackColor = true;
            this.btnDoctorPanel.Click += new System.EventHandler(this.btnDoctorPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Announcement List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_SecretaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(912, 536);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_SecretaryDetail";
            this.Text = "SecretaryDetail";
            this.Load += new System.EventHandler(this.Frm_SecretaryDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAnnouncement;
        private System.Windows.Forms.RichTextBox rtxtAnnouncement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.MaskedTextBox mskHour;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.MaskedTextBox mskPatientTC;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAppointmentList;
        private System.Windows.Forms.Button btnBranchPanel;
        private System.Windows.Forms.Button btnDoctorPanel;
        private System.Windows.Forms.Button button1;
    }
}