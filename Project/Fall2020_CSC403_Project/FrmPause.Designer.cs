﻿namespace Fall2020_CSC403_Project
{
  partial class FrmPause
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
      this.btnResume = new System.Windows.Forms.Button();
      this.btnRestart = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.btnStats = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnResume
      // 
      this.btnResume.Location = new System.Drawing.Point(247, 30);
      this.btnResume.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnResume.Name = "btnResume";
      this.btnResume.Size = new System.Drawing.Size(220, 125);
      this.btnResume.TabIndex = 0;
      this.btnResume.Text = "RESUME";
      this.btnResume.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnResume.UseVisualStyleBackColor = true;
      this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
      // 
      // btnRestart
      // 
      this.btnRestart.Location = new System.Drawing.Point(247, 195);
      this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnRestart.Name = "btnRestart";
      this.btnRestart.Size = new System.Drawing.Size(220, 125);
      this.btnRestart.TabIndex = 1;
      this.btnRestart.Text = "RESTART";
      this.btnRestart.UseVisualStyleBackColor = true;
      this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.Location = new System.Drawing.Point(247, 537);
      this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(220, 125);
      this.btnQuit.TabIndex = 2;
      this.btnQuit.Text = "QUIT";
      this.btnQuit.UseVisualStyleBackColor = true;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // btnStats
      // 
      this.btnStats.Location = new System.Drawing.Point(247, 363);
      this.btnStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnStats.Name = "btnStats";
      this.btnStats.Size = new System.Drawing.Size(220, 125);
      this.btnStats.TabIndex = 3;
      this.btnStats.Text = "STATS";
      this.btnStats.UseVisualStyleBackColor = true;
      this.btnStats.Click += new System.EventHandler(this.btnShow_Statistics);
      // 
      // FrmPause
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(698, 749);
      this.Controls.Add(this.btnStats);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnRestart);
      this.Controls.Add(this.btnResume);
      this.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.Name = "FrmPause";
      this.Text = "Pause Menu";
      this.Load += new System.EventHandler(this.FrmPause_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button btnResume;
    private System.Windows.Forms.Button btnRestart;
    private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStats;
    }
}