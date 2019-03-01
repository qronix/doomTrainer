namespace doomTrainerNew
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnAmmo = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblAmmoStatus = new System.Windows.Forms.Label();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.lblHealthStatus = new System.Windows.Forms.Label();
            this.btnHealth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAmmo
            // 
            this.btnAmmo.Location = new System.Drawing.Point(12, 98);
            this.btnAmmo.Name = "btnAmmo";
            this.btnAmmo.Size = new System.Drawing.Size(75, 23);
            this.btnAmmo.TabIndex = 0;
            this.btnAmmo.Text = "Ammo";
            this.btnAmmo.UseVisualStyleBackColor = true;
            this.btnAmmo.Click += new System.EventHandler(this.btnAmmo_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAmmoStatus
            // 
            this.lblAmmoStatus.AutoSize = true;
            this.lblAmmoStatus.Location = new System.Drawing.Point(12, 68);
            this.lblAmmoStatus.Name = "lblAmmoStatus";
            this.lblAmmoStatus.Size = new System.Drawing.Size(56, 13);
            this.lblAmmoStatus.TabIndex = 1;
            this.lblAmmoStatus.Text = "Ammo: Off";
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Location = new System.Drawing.Point(12, 30);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(40, 13);
            this.lblGameStatus.TabIndex = 2;
            this.lblGameStatus.Text = "Status:";
            // 
            // lblHealthStatus
            // 
            this.lblHealthStatus.AutoSize = true;
            this.lblHealthStatus.Location = new System.Drawing.Point(138, 68);
            this.lblHealthStatus.Name = "lblHealthStatus";
            this.lblHealthStatus.Size = new System.Drawing.Size(58, 13);
            this.lblHealthStatus.TabIndex = 3;
            this.lblHealthStatus.Text = "Health: Off";
            // 
            // btnHealth
            // 
            this.btnHealth.Location = new System.Drawing.Point(141, 98);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(75, 23);
            this.btnHealth.TabIndex = 4;
            this.btnHealth.Text = "Health";
            this.btnHealth.UseVisualStyleBackColor = true;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnHealth);
            this.Controls.Add(this.lblHealthStatus);
            this.Controls.Add(this.lblGameStatus);
            this.Controls.Add(this.lblAmmoStatus);
            this.Controls.Add(this.btnAmmo);
            this.Name = "Form1";
            this.Text = "VirtualCopTrainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAmmo;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label lblAmmoStatus;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.Label lblHealthStatus;
        private System.Windows.Forms.Button btnHealth;
    }
}

