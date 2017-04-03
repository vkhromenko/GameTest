using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest
{
    public enum Difficulty {
        Low,
        Middle,
        High,
    }


    class MenuForm : Form
    {
        private Button btStart;
        private Button btExit;
        private Button btSettings;
        private Button startGame;

        private Form mainForm;

        public Difficulty dif { get; set; }

        public MenuForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void InitializeComponent()
        {
            this.btStart = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(37, 48);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(127, 41);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start Game";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(37, 161);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(127, 41);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(37, 105);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(127, 41);
            this.btSettings.TabIndex = 1;
            this.btSettings.Text = "Settings";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // MenuForm
            // 
            this.ClientSize = new System.Drawing.Size(200, 254);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btStart);
            this.Name = "MenuForm";
            this.ResumeLayout(false);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Visible = true;
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm();
        }
    }
}
