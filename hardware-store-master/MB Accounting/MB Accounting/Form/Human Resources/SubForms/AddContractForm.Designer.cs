
namespace MB_Accounting
{
    partial class AddContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContractForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new MB_Accounting.RoundButton();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpires = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.nFte = new System.Windows.Forms.NumericUpDown();
            this.cbxTemporary = new System.Windows.Forms.CheckBox();
            this.lblFte = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 65);
            this.lblTitle.TabIndex = 77;
            this.lblTitle.Text = "Add a new contract";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Active1 = System.Drawing.Color.HotPink;
            this.btnAdd.Active2 = System.Drawing.Color.HotPink;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Inactive1 = System.Drawing.Color.HotPink;
            this.btnAdd.Inactive2 = System.Drawing.Color.HotPink;
            this.btnAdd.Location = new System.Drawing.Point(228, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 28;
            this.btnAdd.Size = new System.Drawing.Size(258, 56);
            this.btnAdd.Stroke = false;
            this.btnAdd.StrokeColor = System.Drawing.Color.Gray;
            this.btnAdd.TabIndex = 76;
            this.btnAdd.Text = "Add";
            this.btnAdd.Transparency = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpExpirationDate.Location = new System.Drawing.Point(236, 219);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(250, 32);
            this.dtpExpirationDate.TabIndex = 75;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpStartDate.Location = new System.Drawing.Point(236, 161);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 32);
            this.dtpStartDate.TabIndex = 74;
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.BackColor = System.Drawing.Color.Transparent;
            this.lblExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpires.ForeColor = System.Drawing.Color.SlateGray;
            this.lblExpires.Location = new System.Drawing.Point(48, 219);
            this.lblExpires.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(100, 29);
            this.lblExpires.TabIndex = 73;
            this.lblExpires.Text = "Expires:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.SlateGray;
            this.lblStartDate.Location = new System.Drawing.Point(48, 164);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(130, 29);
            this.lblStartDate.TabIndex = 72;
            this.lblStartDate.Text = "Start Date: ";
            // 
            // nFte
            // 
            this.nFte.DecimalPlaces = 1;
            this.nFte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFte.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nFte.Location = new System.Drawing.Point(236, 112);
            this.nFte.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFte.Name = "nFte";
            this.nFte.Size = new System.Drawing.Size(250, 31);
            this.nFte.TabIndex = 71;
            this.nFte.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // cbxTemporary
            // 
            this.cbxTemporary.AutoSize = true;
            this.cbxTemporary.Checked = true;
            this.cbxTemporary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTemporary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTemporary.Location = new System.Drawing.Point(236, 257);
            this.cbxTemporary.Name = "cbxTemporary";
            this.cbxTemporary.Size = new System.Drawing.Size(134, 29);
            this.cbxTemporary.TabIndex = 70;
            this.cbxTemporary.Text = "Temporary";
            this.cbxTemporary.UseVisualStyleBackColor = true;
            this.cbxTemporary.CheckedChanged += new System.EventHandler(this.cbxTemporary_CheckedChanged);
            // 
            // lblFte
            // 
            this.lblFte.AutoSize = true;
            this.lblFte.BackColor = System.Drawing.Color.Transparent;
            this.lblFte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFte.ForeColor = System.Drawing.Color.SlateGray;
            this.lblFte.Location = new System.Drawing.Point(48, 111);
            this.lblFte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFte.Name = "lblFte";
            this.lblFte.Size = new System.Drawing.Size(66, 29);
            this.lblFte.TabIndex = 69;
            this.lblFte.Text = "FTE:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.SlateGray;
            this.lblSalary.Location = new System.Drawing.Point(45, 293);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(86, 29);
            this.lblSalary.TabIndex = 79;
            this.lblSalary.Text = "Salary:";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalary.Location = new System.Drawing.Point(236, 293);
            this.tbxSalary.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(250, 31);
            this.tbxSalary.TabIndex = 78;
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 422);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblExpires);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.nFte);
            this.Controls.Add(this.cbxTemporary);
            this.Controls.Add(this.lblFte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContractForm";
            this.Text = "Media Bazaar Accounting - Add Contract";
            ((System.ComponentModel.ISupportInitialize)(this.nFte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private RoundButton btnAdd;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblExpires;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.NumericUpDown nFte;
        private System.Windows.Forms.CheckBox cbxTemporary;
        private System.Windows.Forms.Label lblFte;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox tbxSalary;
    }
}