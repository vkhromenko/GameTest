namespace GameTest
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.rbMid = new System.Windows.Forms.RadioButton();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difficulty:";
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Checked = true;
            this.rbLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLow.Location = new System.Drawing.Point(47, 61);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(51, 21);
            this.rbLow.TabIndex = 1;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "Low";
            this.rbLow.UseVisualStyleBackColor = true;
            // 
            // rbMid
            // 
            this.rbMid.AutoSize = true;
            this.rbMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMid.Location = new System.Drawing.Point(47, 88);
            this.rbMid.Name = "rbMid";
            this.rbMid.Size = new System.Drawing.Size(67, 21);
            this.rbMid.TabIndex = 1;
            this.rbMid.Text = "Middle";
            this.rbMid.UseVisualStyleBackColor = true;
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHigh.Location = new System.Drawing.Point(47, 115);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(55, 21);
            this.rbHigh.TabIndex = 1;
            this.rbHigh.Text = "High";
            this.rbHigh.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(41, 171);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 206);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rbHigh);
            this.Controls.Add(this.rbMid);
            this.Controls.Add(this.rbLow);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.RadioButton rbMid;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.Button btnOk;
    }
}