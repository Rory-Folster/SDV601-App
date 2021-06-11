
namespace SDV601_App
{
    partial class addLog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "addLogDisplayTxt";
            this.textBox1.Location = new System.Drawing.Point(297, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Add a Vehicle Log";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.AccessibleName = "addLogsTypeTxtBox";
            this.textBox8.Location = new System.Drawing.Point(397, 188);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(152, 22);
            this.textBox8.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.AccessibleName = "addLogsDateTxtBox";
            this.textBox7.Location = new System.Drawing.Point(397, 237);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(152, 22);
            this.textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.AccessibleName = "addLogsCostOfHireTxtBox";
            this.textBox6.Location = new System.Drawing.Point(397, 287);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 22);
            this.textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "addLogsMakeTxtBox";
            this.textBox5.Location = new System.Drawing.Point(397, 142);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 22);
            this.textBox5.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.AccessibleName = "addLogsAddBtn";
            this.button1.Location = new System.Drawing.Point(297, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Log";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AccessibleName = "manageNameLabel";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AccessibleName = "manageNameLabel";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AccessibleName = "manageNameLabel";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AccessibleName = "manageNameLabel";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cost of Hire:";
            // 
            // addLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Name = "addLog";
            this.Text = "addLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}