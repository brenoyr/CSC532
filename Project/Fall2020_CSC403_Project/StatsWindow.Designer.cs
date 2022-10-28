using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    partial class StatsWindow
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.DamageDoneData = new System.Windows.Forms.Label();
      this.DamageTakenData = new System.Windows.Forms.Label();
      this.ExperienceGainedData = new System.Windows.Forms.Label();
      this.StrengthGainedData = new System.Windows.Forms.Label();
      this.DistanceTraveledData = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.HealthGainedData = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.LevelsGainedData = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoEllipsis = true;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label1.Location = new System.Drawing.Point(64, 20);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(540, 55);
      this.label1.TabIndex = 0;
      this.label1.Text = "GENERAL PLAYTHROUGH STATS";
      // 
      // label2
      // 
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label2.Location = new System.Drawing.Point(-6, 100);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(705, 2);
      this.label2.TabIndex = 1;
      this.label2.Text = "label2";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.SystemColors.Control;
      this.label3.Location = new System.Drawing.Point(68, 148);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(213, 31);
      this.label3.TabIndex = 2;
      this.label3.Text = "Total Damage Done: ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.label4.ForeColor = System.Drawing.SystemColors.Control;
      this.label4.Location = new System.Drawing.Point(68, 192);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(217, 31);
      this.label4.TabIndex = 3;
      this.label4.Text = "Total Damage Taken:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.label5.ForeColor = System.Drawing.SystemColors.Control;
      this.label5.Location = new System.Drawing.Point(68, 326);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(248, 31);
      this.label5.TabIndex = 4;
      this.label5.Text = "Total Experience Gained:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.label6.ForeColor = System.Drawing.SystemColors.Control;
      this.label6.Location = new System.Drawing.Point(68, 368);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(228, 31);
      this.label6.TabIndex = 5;
      this.label6.Text = "Total Strength Gained:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.label7.ForeColor = System.Drawing.SystemColors.Control;
      this.label7.Location = new System.Drawing.Point(68, 502);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(242, 31);
      this.label7.TabIndex = 6;
      this.label7.Text = "Total Distance Traveled:";
      // 
      // DamageDoneData
      // 
      this.DamageDoneData.AutoSize = true;
      this.DamageDoneData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.DamageDoneData.ForeColor = System.Drawing.SystemColors.Control;
      this.DamageDoneData.Location = new System.Drawing.Point(578, 148);
      this.DamageDoneData.Name = "DamageDoneData";
      this.DamageDoneData.Size = new System.Drawing.Size(26, 31);
      this.DamageDoneData.TabIndex = 7;
      this.DamageDoneData.Text = "0";
      // 
      // DamageTakenData
      // 
      this.DamageTakenData.AutoSize = true;
      this.DamageTakenData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.DamageTakenData.ForeColor = System.Drawing.SystemColors.Control;
      this.DamageTakenData.Location = new System.Drawing.Point(578, 192);
      this.DamageTakenData.Name = "DamageTakenData";
      this.DamageTakenData.Size = new System.Drawing.Size(26, 31);
      this.DamageTakenData.TabIndex = 8;
      this.DamageTakenData.Text = "0";
      // 
      // ExperienceGainedData
      // 
      this.ExperienceGainedData.AutoSize = true;
      this.ExperienceGainedData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.ExperienceGainedData.ForeColor = System.Drawing.SystemColors.Control;
      this.ExperienceGainedData.Location = new System.Drawing.Point(578, 326);
      this.ExperienceGainedData.Name = "ExperienceGainedData";
      this.ExperienceGainedData.Size = new System.Drawing.Size(26, 31);
      this.ExperienceGainedData.TabIndex = 9;
      this.ExperienceGainedData.Text = "0";
      // 
      // StrengthGainedData
      // 
      this.StrengthGainedData.AutoSize = true;
      this.StrengthGainedData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.StrengthGainedData.ForeColor = System.Drawing.SystemColors.Control;
      this.StrengthGainedData.Location = new System.Drawing.Point(578, 368);
      this.StrengthGainedData.Name = "StrengthGainedData";
      this.StrengthGainedData.Size = new System.Drawing.Size(26, 31);
      this.StrengthGainedData.TabIndex = 10;
      this.StrengthGainedData.Text = "0";
      // 
      // DistanceTraveledData
      // 
      this.DistanceTraveledData.AutoSize = true;
      this.DistanceTraveledData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.DistanceTraveledData.ForeColor = System.Drawing.SystemColors.Control;
      this.DistanceTraveledData.Location = new System.Drawing.Point(578, 502);
      this.DistanceTraveledData.Name = "DistanceTraveledData";
      this.DistanceTraveledData.Size = new System.Drawing.Size(50, 31);
      this.DistanceTraveledData.TabIndex = 11;
      this.DistanceTraveledData.Text = "0 m";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.label8.ForeColor = System.Drawing.SystemColors.Control;
      this.label8.Location = new System.Drawing.Point(68, 285);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(210, 31);
      this.label8.TabIndex = 12;
      this.label8.Text = "Total Health Gained:";
      this.label8.Click += new System.EventHandler(this.label8_Click);
      // 
      // HealthGainedData
      // 
      this.HealthGainedData.AutoSize = true;
      this.HealthGainedData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.HealthGainedData.ForeColor = System.Drawing.SystemColors.Control;
      this.HealthGainedData.Location = new System.Drawing.Point(578, 285);
      this.HealthGainedData.Name = "HealthGainedData";
      this.HealthGainedData.Size = new System.Drawing.Size(26, 31);
      this.HealthGainedData.TabIndex = 13;
      this.HealthGainedData.Text = "0";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.label10.ForeColor = System.Drawing.SystemColors.Control;
      this.label10.Location = new System.Drawing.Point(68, 408);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(205, 31);
      this.label10.TabIndex = 14;
      this.label10.Text = "Total Levels Gained:";
      // 
      // LevelsGainedData
      // 
      this.LevelsGainedData.AutoSize = true;
      this.LevelsGainedData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold);
      this.LevelsGainedData.ForeColor = System.Drawing.SystemColors.Control;
      this.LevelsGainedData.Location = new System.Drawing.Point(578, 408);
      this.LevelsGainedData.Name = "LevelsGainedData";
      this.LevelsGainedData.Size = new System.Drawing.Size(26, 31);
      this.LevelsGainedData.TabIndex = 15;
      this.LevelsGainedData.Text = "0";
      // 
      // StatsWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(698, 749);
      this.Controls.Add(this.LevelsGainedData);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.HealthGainedData);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.DistanceTraveledData);
      this.Controls.Add(this.StrengthGainedData);
      this.Controls.Add(this.ExperienceGainedData);
      this.Controls.Add(this.DamageTakenData);
      this.Controls.Add(this.DamageDoneData);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "StatsWindow";
      this.Text = "General Playthrough Stats";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btnClose_Click);
      this.Load += new System.EventHandler(this.StatsWindow_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label DamageDoneData;
        private Label DamageTakenData;
        private Label ExperienceGainedData;
        private Label StrengthGainedData;
        private Label DistanceTraveledData;
        private Label label8;
        private Label HealthGainedData;
        private Label label10;
        private Label LevelsGainedData;
    }
}