namespace SmartHS
{
    partial class TechSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechSupport));
            this.gbAllocation = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.cmbUnassigned = new System.Windows.Forms.ComboBox();
            this.txtTechnicianName = new System.Windows.Forms.TextBox();
            this.cmbTechnicians = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtbJobInformtion = new System.Windows.Forms.RichTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbAllocation.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAllocation
            // 
            this.gbAllocation.Controls.Add(this.txtType);
            this.gbAllocation.Controls.Add(this.cmbUnassigned);
            this.gbAllocation.Controls.Add(this.txtTechnicianName);
            this.gbAllocation.Controls.Add(this.cmbTechnicians);
            this.gbAllocation.Controls.Add(this.btnAssign);
            this.gbAllocation.Controls.Add(this.rtbDescription);
            this.gbAllocation.Controls.Add(this.label5);
            this.gbAllocation.Controls.Add(this.label4);
            this.gbAllocation.Controls.Add(this.label3);
            this.gbAllocation.Controls.Add(this.label2);
            this.gbAllocation.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gbAllocation.ForeColor = System.Drawing.Color.White;
            this.gbAllocation.Location = new System.Drawing.Point(12, 57);
            this.gbAllocation.Name = "gbAllocation";
            this.gbAllocation.Size = new System.Drawing.Size(467, 331);
            this.gbAllocation.TabIndex = 0;
            this.gbAllocation.TabStop = false;
            this.gbAllocation.Text = "Job Allocation";
            this.gbAllocation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.Location = new System.Drawing.Point(121, 115);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(314, 24);
            this.txtType.TabIndex = 17;
            // 
            // cmbUnassigned
            // 
            this.cmbUnassigned.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbUnassigned.ForeColor = System.Drawing.Color.Black;
            this.cmbUnassigned.FormattingEnabled = true;
            this.cmbUnassigned.Location = new System.Drawing.Point(121, 32);
            this.cmbUnassigned.Name = "cmbUnassigned";
            this.cmbUnassigned.Size = new System.Drawing.Size(314, 25);
            this.cmbUnassigned.TabIndex = 16;
            this.cmbUnassigned.SelectedIndexChanged += new System.EventHandler(this.cmbUnassigned_SelectedIndexChanged);
            // 
            // txtTechnicianName
            // 
            this.txtTechnicianName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTechnicianName.ForeColor = System.Drawing.Color.Black;
            this.txtTechnicianName.Location = new System.Drawing.Point(238, 73);
            this.txtTechnicianName.Name = "txtTechnicianName";
            this.txtTechnicianName.Size = new System.Drawing.Size(197, 24);
            this.txtTechnicianName.TabIndex = 15;
            // 
            // cmbTechnicians
            // 
            this.cmbTechnicians.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbTechnicians.ForeColor = System.Drawing.Color.Black;
            this.cmbTechnicians.FormattingEnabled = true;
            this.cmbTechnicians.Location = new System.Drawing.Point(121, 73);
            this.cmbTechnicians.Name = "cmbTechnicians";
            this.cmbTechnicians.Size = new System.Drawing.Size(111, 25);
            this.cmbTechnicians.TabIndex = 14;
            this.cmbTechnicians.SelectedIndexChanged += new System.EventHandler(this.cmbTechnicians_SelectedIndexChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Transparent;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(42, 279);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(386, 34);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Assign Job";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rtbDescription.ForeColor = System.Drawing.Color.Black;
            this.rtbDescription.Location = new System.Drawing.Point(121, 157);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(314, 97);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Job Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Assign To :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unassigned Job:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.btnChange);
            this.gbStatus.Controls.Add(this.btnSearch);
            this.gbStatus.Controls.Add(this.rtbJobInformtion);
            this.gbStatus.Controls.Add(this.cmbStatus);
            this.gbStatus.Controls.Add(this.label7);
            this.gbStatus.Controls.Add(this.txtSearch);
            this.gbStatus.Controls.Add(this.label6);
            this.gbStatus.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(506, 57);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(383, 331);
            this.gbStatus.TabIndex = 9;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Job Status";
            this.gbStatus.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(29, 279);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(337, 34);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change Status";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(291, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtbJobInformtion
            // 
            this.rtbJobInformtion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rtbJobInformtion.ForeColor = System.Drawing.Color.Black;
            this.rtbJobInformtion.Location = new System.Drawing.Point(106, 74);
            this.rtbJobInformtion.Name = "rtbJobInformtion";
            this.rtbJobInformtion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbJobInformtion.Size = new System.Drawing.Size(260, 140);
            this.rtbJobInformtion.TabIndex = 10;
            this.rtbJobInformtion.Text = "";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(106, 233);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(260, 25);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Status  :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(106, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 24);
            this.txtSearch.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Job ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Technical Support";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(235, 410);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(502, 37);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View Existing Jobs";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 495);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(900, 10);
            this.pnlBottom.TabIndex = 14;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(900, 35);
            this.pnlTop.TabIndex = 15;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Location = new System.Drawing.Point(828, -17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 54);
            this.btnMinimize.TabIndex = 24;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(864, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 33);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // TechSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 505);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbAllocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TechSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechSupport";
            this.Load += new System.EventHandler(this.TechSupport_Load);
            this.gbAllocation.ResumeLayout(false);
            this.gbAllocation.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAllocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbJobInformtion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtTechnicianName;
        private System.Windows.Forms.ComboBox cmbTechnicians;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.ComboBox cmbUnassigned;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
    }
}