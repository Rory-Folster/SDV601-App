
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
            this.vehicleExtendRichTxt = new System.Windows.Forms.RichTextBox();
            this.vehicleExtendExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainFormQuitBtn = new System.Windows.Forms.Button();
            this.activityType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vehicleExtendSmallRichTxt1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEditBtn
            // 
            this.addEditBtn.AccessibleName = "addEditBtn";
            this.addEditBtn.Location = new System.Drawing.Point(494, 40);
            this.addEditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(178, 58);
            this.addEditBtn.TabIndex = 1;
            this.addEditBtn.Text = "Add/Edit Vehicle";
            this.addEditBtn.UseVisualStyleBackColor = true;
            this.addEditBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashFlowTxt
            // 
            this.cashFlowTxt.AccessibleName = "totalCashFlowTxtBox";
            this.cashFlowTxt.Location = new System.Drawing.Point(34, 375);
            this.cashFlowTxt.Margin = new System.Windows.Forms.Padding(2);
            this.cashFlowTxt.Name = "cashFlowTxt";
            this.cashFlowTxt.Size = new System.Drawing.Size(559, 20);
            this.cashFlowTxt.TabIndex = 2;
            this.cashFlowTxt.Text = "Total Cash Flow:   $230,987.93";
            this.cashFlowTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vehicleExtendRichTxt
            // 
            this.vehicleExtendRichTxt.Location = new System.Drawing.Point(319, 134);
            this.vehicleExtendRichTxt.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleExtendRichTxt.Name = "vehicleExtendRichTxt";
            this.vehicleExtendRichTxt.Size = new System.Drawing.Size(368, 207);
            this.vehicleExtendRichTxt.TabIndex = 7;
            this.vehicleExtendRichTxt.Text = " ";
            this.vehicleExtendRichTxt.TextChanged += new System.EventHandler(this.vehicleExtendRichTxt_TextChanged);
            // 
            // vehicleExtendExitBtn
            // 
            this.vehicleExtendExitBtn.AccessibleName = "mainFormDeleteBtn";
            this.vehicleExtendExitBtn.BackColor = System.Drawing.SystemColors.Window;
            this.vehicleExtendExitBtn.Location = new System.Drawing.Point(572, 305);
            this.vehicleExtendExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleExtendExitBtn.Name = "vehicleExtendExitBtn";
            this.vehicleExtendExitBtn.Size = new System.Drawing.Size(91, 25);
            this.vehicleExtendExitBtn.TabIndex = 8;
            this.vehicleExtendExitBtn.Text = "Delete Entry";
            this.vehicleExtendExitBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AccessibleName = "mainLabel";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "List of current vehicles";
            // 
            // mainFormQuitBtn
            // 
            this.mainFormQuitBtn.AccessibleName = "mainFormQuitBtn";
            this.mainFormQuitBtn.Location = new System.Drawing.Point(621, 358);
            this.mainFormQuitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mainFormQuitBtn.Name = "mainFormQuitBtn";
            this.mainFormQuitBtn.Size = new System.Drawing.Size(112, 54);
            this.mainFormQuitBtn.TabIndex = 11;
            this.mainFormQuitBtn.Text = "Quit";
            this.mainFormQuitBtn.UseVisualStyleBackColor = true;
            this.mainFormQuitBtn.Click += new System.EventHandler(this.mainFormQuitBtn_Click);
            // 
            // activityType
            // 
            this.activityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityType.FormattingEnabled = true;
            this.activityType.Location = new System.Drawing.Point(296, 60);
            this.activityType.Margin = new System.Windows.Forms.Padding(2);
            this.activityType.Name = "activityType";
            this.activityType.Size = new System.Drawing.Size(159, 21);
            this.activityType.TabIndex = 12;
            this.activityType.SelectedIndexChanged += new System.EventHandler(this.activityType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // vehicleExtendSmallRichTxt1
            // 
            this.vehicleExtendSmallRichTxt1.Location = new System.Drawing.Point(60, 101);
            this.vehicleExtendSmallRichTxt1.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleExtendSmallRichTxt1.Name = "vehicleExtendSmallRichTxt1";
            this.vehicleExtendSmallRichTxt1.Size = new System.Drawing.Size(170, 88);
            this.vehicleExtendSmallRichTxt1.TabIndex = 14;
            this.vehicleExtendSmallRichTxt1.Text = " ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(60, 200);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(170, 88);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = " ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.vehicleExtendSmallRichTxt1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activityType);
            this.Controls.Add(this.mainFormQuitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleExtendExitBtn);
            this.Controls.Add(this.vehicleExtendRichTxt);
            this.Controls.Add(this.cashFlowTxt);
            this.Controls.Add(this.addEditBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.TextBox cashFlowTxt;
        private System.Windows.Forms.RichTextBox vehicleExtendRichTxt;
        private System.Windows.Forms.Button vehicleExtendExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mainFormQuitBtn;
        private System.Windows.Forms.ComboBox activityType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox vehicleExtendSmallRichTxt1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

