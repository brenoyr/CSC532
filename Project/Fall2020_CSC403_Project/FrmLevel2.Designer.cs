namespace Fall2020_CSC403_Project
{
    partial class FrmLevel2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel2));
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.picWall0 = new System.Windows.Forms.PictureBox();
      this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
      this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
      this.picWall1 = new System.Windows.Forms.PictureBox();
      this.picWall2 = new System.Windows.Forms.PictureBox();
      this.picWall3 = new System.Windows.Forms.PictureBox();
      this.picWall4 = new System.Windows.Forms.PictureBox();
      this.picWall5 = new System.Windows.Forms.PictureBox();
      this.picWall6 = new System.Windows.Forms.PictureBox();
      this.picWall7 = new System.Windows.Forms.PictureBox();
      this.picWall8 = new System.Windows.Forms.PictureBox();
      this.picWall9 = new System.Windows.Forms.PictureBox();
      this.lblInGameTime = new System.Windows.Forms.Label();
      this.EXPlabel = new System.Windows.Forms.Label();
      this.lblPlayerExperience = new System.Windows.Forms.Label();
      this.picBgMusic = new System.Windows.Forms.PictureBox();
      this.bgmusic = new System.Windows.Forms.Label();
      this.HPlabel = new System.Windows.Forms.Label();
      this.lblPlayerHealthFull = new System.Windows.Forms.Label();
      this.picEnemyBullet = new System.Windows.Forms.PictureBox();
      this.medkit0 = new System.Windows.Forms.PictureBox();
      this.medkit1 = new System.Windows.Forms.PictureBox();
      this.picBossSolomon = new System.Windows.Forms.PictureBox();
      this.picOffScreenEnemy = new System.Windows.Forms.PictureBox();
      this.picOffScreenPlayer = new System.Windows.Forms.PictureBox();
      this.spikes0 = new System.Windows.Forms.PictureBox();
      this.spikes1 = new System.Windows.Forms.PictureBox();
      this.spikes2 = new System.Windows.Forms.PictureBox();
      this.mazeMarker = new System.Windows.Forms.PictureBox();
      this.triviaMarker = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBgMusic)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyBullet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.medkit0)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.medkit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossSolomon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picOffScreenEnemy)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picOffScreenPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spikes0)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spikes1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spikes2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mazeMarker)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.triviaMarker)).BeginInit();
      this.SuspendLayout();
      // 
      // picPlayer
      // 
      this.picPlayer.BackColor = System.Drawing.Color.Transparent;
      this.picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.still_front;
      this.picPlayer.Location = new System.Drawing.Point(808, 265);
      this.picPlayer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(224, 248);
      this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.picPlayer.TabIndex = 1;
      this.picPlayer.TabStop = false;
      // 
      // picWall0
      // 
      this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall0.Location = new System.Drawing.Point(-24, 129);
      this.picWall0.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall0.Name = "picWall0";
      this.picWall0.Size = new System.Drawing.Size(251, 1841);
      this.picWall0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall0.TabIndex = 0;
      this.picWall0.TabStop = false;
      // 
      // tmrUpdateInGameTime
      // 
      this.tmrUpdateInGameTime.Enabled = true;
      this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
      // 
      // tmrPlayerMove
      // 
      this.tmrPlayerMove.Enabled = true;
      this.tmrPlayerMove.Interval = 10;
      this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
      // 
      // picWall1
      // 
      this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall1.Location = new System.Drawing.Point(-24, -10);
      this.picWall1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall1.Name = "picWall1";
      this.picWall1.Size = new System.Drawing.Size(2280, 231);
      this.picWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall1.TabIndex = 2;
      this.picWall1.TabStop = false;
      // 
      // picWall2
      // 
      this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall2.Location = new System.Drawing.Point(2069, 129);
      this.picWall2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall2.Name = "picWall2";
      this.picWall2.Size = new System.Drawing.Size(187, 1841);
      this.picWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall2.TabIndex = 3;
      this.picWall2.TabStop = false;
      // 
      // picWall3
      // 
      this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall3.Location = new System.Drawing.Point(-24, 1824);
      this.picWall3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall3.Name = "picWall3";
      this.picWall3.Size = new System.Drawing.Size(2280, 145);
      this.picWall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall3.TabIndex = 4;
      this.picWall3.TabStop = false;
      // 
      // picWall4
      // 
      this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall4.Location = new System.Drawing.Point(693, 534);
      this.picWall4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall4.Name = "picWall4";
      this.picWall4.Size = new System.Drawing.Size(984, 91);
      this.picWall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall4.TabIndex = 5;
      this.picWall4.TabStop = false;
      // 
      // picWall5
      // 
      this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall5.Location = new System.Drawing.Point(506, 1571);
      this.picWall5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall5.Name = "picWall5";
      this.picWall5.Size = new System.Drawing.Size(83, 265);
      this.picWall5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall5.TabIndex = 6;
      this.picWall5.TabStop = false;
      // 
      // picWall6
      // 
      this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall6.Location = new System.Drawing.Point(1267, 1571);
      this.picWall6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall6.Name = "picWall6";
      this.picWall6.Size = new System.Drawing.Size(83, 265);
      this.picWall6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall6.TabIndex = 7;
      this.picWall6.TabStop = false;
      // 
      // picWall7
      // 
      this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall7.Location = new System.Drawing.Point(1661, 1571);
      this.picWall7.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall7.Name = "picWall7";
      this.picWall7.Size = new System.Drawing.Size(83, 265);
      this.picWall7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall7.TabIndex = 8;
      this.picWall7.TabStop = false;
      // 
      // picWall8
      // 
      this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall8.Location = new System.Drawing.Point(693, 222);
      this.picWall8.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall8.Name = "picWall8";
      this.picWall8.Size = new System.Drawing.Size(72, 832);
      this.picWall8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall8.TabIndex = 9;
      this.picWall8.TabStop = false;
      // 
      // picWall9
      // 
      this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
      this.picWall9.Location = new System.Drawing.Point(1389, 613);
      this.picWall9.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picWall9.Name = "picWall9";
      this.picWall9.Size = new System.Drawing.Size(288, 441);
      this.picWall9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picWall9.TabIndex = 10;
      this.picWall9.TabStop = false;
      // 
      // lblInGameTime
      // 
      this.lblInGameTime.AutoSize = true;
      this.lblInGameTime.BackColor = System.Drawing.Color.White;
      this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInGameTime.ForeColor = System.Drawing.Color.Black;
      this.lblInGameTime.Location = new System.Drawing.Point(32, 21);
      this.lblInGameTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.lblInGameTime.Name = "lblInGameTime";
      this.lblInGameTime.Size = new System.Drawing.Size(121, 44);
      this.lblInGameTime.TabIndex = 2;
      this.lblInGameTime.Text = "label1";
      // 
      // EXPlabel
      // 
      this.EXPlabel.AutoSize = true;
      this.EXPlabel.BackColor = System.Drawing.Color.White;
      this.EXPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EXPlabel.Location = new System.Drawing.Point(435, 100);
      this.EXPlabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.EXPlabel.Name = "EXPlabel";
      this.EXPlabel.Size = new System.Drawing.Size(219, 44);
      this.EXPlabel.TabIndex = 36;
      this.EXPlabel.Text = "Experience";
      // 
      // lblPlayerExperience
      // 
      this.lblPlayerExperience.BackColor = System.Drawing.Color.Blue;
      this.lblPlayerExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.lblPlayerExperience.ForeColor = System.Drawing.Color.White;
      this.lblPlayerExperience.Location = new System.Drawing.Point(701, 100);
      this.lblPlayerExperience.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.lblPlayerExperience.Name = "lblPlayerExperience";
      this.lblPlayerExperience.Size = new System.Drawing.Size(605, 50);
      this.lblPlayerExperience.TabIndex = 35;
      // 
      // picBgMusic
      // 
      this.picBgMusic.BackColor = System.Drawing.SystemColors.ControlLight;
      this.picBgMusic.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.mute;
      this.picBgMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBgMusic.Location = new System.Drawing.Point(80, 186);
      this.picBgMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.picBgMusic.Name = "picBgMusic";
      this.picBgMusic.Size = new System.Drawing.Size(75, 64);
      this.picBgMusic.TabIndex = 34;
      this.picBgMusic.TabStop = false;
      // 
      // bgmusic
      // 
      this.bgmusic.BackColor = System.Drawing.Color.Black;
      this.bgmusic.Font = new System.Drawing.Font("MV Boli", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bgmusic.ForeColor = System.Drawing.Color.White;
      this.bgmusic.Location = new System.Drawing.Point(3, 265);
      this.bgmusic.Name = "bgmusic";
      this.bgmusic.Size = new System.Drawing.Size(213, 138);
      this.bgmusic.TabIndex = 33;
      this.bgmusic.Text = "Space Button";
      this.bgmusic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // HPlabel
      // 
      this.HPlabel.BackColor = System.Drawing.Color.Ivory;
      this.HPlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.HPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HPlabel.Location = new System.Drawing.Point(429, 21);
      this.HPlabel.Name = "HPlabel";
      this.HPlabel.Size = new System.Drawing.Size(245, 47);
      this.HPlabel.TabIndex = 32;
      this.HPlabel.Text = "Player HP";
      this.HPlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblPlayerHealthFull
      // 
      this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Maroon;
      this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
      this.lblPlayerHealthFull.Location = new System.Drawing.Point(699, 24);
      this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
      this.lblPlayerHealthFull.Size = new System.Drawing.Size(605, 50);
      this.lblPlayerHealthFull.TabIndex = 31;
      // 
      // picEnemyBullet
      // 
      this.picEnemyBullet.BackColor = System.Drawing.Color.Transparent;
      this.picEnemyBullet.Image = global::Fall2020_CSC403_Project.Properties.Resources.bullet_right;
      this.picEnemyBullet.Location = new System.Drawing.Point(267, 1083);
      this.picEnemyBullet.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picEnemyBullet.Name = "picEnemyBullet";
      this.picEnemyBullet.Size = new System.Drawing.Size(307, 241);
      this.picEnemyBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picEnemyBullet.TabIndex = 37;
      this.picEnemyBullet.TabStop = false;
      // 
      // medkit0
      // 
      this.medkit0.BackColor = System.Drawing.Color.Transparent;
      this.medkit0.Image = global::Fall2020_CSC403_Project.Properties.Resources.medkit;
      this.medkit0.Location = new System.Drawing.Point(293, 1622);
      this.medkit0.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.medkit0.Name = "medkit0";
      this.medkit0.Size = new System.Drawing.Size(141, 162);
      this.medkit0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.medkit0.TabIndex = 38;
      this.medkit0.TabStop = false;
      // 
      // medkit1
      // 
      this.medkit1.BackColor = System.Drawing.Color.Transparent;
      this.medkit1.Image = global::Fall2020_CSC403_Project.Properties.Resources.medkit;
      this.medkit1.Location = new System.Drawing.Point(867, 665);
      this.medkit1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.medkit1.Name = "medkit1";
      this.medkit1.Size = new System.Drawing.Size(141, 162);
      this.medkit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.medkit1.TabIndex = 39;
      this.medkit1.TabStop = false;
      // 
      // picBossSolomon
      // 
      this.picBossSolomon.BackColor = System.Drawing.Color.Transparent;
      this.picBossSolomon.Image = global::Fall2020_CSC403_Project.Properties.Resources.enemy_solomon;
      this.picBossSolomon.Location = new System.Drawing.Point(243, 222);
      this.picBossSolomon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.picBossSolomon.Name = "picBossSolomon";
      this.picBossSolomon.Size = new System.Drawing.Size(435, 444);
      this.picBossSolomon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picBossSolomon.TabIndex = 40;
      this.picBossSolomon.TabStop = false;
      // 
      // picOffScreenEnemy
      // 
      this.picOffScreenEnemy.Location = new System.Drawing.Point(-1861, 2);
      this.picOffScreenEnemy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.picOffScreenEnemy.Name = "picOffScreenEnemy";
      this.picOffScreenEnemy.Size = new System.Drawing.Size(101, 50);
      this.picOffScreenEnemy.TabIndex = 41;
      this.picOffScreenEnemy.TabStop = false;
      // 
      // picOffScreenPlayer
      // 
      this.picOffScreenPlayer.Location = new System.Drawing.Point(-1960, 2);
      this.picOffScreenPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.picOffScreenPlayer.Name = "picOffScreenPlayer";
      this.picOffScreenPlayer.Size = new System.Drawing.Size(101, 50);
      this.picOffScreenPlayer.TabIndex = 42;
      this.picOffScreenPlayer.TabStop = false;
      // 
      // spikes0
      // 
      this.spikes0.BackColor = System.Drawing.Color.Transparent;
      this.spikes0.Image = global::Fall2020_CSC403_Project.Properties.Resources.spikes;
      this.spikes0.Location = new System.Drawing.Point(605, 1717);
      this.spikes0.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.spikes0.Name = "spikes0";
      this.spikes0.Size = new System.Drawing.Size(211, 119);
      this.spikes0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.spikes0.TabIndex = 43;
      this.spikes0.TabStop = false;
      // 
      // spikes1
      // 
      this.spikes1.BackColor = System.Drawing.Color.Transparent;
      this.spikes1.Image = global::Fall2020_CSC403_Project.Properties.Resources.spikes;
      this.spikes1.Location = new System.Drawing.Point(808, 1717);
      this.spikes1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.spikes1.Name = "spikes1";
      this.spikes1.Size = new System.Drawing.Size(224, 119);
      this.spikes1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.spikes1.TabIndex = 44;
      this.spikes1.TabStop = false;
      // 
      // spikes2
      // 
      this.spikes2.BackColor = System.Drawing.Color.Transparent;
      this.spikes2.Image = global::Fall2020_CSC403_Project.Properties.Resources.spikes;
      this.spikes2.Location = new System.Drawing.Point(1024, 1717);
      this.spikes2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.spikes2.Name = "spikes2";
      this.spikes2.Size = new System.Drawing.Size(227, 119);
      this.spikes2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.spikes2.TabIndex = 45;
      this.spikes2.TabStop = false;
      // 
      // mazeMarker
      // 
      this.mazeMarker.BackColor = System.Drawing.Color.Transparent;
      this.mazeMarker.Image = ((System.Drawing.Image)(resources.GetObject("mazeMarker.Image")));
      this.mazeMarker.Location = new System.Drawing.Point(1843, 1717);
      this.mazeMarker.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.mazeMarker.Name = "mazeMarker";
      this.mazeMarker.Size = new System.Drawing.Size(133, 119);
      this.mazeMarker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.mazeMarker.TabIndex = 46;
      this.mazeMarker.TabStop = false;
      // 
      // triviaMarker
      // 
      this.triviaMarker.BackColor = System.Drawing.Color.Transparent;
      this.triviaMarker.Image = global::Fall2020_CSC403_Project.Properties.Resources.greenMarker;
      this.triviaMarker.Location = new System.Drawing.Point(1421, 1717);
      this.triviaMarker.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.triviaMarker.Name = "triviaMarker";
      this.triviaMarker.Size = new System.Drawing.Size(133, 119);
      this.triviaMarker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.triviaMarker.TabIndex = 47;
      this.triviaMarker.TabStop = false;
      // 
      // FrmLevel2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(2224, 1934);
      this.Controls.Add(this.triviaMarker);
      this.Controls.Add(this.mazeMarker);
      this.Controls.Add(this.spikes2);
      this.Controls.Add(this.spikes1);
      this.Controls.Add(this.spikes0);
      this.Controls.Add(this.picOffScreenPlayer);
      this.Controls.Add(this.picOffScreenEnemy);
      this.Controls.Add(this.picBossSolomon);
      this.Controls.Add(this.medkit1);
      this.Controls.Add(this.medkit0);
      this.Controls.Add(this.picEnemyBullet);
      this.Controls.Add(this.EXPlabel);
      this.Controls.Add(this.lblPlayerExperience);
      this.Controls.Add(this.picBgMusic);
      this.Controls.Add(this.bgmusic);
      this.Controls.Add(this.HPlabel);
      this.Controls.Add(this.lblPlayerHealthFull);
      this.Controls.Add(this.lblInGameTime);
      this.Controls.Add(this.picWall9);
      this.Controls.Add(this.picWall8);
      this.Controls.Add(this.picWall7);
      this.Controls.Add(this.picWall6);
      this.Controls.Add(this.picWall5);
      this.Controls.Add(this.picWall4);
      this.Controls.Add(this.picWall3);
      this.Controls.Add(this.picWall2);
      this.Controls.Add(this.picWall1);
      this.Controls.Add(this.picPlayer);
      this.Controls.Add(this.picWall0);
      this.DoubleBuffered = true;
      this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.Name = "FrmLevel2";
      this.Text = "FrmLevel2";
      this.Load += new System.EventHandler(this.FrmLevel2_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel2_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel2_KeyUp);
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBgMusic)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyBullet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.medkit0)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.medkit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossSolomon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picOffScreenEnemy)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picOffScreenPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spikes0)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spikes1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spikes2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mazeMarker)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.triviaMarker)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picPlayer;
        public System.Windows.Forms.Timer tmrUpdateInGameTime;
        public System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox picWall8;
        private System.Windows.Forms.PictureBox picWall9;
        public System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Label EXPlabel;
        private System.Windows.Forms.Label lblPlayerExperience;
        private System.Windows.Forms.PictureBox picBgMusic;
        private System.Windows.Forms.Label bgmusic;
        private System.Windows.Forms.Label HPlabel;
        private System.Windows.Forms.Label lblPlayerHealthFull;
        private System.Windows.Forms.PictureBox picEnemyBullet;
        private System.Windows.Forms.PictureBox medkit0;
        private System.Windows.Forms.PictureBox medkit1;
        private System.Windows.Forms.PictureBox picBossSolomon;
        private System.Windows.Forms.PictureBox picOffScreenEnemy;
        private System.Windows.Forms.PictureBox picOffScreenPlayer;
        private System.Windows.Forms.PictureBox spikes0;
        private System.Windows.Forms.PictureBox spikes1;
        private System.Windows.Forms.PictureBox spikes2;
        private System.Windows.Forms.PictureBox mazeMarker;
        private System.Windows.Forms.PictureBox triviaMarker;
    }
}