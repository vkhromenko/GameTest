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
            this.gbDif = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.gbDif.SuspendLayout();
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
            this.lbScore.Location = new System.Drawing.Point(397, 40);
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
            this.label1.Location = new System.Drawing.Point(396, 14);
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
            this.rbHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHigh.Location = new System.Drawing.Point(6, 81);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(55, 21);
            this.rbHigh.TabIndex = 4;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "High";
            this.rbHigh.UseVisualStyleBackColor = true;
            this.rbHigh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            // 
            // rbMid
            // 
            this.rbMid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMid.AutoSize = true;
            this.rbMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMid.Location = new System.Drawing.Point(6, 52);
            this.rbMid.Name = "rbMid";
            this.rbMid.Size = new System.Drawing.Size(67, 21);
            this.rbMid.TabIndex = 4;
            this.rbMid.TabStop = true;
            this.rbMid.Text = "Middle";
            this.rbMid.UseVisualStyleBackColor = true;
            this.rbMid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            // 
            // rbLow
            // 
            this.rbLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLow.AutoSize = true;
            this.rbLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLow.Location = new System.Drawing.Point(6, 25);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(51, 21);
            this.rbLow.TabIndex = 4;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "Low";
            this.rbLow.UseVisualStyleBackColor = true;
            this.rbLow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            // 
            // gbDif
            // 
            this.gbDif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDif.Controls.Add(this.rbLow);
            this.gbDif.Controls.Add(this.rbHigh);
            this.gbDif.Controls.Add(this.rbMid);
            this.gbDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbDif.Location = new System.Drawing.Point(380, 249);
            this.gbDif.Name = "gbDif";
            this.gbDif.Size = new System.Drawing.Size(102, 108);
            this.gbDif.TabIndex = 6;
            this.gbDif.TabStop = false;
            this.gbDif.Text = "Difficulty";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(398, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Next";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 623);
            this.Controls.Add(this.gbDif);
            this.Controls.Add(this.pnPrev);
            this.Controls.Add(this.label2);
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
            this.gbDif.ResumeLayout(false);
            this.gbDif.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbDif;
        private System.Windows.Forms.Label label2;
    }
}

