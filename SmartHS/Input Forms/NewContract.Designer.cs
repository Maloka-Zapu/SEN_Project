namespace SmartHS
{
    partial class NewContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewContract));
            this.label1 = new System.Windows.Forms.Label();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rdStandard = new System.Windows.Forms.RadioButton();
            this.cmbServiceLevels = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpProductInfo = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudConvieManagement = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudSafetyManagement = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudEnergyManagement = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbInformation.SuspendLayout();
            this.gbProducts.SuspendLayout();
            this.gpProductInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvieManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafetyManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnergyManagement)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.btnSearch);
            this.gbInformation.Controls.Add(this.txtSurname);
            this.gbInformation.Controls.Add(this.txtName);
            this.gbInformation.Controls.Add(this.txtCustomerID);
            this.gbInformation.Controls.Add(this.label2);
            this.gbInformation.Controls.Add(this.label3);
            this.gbInformation.Controls.Add(this.label1);
            this.gbInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformation.ForeColor = System.Drawing.Color.White;
            this.gbInformation.Location = new System.Drawing.Point(27, 56);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(353, 173);
            this.gbInformation.TabIndex = 1;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Customer Information";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(22, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(304, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(116, 101);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(210, 24);
            this.txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(116, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 24);
            this.txtName.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCustomerID.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerID.Location = new System.Drawing.Point(116, 32);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(210, 24);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname :";
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.rbPremium);
            this.gbProducts.Controls.Add(this.rdStandard);
            this.gbProducts.Controls.Add(this.cmbServiceLevels);
            this.gbProducts.Controls.Add(this.label6);
            this.gbProducts.Controls.Add(this.label5);
            this.gbProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducts.ForeColor = System.Drawing.Color.White;
            this.gbProducts.Location = new System.Drawing.Point(27, 235);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(353, 127);
            this.gbProducts.TabIndex = 2;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Products And Services";
            this.gbProducts.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.BackColor = System.Drawing.Color.Transparent;
            this.rbPremium.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPremium.ForeColor = System.Drawing.Color.White;
            this.rbPremium.Location = new System.Drawing.Point(241, 45);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(83, 21);
            this.rbPremium.TabIndex = 8;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = false;
            this.rbPremium.CheckedChanged += new System.EventHandler(this.rbPremium_CheckedChanged);
            // 
            // rdStandard
            // 
            this.rdStandard.AutoSize = true;
            this.rdStandard.BackColor = System.Drawing.Color.Transparent;
            this.rdStandard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdStandard.ForeColor = System.Drawing.Color.White;
            this.rdStandard.Location = new System.Drawing.Point(155, 45);
            this.rdStandard.Name = "rdStandard";
            this.rdStandard.Size = new System.Drawing.Size(85, 21);
            this.rdStandard.TabIndex = 7;
            this.rdStandard.TabStop = true;
            this.rdStandard.Text = "Standard";
            this.rdStandard.UseVisualStyleBackColor = false;
            this.rdStandard.CheckedChanged += new System.EventHandler(this.rdStandard_CheckedChanged);
            // 
            // cmbServiceLevels
            // 
            this.cmbServiceLevels.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceLevels.ForeColor = System.Drawing.Color.Black;
            this.cmbServiceLevels.FormattingEnabled = true;
            this.cmbServiceLevels.Items.AddRange(new object[] {
            "Customer-Based",
            "Service-Based",
            "Corparate-Based",
            "Multilevel"});
            this.cmbServiceLevels.Location = new System.Drawing.Point(145, 80);
            this.cmbServiceLevels.Name = "cmbServiceLevels";
            this.cmbServiceLevels.Size = new System.Drawing.Size(193, 25);
            this.cmbServiceLevels.TabIndex = 5;
            this.cmbServiceLevels.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Service Levels:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Upgrade Options:";
            // 
            // gpProductInfo
            // 
            this.gpProductInfo.Controls.Add(this.panel3);
            this.gpProductInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpProductInfo.ForeColor = System.Drawing.Color.White;
            this.gpProductInfo.Location = new System.Drawing.Point(403, 56);
            this.gpProductInfo.Name = "gpProductInfo";
            this.gpProductInfo.Size = new System.Drawing.Size(470, 244);
            this.gpProductInfo.TabIndex = 4;
            this.gpProductInfo.TabStop = false;
            this.gpProductInfo.Text = "Product Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.nudConvieManagement);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.nudSafetyManagement);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.nudEnergyManagement);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(32, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 154);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // nudConvieManagement
            // 
            this.nudConvieManagement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudConvieManagement.Location = new System.Drawing.Point(284, 95);
            this.nudConvieManagement.Name = "nudConvieManagement";
            this.nudConvieManagement.Size = new System.Drawing.Size(67, 23);
            this.nudConvieManagement.TabIndex = 12;
            this.nudConvieManagement.ValueChanged += new System.EventHandler(this.nudConvieManagement_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Home Convenience Management System:";
            // 
            // nudSafetyManagement
            // 
            this.nudSafetyManagement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSafetyManagement.Location = new System.Drawing.Point(284, 67);
            this.nudSafetyManagement.Name = "nudSafetyManagement";
            this.nudSafetyManagement.Size = new System.Drawing.Size(67, 23);
            this.nudSafetyManagement.TabIndex = 10;
            this.nudSafetyManagement.ValueChanged += new System.EventHandler(this.nudSafetyManagement_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(52, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Home Safety Management System:";
            // 
            // nudEnergyManagement
            // 
            this.nudEnergyManagement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEnergyManagement.Location = new System.Drawing.Point(284, 37);
            this.nudEnergyManagement.Name = "nudEnergyManagement";
            this.nudEnergyManagement.Size = new System.Drawing.Size(67, 23);
            this.nudEnergyManagement.TabIndex = 8;
            this.nudEnergyManagement.ValueChanged += new System.EventHandler(this.nudEnergyManagement_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(52, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Home Energy Management System:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Transparent;
            this.btnGenerate.Location = new System.Drawing.Point(403, 323);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(204, 39);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate Contract ID";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "New Contract";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(679, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Contract";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 409);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(904, 10);
            this.pnlBottom.TabIndex = 10;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(904, 35);
            this.pnlTop.TabIndex = 11;
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
            this.btnMinimize.Location = new System.Drawing.Point(827, -17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 54);
            this.btnMinimize.TabIndex = 18;
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
            this.btnClose.Location = new System.Drawing.Point(863, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 33);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // NewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 419);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gpProductInfo);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.gbInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewContract";
            this.Load += new System.EventHandler(this.NewContract_Load);
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.gpProductInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvieManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafetyManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnergyManagement)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.ComboBox cmbServiceLevels;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpProductInfo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rdStandard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudConvieManagement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudSafetyManagement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudEnergyManagement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
    }
}