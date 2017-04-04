﻿namespace GameTest
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrev = new System.Windows.Forms.Panel();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbMid = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(1, 1);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(373, 622);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore.Location = new System.Drawing.Point(401, 32);
            this.lbScore.MinimumSize = new System.Drawing.Size(60, 39);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(60, 39);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(398, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            // 
            // pnPrev
            // 
            this.pnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPrev.Location = new System.Drawing.Point(380, 122);
            this.pnPrev.Name = "pnPrev";
            this.pnPrev.Size = new System.Drawing.Size(112, 121);
            this.pnPrev.TabIndex = 3;
            // 
            // rbHigh
            // 
            this.rbHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(390, 334);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(47, 17);
            this.rbHigh.TabIndex = 4;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "High";
            this.rbHigh.UseVisualStyleBackColor = true;
            // 
            // rbMid
            // 
            this.rbMid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMid.AutoSize = true;
            this.rbMid.Location = new System.Drawing.Point(390, 311);
            this.rbMid.Name = "rbMid";
            this.rbMid.Size = new System.Drawing.Size(56, 17);
            this.rbMid.TabIndex = 4;
            this.rbMid.TabStop = true;
            this.rbMid.Text = "Middle";
            this.rbMid.UseVisualStyleBackColor = true;
            // 
            // rbLow
            // 
            this.rbLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(390, 288);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(45, 17);
            this.rbLow.TabIndex = 4;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "Low";
            this.rbLow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(386, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Difficulty";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbLow);
            this.Controls.Add(this.rbMid);
            this.Controls.Add(this.rbHigh);
            this.Controls.Add(this.pnPrev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPrev;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbMid;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.Label label2;
    }
}

