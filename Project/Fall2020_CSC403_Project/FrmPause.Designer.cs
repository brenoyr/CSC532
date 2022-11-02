namespace Fall2020_CSC403_Project
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadSave = new System.Windows.Forms.Button();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Tw Cen MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(247, 15);
            this.btnResume.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(220, 82);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "RESUME";
            this.btnResume.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Tw Cen MT Condensed", 28F);
            this.btnRestart.Location = new System.Drawing.Point(247, 391);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(220, 82);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Tw Cen MT Condensed", 28F);
            this.btnQuit.Location = new System.Drawing.Point(247, 640);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(220, 82);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Tw Cen MT Condensed", 28F);
            this.btnStats.Location = new System.Drawing.Point(247, 485);
            this.btnStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(220, 82);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "STATS";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnShow_Statistics);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tw Cen MT Condensed", 23F);
            this.btnSave.Location = new System.Drawing.Point(247, 203);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 82);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE CURRENT PROGRESS";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadSave
            // 
            this.btnLoadSave.Font = new System.Drawing.Font("Tw Cen MT Condensed", 28F);
            this.btnLoadSave.Location = new System.Drawing.Point(247, 297);
            this.btnLoadSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadSave.Name = "btnLoadSave";
            this.btnLoadSave.Size = new System.Drawing.Size(220, 82);
            this.btnLoadSave.TabIndex = 5;
            this.btnLoadSave.Text = "LOAD SAVE";
            this.btnLoadSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadSave.UseVisualStyleBackColor = true;
            this.btnLoadSave.Click += new System.EventHandler(this.btnLoadSave_Click);
            // 
            // btnNewSave
            // 
            this.btnNewSave.Font = new System.Drawing.Font("Tw Cen MT Condensed", 27F);
            this.btnNewSave.Location = new System.Drawing.Point(247, 109);
            this.btnNewSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(220, 82);
            this.btnNewSave.TabIndex = 6;
            this.btnNewSave.Text = "CREATE NEW SAVE";
            this.btnNewSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // FrmPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(698, 749);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.btnLoadSave);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadSave;
        private System.Windows.Forms.Button btnNewSave;
    }
}