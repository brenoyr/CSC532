﻿namespace Fall2020_CSC403_Project {
  partial class FrmBattle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.btnAttack = new System.Windows.Forms.Button();
			this.lblPlayerHealthFull = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblEnemyHealthFull = new System.Windows.Forms.Label();
			this.picBossBattle = new System.Windows.Forms.PictureBox();
			this.picEnemy = new System.Windows.Forms.PictureBox();
			this.picPlayer = new System.Windows.Forms.PictureBox();
			this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
			this.btnSkills = new System.Windows.Forms.Button();
			this.panelSkills = new System.Windows.Forms.Panel();
			this.btnSkill2 = new System.Windows.Forms.Button();
			this.btnSkill1 = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
			this.panelSkills.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAttack
			// 
			this.btnAttack.BackColor = System.Drawing.Color.OldLace;
			this.btnAttack.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAttack.ForeColor = System.Drawing.Color.Green;
			this.btnAttack.Location = new System.Drawing.Point(124, 428);
			this.btnAttack.Margin = new System.Windows.Forms.Padding(8, 8, 38, 84);
			this.btnAttack.Name = "btnAttack";
			this.btnAttack.Size = new System.Drawing.Size(128, 43);
			this.btnAttack.TabIndex = 2;
			this.btnAttack.Text = "Attack";
			this.btnAttack.UseVisualStyleBackColor = false;
			this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
			// 
			// lblPlayerHealthFull
			// 
			this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
			this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
			this.lblPlayerHealthFull.Location = new System.Drawing.Point(71, 60);
			this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
			this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 20);
			this.lblPlayerHealthFull.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(70, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 23);
			this.label1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(515, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(229, 23);
			this.label2.TabIndex = 5;
			// 
			// lblEnemyHealthFull
			// 
			this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
			this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
			this.lblEnemyHealthFull.Location = new System.Drawing.Point(516, 60);
			this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
			this.lblEnemyHealthFull.Size = new System.Drawing.Size(226, 20);
			this.lblEnemyHealthFull.TabIndex = 6;
			// 
			// picBossBattle
			// 
			this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
			this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picBossBattle.Location = new System.Drawing.Point(780, 563);
			this.picBossBattle.Name = "picBossBattle";
			this.picBossBattle.Size = new System.Drawing.Size(30, 28);
			this.picBossBattle.TabIndex = 7;
			this.picBossBattle.TabStop = false;
			this.picBossBattle.Visible = false;
			// 
			// picEnemy
			// 
			this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
			this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
			this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picEnemy.Location = new System.Drawing.Point(515, 98);
			this.picEnemy.Margin = new System.Windows.Forms.Padding(38, 42, 75, 42);
			this.picEnemy.Name = "picEnemy";
			this.picEnemy.Size = new System.Drawing.Size(229, 267);
			this.picEnemy.TabIndex = 1;
			this.picEnemy.TabStop = false;
			// 
			// picPlayer
			// 
			this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
			this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
			this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picPlayer.Location = new System.Drawing.Point(70, 98);
			this.picPlayer.Name = "picPlayer";
			this.picPlayer.Size = new System.Drawing.Size(229, 267);
			this.picPlayer.TabIndex = 0;
			this.picPlayer.TabStop = false;
			// 
			// tmrFinalBattle
			// 
			this.tmrFinalBattle.Interval = 5600;
			this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
			// 
			// btnSkills
			// 
			this.btnSkills.BackColor = System.Drawing.Color.OldLace;
			this.btnSkills.Font = new System.Drawing.Font("MV Boli", 18F);
			this.btnSkills.ForeColor = System.Drawing.Color.Green;
			this.btnSkills.Location = new System.Drawing.Point(0, 47);
			this.btnSkills.Margin = new System.Windows.Forms.Padding(8, 8, 38, 84);
			this.btnSkills.Name = "btnSkills";
			this.btnSkills.Size = new System.Drawing.Size(128, 43);
			this.btnSkills.TabIndex = 2;
			this.btnSkills.Text = "Skills";
			this.btnSkills.UseVisualStyleBackColor = false;
			this.btnSkills.Click += new System.EventHandler(this.btnSkills_Click);
			// 
			// panelSkills
			// 
			this.panelSkills.Controls.Add(this.btnSkill2);
			this.panelSkills.Controls.Add(this.btnSkill1);
			this.panelSkills.Controls.Add(this.btnSkills);
			this.panelSkills.Location = new System.Drawing.Point(341, 381);
			this.panelSkills.MaximumSize = new System.Drawing.Size(257, 134);
			this.panelSkills.MinimumSize = new System.Drawing.Size(129, 134);
			this.panelSkills.Name = "panelSkills";
			this.panelSkills.Size = new System.Drawing.Size(129, 134);
			this.panelSkills.TabIndex = 8;
			// 
			// btnSkill2
			// 
			this.btnSkill2.BackColor = System.Drawing.Color.OldLace;
			this.btnSkill2.Font = new System.Drawing.Font("MV Boli", 18F);
			this.btnSkill2.ForeColor = System.Drawing.Color.Green;
			this.btnSkill2.Location = new System.Drawing.Point(129, 82);
			this.btnSkill2.Margin = new System.Windows.Forms.Padding(8, 8, 38, 84);
			this.btnSkill2.Name = "btnSkill2";
			this.btnSkill2.Size = new System.Drawing.Size(128, 43);
			this.btnSkill2.TabIndex = 4;
			this.btnSkill2.Text = "2";
			this.btnSkill2.UseVisualStyleBackColor = false;
			this.btnSkill2.Click += new System.EventHandler(this.btnSkill2_Click);
			this.btnSkill2.MouseLeave += new System.EventHandler(this.btnSkill2_MouseLeave);
			this.btnSkill2.MouseHover += new System.EventHandler(this.btnSkill2_MouseHover);
			// 
			// btnSkill1
			// 
			this.btnSkill1.BackColor = System.Drawing.Color.OldLace;
			this.btnSkill1.Font = new System.Drawing.Font("MV Boli", 18F);
			this.btnSkill1.ForeColor = System.Drawing.Color.Green;
			this.btnSkill1.Location = new System.Drawing.Point(129, 8);
			this.btnSkill1.Margin = new System.Windows.Forms.Padding(8, 8, 38, 84);
			this.btnSkill1.Name = "btnSkill1";
			this.btnSkill1.Size = new System.Drawing.Size(128, 43);
			this.btnSkill1.TabIndex = 3;
			this.btnSkill1.Text = "1";
			this.btnSkill1.UseVisualStyleBackColor = false;
			this.btnSkill1.Click += new System.EventHandler(this.btnSkill1_Click);
			this.btnSkill1.MouseLeave += new System.EventHandler(this.btnSkill1_MouseLeave);
			this.btnSkill1.MouseHover += new System.EventHandler(this.btnSkill1_MouseHover);
			// 
			// txtDescription
			// 
			this.txtDescription.BackColor = System.Drawing.Color.OldLace;
			this.txtDescription.Font = new System.Drawing.Font("MV Boli", 12F);
			this.txtDescription.ForeColor = System.Drawing.Color.Green;
			this.txtDescription.Location = new System.Drawing.Point(627, 390);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(134, 116);
			this.txtDescription.TabIndex = 9;
			this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDescription.Visible = false;
			// 
			// FrmBattle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Green;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(822, 538);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.panelSkills);
			this.Controls.Add(this.picBossBattle);
			this.Controls.Add(this.lblEnemyHealthFull);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblPlayerHealthFull);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAttack);
			this.Controls.Add(this.picEnemy);
			this.Controls.Add(this.picPlayer);
			this.DoubleBuffered = true;
			this.Name = "FrmBattle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Fight!";
			this.Load += new System.EventHandler(this.FrmBattle_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
			this.panelSkills.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnAttack;
    private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
        private System.Windows.Forms.Button btnSkills;
		private System.Windows.Forms.Panel panelSkills;
		private System.Windows.Forms.Button btnSkill2;
		private System.Windows.Forms.Button btnSkill1;
		private System.Windows.Forms.TextBox txtDescription;
	}
}