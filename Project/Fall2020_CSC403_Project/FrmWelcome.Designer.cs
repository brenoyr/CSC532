
namespace Fall2020_CSC403_Project
{
  partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.welcomeLable = new System.Windows.Forms.Label();
            this.quitBtn = new System.Windows.Forms.Button();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.gifPeanut = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gifPeanut)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLable
            // 
            this.welcomeLable.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeLable.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLable.Location = new System.Drawing.Point(0, 0);
            this.welcomeLable.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLable.Name = "welcomeLable";
            this.welcomeLable.Padding = new System.Windows.Forms.Padding(375, 42, 38, 42);
            this.welcomeLable.Size = new System.Drawing.Size(926, 466);
            this.welcomeLable.TabIndex = 1;
            this.welcomeLable.Text = "Welcome!";
            this.welcomeLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quitBtn
            // 
            this.quitBtn.AutoSize = true;
            this.quitBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.quitBtn.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(627, 329);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(177, 56);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startGameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startGameBtn.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.Location = new System.Drawing.Point(627, 178);
            this.startGameBtn.Margin = new System.Windows.Forms.Padding(75, 1, 112, 252);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(177, 58);
            this.startGameBtn.TabIndex = 2;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // gifPeanut
            // 
            this.gifPeanut.BackColor = System.Drawing.SystemColors.Control;
            this.gifPeanut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gifPeanut.Image = ((System.Drawing.Image)(resources.GetObject("gifPeanut.Image")));
            this.gifPeanut.Location = new System.Drawing.Point(0, 0);
            this.gifPeanut.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gifPeanut.Name = "gifPeanut";
            this.gifPeanut.Size = new System.Drawing.Size(926, 466);
            this.gifPeanut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifPeanut.TabIndex = 0;
            this.gifPeanut.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(75, 1, 112, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "PvP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PvPInit_Click);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.welcomeLable);
            this.Controls.Add(this.gifPeanut);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RUN";
            ((System.ComponentModel.ISupportInitialize)(this.gifPeanut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox gifPeanut;
    private System.Windows.Forms.Label welcomeLable;
    private System.Windows.Forms.Button startGameBtn;
    private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button PvPInit;
        private System.Windows.Forms.Button button1;
    }
}