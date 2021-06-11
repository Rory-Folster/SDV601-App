
namespace SDV601_App
{
    partial class mainForm
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
            this.addEditBtn = new System.Windows.Forms.Button();
            this.cashFlowTxt = new System.Windows.Forms.TextBox();
            this.vehicleListBox1 = new System.Windows.Forms.ListBox();
            this.vehicleListBox2 = new System.Windows.Forms.ListBox();
            this.vehicleListBox3 = new System.Windows.Forms.ListBox();
            this.vehicleExtendRichTxt = new System.Windows.Forms.RichTextBox();
            this.vehicleExtendExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addEditBtn
            // 
            this.addEditBtn.AccessibleName = "addEditBtn";
            this.addEditBtn.Location = new System.Drawing.Point(659, 49);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(237, 72);
            this.addEditBtn.TabIndex = 1;
            this.addEditBtn.Text = "Add/Edit Vehicle";
            this.addEditBtn.UseVisualStyleBackColor = true;
            this.addEditBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashFlowTxt
            // 
            this.cashFlowTxt.AccessibleName = "totalCashFlowTxtBox";
            this.cashFlowTxt.Location = new System.Drawing.Point(111, 463);
            this.cashFlowTxt.Name = "cashFlowTxt";
            this.cashFlowTxt.Size = new System.Drawing.Size(744, 22);
            this.cashFlowTxt.TabIndex = 2;
            this.cashFlowTxt.Text = "Total Cash Flow:   $230,987.93";
            this.cashFlowTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vehicleListBox1
            // 
            this.vehicleListBox1.AccessibleName = "mainListBox1";
            this.vehicleListBox1.FormattingEnabled = true;
            this.vehicleListBox1.ItemHeight = 16;
            this.vehicleListBox1.Items.AddRange(new object[] {
            "FHS134"});
            this.vehicleListBox1.Location = new System.Drawing.Point(80, 170);
            this.vehicleListBox1.Name = "vehicleListBox1";
            this.vehicleListBox1.Size = new System.Drawing.Size(225, 84);
            this.vehicleListBox1.TabIndex = 3;
            this.vehicleListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // vehicleListBox2
            // 
            this.vehicleListBox2.AccessibleName = "mainListBox2";
            this.vehicleListBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.vehicleListBox2.FormattingEnabled = true;
            this.vehicleListBox2.ItemHeight = 16;
            this.vehicleListBox2.Items.AddRange(new object[] {
            "YSL154"});
            this.vehicleListBox2.Location = new System.Drawing.Point(80, 253);
            this.vehicleListBox2.Name = "vehicleListBox2";
            this.vehicleListBox2.Size = new System.Drawing.Size(225, 84);
            this.vehicleListBox2.TabIndex = 5;
            this.vehicleListBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // vehicleListBox3
            // 
            this.vehicleListBox3.AccessibleName = "mainListBox3";
            this.vehicleListBox3.FormattingEnabled = true;
            this.vehicleListBox3.ItemHeight = 16;
            this.vehicleListBox3.Items.AddRange(new object[] {
            "SHR639"});
            this.vehicleListBox3.Location = new System.Drawing.Point(80, 336);
            this.vehicleListBox3.Name = "vehicleListBox3";
            this.vehicleListBox3.Size = new System.Drawing.Size(225, 84);
            this.vehicleListBox3.TabIndex = 6;
            // 
            // vehicleExtendRichTxt
            // 
            this.vehicleExtendRichTxt.Location = new System.Drawing.Point(425, 165);
            this.vehicleExtendRichTxt.Name = "vehicleExtendRichTxt";
            this.vehicleExtendRichTxt.Size = new System.Drawing.Size(489, 254);
            this.vehicleExtendRichTxt.TabIndex = 7;
            this.vehicleExtendRichTxt.Text = "Mazda \n2\n2020\n$13.94";
            this.vehicleExtendRichTxt.TextChanged += new System.EventHandler(this.vehicleExtendRichTxt_TextChanged);
            // 
            // vehicleExtendExitBtn
            // 
            this.vehicleExtendExitBtn.AccessibleName = "mainFormDeleteBtn";
            this.vehicleExtendExitBtn.BackColor = System.Drawing.Color.Red;
            this.vehicleExtendExitBtn.Location = new System.Drawing.Point(763, 375);
            this.vehicleExtendExitBtn.Name = "vehicleExtendExitBtn";
            this.vehicleExtendExitBtn.Size = new System.Drawing.Size(121, 31);
            this.vehicleExtendExitBtn.TabIndex = 8;
            this.vehicleExtendExitBtn.Text = "Delete Entry";
            this.vehicleExtendExitBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AccessibleName = "mainLabel";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "List of current vehicles";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleExtendExitBtn);
            this.Controls.Add(this.vehicleExtendRichTxt);
            this.Controls.Add(this.vehicleListBox3);
            this.Controls.Add(this.vehicleListBox2);
            this.Controls.Add(this.vehicleListBox1);
            this.Controls.Add(this.cashFlowTxt);
            this.Controls.Add(this.addEditBtn);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.TextBox cashFlowTxt;
        private System.Windows.Forms.ListBox vehicleListBox1;
        private System.Windows.Forms.ListBox vehicleListBox2;
        private System.Windows.Forms.ListBox vehicleListBox3;
        private System.Windows.Forms.RichTextBox vehicleExtendRichTxt;
        private System.Windows.Forms.Button vehicleExtendExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

