
namespace SDV601_App
{
    partial class addingVehicle
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
            this.carRegoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitCarRegoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carRegoTxt
            // 
            this.carRegoTxt.Location = new System.Drawing.Point(414, 191);
            this.carRegoTxt.Name = "carRegoTxt";
            this.carRegoTxt.Size = new System.Drawing.Size(240, 22);
            this.carRegoTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter the car registration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add/Edit a vehicle entry";
            // 
            // submitCarRegoBtn
            // 
            this.submitCarRegoBtn.Location = new System.Drawing.Point(330, 323);
            this.submitCarRegoBtn.Name = "submitCarRegoBtn";
            this.submitCarRegoBtn.Size = new System.Drawing.Size(225, 63);
            this.submitCarRegoBtn.TabIndex = 5;
            this.submitCarRegoBtn.Text = "Enter remaining details";
            this.submitCarRegoBtn.UseVisualStyleBackColor = true;
            // 
            // addingVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 482);
            this.Controls.Add(this.submitCarRegoBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carRegoTxt);
            this.Name = "addingVehicle";
            this.Text = "addingVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox carRegoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitCarRegoBtn;
    }
}